using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace MS17010Test {
  public static class Tester {
    const int bufferSize = 1024;
    const int timeout = 5000;
    public static TestResult TestIP(string ip) {
      TestResult res = new TestResult();
      try {
        byte[] buffer = new byte[bufferSize];

        Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        client.ReceiveTimeout = timeout;
        client.SendTimeout = timeout;

        IPAddress ipAddress = IPAddress.Parse(ip);
        client.Connect(new IPEndPoint(ipAddress, 445));

        var request = Constants.negotiateProtoRequest();
        client.Send(request);
        var receivedBytes = client.Receive(buffer, SocketFlags.Partial);
        Console.WriteLine($"Received bytes: {receivedBytes}");
        var oBuff = buffer.Take(receivedBytes).ToArray();

        // Do nothing?

        request = Constants.sessionSetupAndxRequest();
        client.Send(request);
        receivedBytes = client.Receive(buffer, SocketFlags.Partial);
        Console.WriteLine($"Received bytes: {receivedBytes}");
        oBuff = buffer.Take(receivedBytes).ToArray();

        var netbiosB = oBuff.Take(4).ToArray();
        var smbHeaderB = oBuff.Skip(4).Take(32).ToArray();
        var smb = Constants.ByteArrayToSmbHeader(smbHeaderB);

        var sessionSetupAndxResponse = oBuff.Skip(36).ToArray();
        var nativeOsB = sessionSetupAndxResponse.Skip(9).ToArray();
        var osData = Encoding.ASCII.GetString(nativeOsB).Split('\x00');

        res.OSName = osData[0];
        if (osData.Count() >= 3) {
          res.OSBuild = osData[1];
          res.Workgroup = osData[2];
        }

        Console.WriteLine($"OS: {osData[0]} - UserId: {smb.user_id}");

        request = Constants.treeConnectAndxRequest(ip, smb.user_id);
        client.Send(request);
        receivedBytes = client.Receive(buffer, SocketFlags.Partial);
        oBuff = buffer.Take(receivedBytes).ToArray();

        netbiosB = oBuff.Take(4).ToArray();
        smbHeaderB = oBuff.Skip(4).Take(32).ToArray();
        smb = Constants.ByteArrayToSmbHeader(smbHeaderB);

        request = Constants.peeknamedpipeRequest(smb.tree_id, smb.process_id, smb.user_id, smb.multiplex_id);
        client.Send(request);
        receivedBytes = client.Receive(buffer, SocketFlags.Partial);
        oBuff = buffer.Take(receivedBytes).ToArray();

        netbiosB = oBuff.Take(4).ToArray();
        smbHeaderB = oBuff.Skip(4).Take(32).ToArray();
        smb = Constants.ByteArrayToSmbHeader(smbHeaderB);

        // 0xC000 02 05 - STATUS_INSUFF_SERVER_RESOURCES - vulnerable
        // 0xC000 00 08 - STATUS_INVALID_HANDLE
        // 0xC000 00 22 - STATUS_ACCESS_DENIED
        res.IsVulnerable = (smb.error_class == 0x05 && smb.reserved1 == 0x02 && smb.error_code == 0xC000);
        res.VulnerabilityOK = (smb.error_class == 0x08 && smb.reserved1 == 0x00 && smb.error_code == 0xC000) ||
          (smb.error_class == 0x22 && smb.reserved1 == 0x00 && smb.error_code == 0xC000);

        client.Close();
        return res;
      } catch (SocketException e) {
        if (e.SocketErrorCode == SocketError.ConnectionReset) {
          res.IsVulnerable = false;
          res.VulnerabilityOK = false;
          return res;
        } else {
          throw e;
        }
      }
      return null;
    }

  }
}
