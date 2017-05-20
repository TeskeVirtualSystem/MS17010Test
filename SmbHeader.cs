using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MS17010Test {
  [StructLayout(LayoutKind.Sequential, Pack = 1)]
  public struct SmbHeader {
    public UInt32 server_component;
    public byte smb_command;
    public byte error_class;
    public byte reserved1;
    public UInt16 error_code;
    public byte flags;
    public UInt16 flags2;
    public UInt16 process_id_high;
    public UInt64 signature;
    public UInt16 reserved2;
    public UInt16 tree_id;
    public UInt16 process_id;
    public UInt16 user_id;
    public UInt16 multiplex_id;
  }
}
