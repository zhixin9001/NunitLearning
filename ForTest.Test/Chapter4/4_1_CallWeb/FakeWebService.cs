using LogAn.Chapter4._4_1_CallWeb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogAn.Test.Chapter4._4_1_CallWeb
{
  class FakeWebService : IWebService
  {
    public string LastError { get; set; }

    public void LogError(string message)
    {
      LastError = message;
    }
  }
}
