using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS17010Test {
  public class TestResult {
    public bool IsVulnerable;
    public bool VulnerabilityOK;
    public string OSName;
    public string OSBuild;
    public string Workgroup;

    public TestResult() {
      IsVulnerable = false;
      VulnerabilityOK = false;
      OSName = strings.unknown;
      OSBuild = strings.unknown;
      Workgroup = strings.unknown;
    }
  }
}
