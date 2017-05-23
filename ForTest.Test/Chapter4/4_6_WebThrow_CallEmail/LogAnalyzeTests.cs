using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogAn.Chapter4._4_6_WebThrow_CallEmail;

namespace LogAn.Test.Chapter4._4_6_WebThrow_CallEmail
{
  [TestFixture]
  class LogAnalyzeTests
  {
    [Test]
    public void Analyze_TooShortFileName_CallsWebService()
    {
      FakeWebService mockWebService = 
        new FakeWebService();
      FakeEmailService mockEmailService = 
        new FakeEmailService();
      mockWebService.ToThrow = 
        new Exception("fake exception");
      LogAnalyzer log = 
        new LogAnalyzer(mockWebService,mockEmailService);
      log.Analyze("a.123");
      StringAssert.Contains("fake exception"
        , mockEmailService.Body);
    }
  }
}
