using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS17010Test {
  public class TestResult {
    public bool IsVulnerable;
    public bool VulnerabilityOK;
    public bool hadError;
    public string error;
    public string OSName;
    public string OSBuild;
    public string Workgroup;

    public TestResult() {
      IsVulnerable = false;
      VulnerabilityOK = false;
      hadError = false;
      OSName = strings.unknown;
      OSBuild = strings.unknown;
      Workgroup = strings.unknown;
      error = "";
    }
  }
}
