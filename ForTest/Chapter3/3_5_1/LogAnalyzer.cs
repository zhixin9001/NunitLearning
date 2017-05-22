using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogAn.Chapter3._3_5_1
{

  internal class LogAnalyzer : LogAnalyzerUsingFactoryMethod
  {
    public bool IsSupported { get; set; }

    protected override bool IsValid(string fileName)
    {
#if DEBUG
      IfDebug();
#endif

      Con();
      return IsSupported;
    }
    [Conditional("DEBUG")]
    private void Con()
    {

    }
#if DEBUG
    private void IfDebug()
    {

    }
#endif



  }
}
