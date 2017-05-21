using LogAn.Chapter5;
using NSubstitute;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogAn.Test.Chapter5
{
  [TestFixture]
  class LogAnalyzerTests
  {
    [Test]
    [Ignore("")]
    public void Analyze_TooShortFileName_CallLogger()
    {
      ILogger logger = Substitute.For<ILogger>();
      LogAn.Chapter5.LogAnalyzer analyzer = new LogAn.Chapter5.LogAnalyzer(logger);
      analyzer.MinNameLength = 6;
      analyzer.Analyze("a.txt");
      logger.Received().LogError("Filename too short:a.txt");
    }
    [Test]
    [Ignore("")]
    public void Returns_ByDefault_WorkForHardCodeArgument()
    {
      IFileNameRules fakeRules = Substitute.For<IFileNameRules>();
      fakeRules.IsValidLogFileName("a.txt").Returns(true);
      Assert.IsTrue(fakeRules.IsValidLogFileName("a.txt"));
    }
    [Test]
    [Ignore("")]
    public void Returns_ByDefault_WorkForIgnoreArgument()
    {
      IFileNameRules fakeRules = Substitute.For<IFileNameRules>();
      fakeRules.IsValidLogFileName(Arg.Any<string>()).Returns(true);
      Assert.IsTrue(fakeRules.IsValidLogFileName("a.txt"));
    }
    [Test]
    [Ignore("")]
    public void Returns_ArgAny_Throws()
    {
      IFileNameRules fakeRules = Substitute.For<IFileNameRules>();
      fakeRules.When(x => x.IsValidLogFileName(Arg.Any<string>()))
          .Do(a => { throw new Exception("fake exception"); });
      Assert.Throws<Exception>(() =>
          fakeRules.IsValidLogFileName("anything"));
    }
    [Test]
    [Ignore("")]
    public void Analyze_LoggerThros_CallsWebService()
    {
      var mockWebService = Substitute.For<LogAn.Chapter5.IWebService>();
      var stubLogger = Substitute.For<ILogger>();
      stubLogger.When(log => log.LogError(Arg.Any<string>()))
        .Do(info => { throw new Exception("fake exception"); });

      var analyzer = new LogAn.Chapter5.LogAnalyzer2(stubLogger, mockWebService);
      analyzer.MinNameLength = 6;
      analyzer.Analyze("a.txt");
      mockWebService.Received().Write(Arg.Is<string>(s => s.Contains("fake exception")));
    }
    [Test]
    public void Anaylze_LoggerThrows_CallsWebServiceWithNSubObject()
    {
      var mockWebService = Substitute.For<IWebService>();
      var stubLogger = Substitute.For<ILogger>();
      stubLogger.When(logger => logger.LogError(Arg.Any<string>()))
          .Do(info => { throw new Exception("fake exception"); });
      var analyzer = new LogAnalyzer3(stubLogger, mockWebService);
      analyzer.MinNameLength = 10;
      analyzer.Analyze("a.txt");
      mockWebService.Received().Write(Arg.Is<ErrorInfo>(info => info.Severity == 1000
        && info.Message.Contains("fake exception")));
    }
    [Test]
    public void Analyze_loggerThrows_CallsWebServiceWithnSubObjecCompare()
    {
      var mockWebService = Substitute.For<IWebService>();
      var stubLogger = Substitute.For<ILogger>();
      stubLogger.When(logger => logger.LogError(Arg.Any<string>()))
            .Do(info => { throw new Exception("fake exception"); });
      var analyzer = new LogAnalyzer3(stubLogger, mockWebService);
      analyzer.MinNameLength = 10;
      analyzer.Analyze("a.txt");
      var expected = new ErrorInfo(1000, "fake exception");
      mockWebService.Received().Write(expected);
    }

  }
}
