using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogAn.Chapter3._3_4_3_Constructor_Injection
{
  public class LogAnalyzer
  {
    private IExtensionManager manager;

    public LogAnalyzer(IExtensionManager mgr)
    {
      manager = mgr;
    }

    public bool IsValidLogFileName(string fileName)
    {
      return manager.IsValid(fileName);
    }
  }
}
