using LogAn.Chapter5_New._5_2_1_FakeValue;
using NSubstitute;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogAn.Test.Chapter5_New._5_2_1_FakeValue
{
  [TestFixture]
  public class LogAnalyzerTests
  {
    [Test]
    public void Analyze_FileNameTooShort_CallLogger()
    {
      IFileNameRules rule = Substitute.For<IFileNameRules>();
      rule.IsValidLogFileName("a.txt").Returns(true);
      var analyzer = new LogAnalyzer(rule);
      Assert.IsTrue(analyzer.IsValidFileName("a.txt"));
    }
    [Test]
    public void Analyze_FileNameTooShort_CallLogger_ArgMatch()
    {
      IFileNameRules rule = Substitute.For<IFileNameRules>();
      rule.IsValidLogFileName(Arg.Any<string>()).Returns(true);
      var analyzer = new LogAnalyzer(rule);
      Assert.IsTrue(analyzer.IsValidFileName("a1.txt"));
    }
    [Test]
    public void Analyze_FileNameTooShort_CallLogger_Exception()
    {
      IFileNameRules rule = Substitute.For<IFileNameRules>();
      rule.When(x => x.IsValidLogFileName(Arg.Any<string>()))
            .Do(t => { throw new Exception("fake exception"); });
      var analyzer = new LogAnalyzer(rule);
      Assert.Throws<Exception>(() => { analyzer.IsValidFileName("a"); });
    }
  }
}
