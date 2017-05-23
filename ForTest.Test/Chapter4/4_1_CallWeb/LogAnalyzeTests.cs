using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogAn.Chapter4._4_1_CallWeb;

namespace LogAn.Test.Chapter4._4_1_CallWeb
{
  [TestFixture]
  class LogAnalyzeTests
  {
    [Test]
    public void Analyze_TooShortFileName_CallsWebService()
    {
      FakeWebService mockService = new FakeWebService();
      LogAnalyzer log = new LogAnalyzer(mockService);
      string tooShortFileName = "a.123";
      log.Analyze(tooShortFileName);
      StringAssert.Contains("Filename too short:"
        +tooShortFileName,mockService.LastError);
    }
  }
}
