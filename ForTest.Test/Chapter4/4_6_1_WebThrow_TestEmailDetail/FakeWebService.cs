using LogAn.Chapter4._4_6_1_WebThrow_TestEmailDetail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogAn.Test.Chapter4._4_6_1_WebThrow_TestEmailDetail
{
  class FakeWebService : IWebService
  {
    public Exception ToThrow;
    public void LogError(string message)
    {
      if (ToThrow != null)
      {
        throw ToThrow;
      }
    }
  }
}
