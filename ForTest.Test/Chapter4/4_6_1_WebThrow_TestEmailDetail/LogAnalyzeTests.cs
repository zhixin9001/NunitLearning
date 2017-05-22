using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogAn.Chapter4._4_6_1_WebThrow_TestEmailDetail;

namespace LogAn.Test.Chapter4._4_6_1_WebThrow_TestEmailDetail
{
  [TestFixture]
  class LogAnalyzeTests
  {
    [Test]
    public void Analyze_TooShortFileName_CallsWebService()
    {
      FakeWebService mockWebService = new FakeWebService();
      FakeEmailService mockEmailService = new FakeEmailService();
      mockWebService.ToThrow = new Exception("fake exception");
      LogAnalyzer log = new LogAnalyzer(mockWebService, mockEmailService);
      log.Analyze("a.123");
      EmailInfo emailInfo = new EmailInfo
      {
        To = "To",
        Subject = "Subject",
        Body = "fake exception"
      };
      Assert.AreEqual(emailInfo.Body, mockEmailService.emailInfo.Body);

    }
  }
}
