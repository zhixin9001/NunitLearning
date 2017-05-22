using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogAn.Chapter3._3_4_6_2_Virtual
{
  public class LogAnalyzer : LogAnalyzerUsingFactoryMethod
  {
    public IExtensionManager extensionManager;

    public LogAnalyzer(IExtensionManager mgr)
    {
      extensionManager = mgr;
    }

    protected override IExtensionManager GetManager()
    {
      return extensionManager;
    }
  }
}
