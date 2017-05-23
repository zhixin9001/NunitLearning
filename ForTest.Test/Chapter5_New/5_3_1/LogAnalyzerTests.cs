using LogAn.Chapter5_New._5_3_1;
using NSubstitute;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogAn.Test.Chapter5_New._5_3_1
{
  [TestFixture]
  public class LogAnalyzerTests
  {
    [Test]
    public void Analyze_FileNameTooShort_CallLogger()
    {
      ILogger logger = Substitute.For<ILogger>();
      logger.When(x => x.LogError(Arg.Any<string>())).Do(c => { throw new Exception("fake exception"); });

      IWebService webber = Substitute.For<IWebService>();
      var analyzer = new LogAnalyzer(logger, webber);
      analyzer.Analyze("a");
      webber.Received().SendMsg(Arg.Any<string>());
    }
  }
}
