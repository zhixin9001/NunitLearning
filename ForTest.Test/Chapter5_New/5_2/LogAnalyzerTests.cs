using LogAn.Chapter5_New._5_2;
using NSubstitute;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogAn.Test.Chapter5_New._5_2
{
  [TestFixture]
  public class LogAnalyzerTests
  {
    [Test]
    public void Analyze_FileNameTooShort_CallLogger()
    {
      ILogger logger = Substitute.For<ILogger>();
      var analyzer = new LogAnalyzer(logger);
      analyzer.MinNameLength = 6;
      analyzer.Analyze("a.txt");
      logger.Received().LogError("Filename too short:a.txt");
    }
  }
}
