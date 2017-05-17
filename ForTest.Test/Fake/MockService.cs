using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogAn.Test
{
  public class MockService : IWebService
  {
    public string LastError { get; set; }
    public void LogError(string message)
    {
      LastError = message;
    }
  }
}
