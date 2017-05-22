using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogAn.Chapter3._3_4_6_1_Factory
{
  public class LogAnalyzer
  {
    private IExtensionManager extensionManager;

    public LogAnalyzer()
    {
      extensionManager = ExtensionManagerFactory.Create();
    }

    public bool IsValidLogFileName(string fileName)
    {
      return extensionManager.IsValid(fileName);
    }
  }
}
