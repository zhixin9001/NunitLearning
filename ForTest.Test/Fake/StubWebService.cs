using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogAn.Test.Fake
{
  public class StubWebService : IWebService
  {
    public Exception ToThrow { get; set; }
    public void LogError(string message)
    {
      if (ToThrow != null)
      {
        throw ToThrow;
      }
    }
  }
}
