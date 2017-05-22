using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogAn.Chapter3._3_5_1
{
  public class LogAnalyzerUsingFactoryMethod
  {
    public bool IsValidLogFileName(string fileName)
    {
      return this.IsValid(fileName);
    }

    protected virtual bool IsValid(string fileName)
    {
      FileExtensionManager mgr = new FileExtensionManager();
      return mgr.IsValid(fileName);
    }
  }
}
