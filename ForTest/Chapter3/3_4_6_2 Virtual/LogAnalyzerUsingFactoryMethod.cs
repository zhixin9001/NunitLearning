using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogAn.Chapter3._3_4_6_2_Virtual
{
  public class LogAnalyzerUsingFactoryMethod
  {
    public bool IsValidLogFileName(string fileName)
    {
      return GetManager().IsValid(fileName);
    }

    protected virtual IExtensionManager GetManager()
    {
      return new FileExtensionManager();
    }
  }
}
