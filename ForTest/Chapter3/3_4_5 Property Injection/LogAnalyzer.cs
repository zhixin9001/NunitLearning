using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogAn.Chapter3._3_4_5_Property_Injection
{
  public class LogAnalyzer
  {
    public IExtensionManager ExtensionManager { get; set; }

    public bool IsValidLogFileName(string fileName)
    {
      return ExtensionManager.IsValid(fileName);
    }
  }
}
