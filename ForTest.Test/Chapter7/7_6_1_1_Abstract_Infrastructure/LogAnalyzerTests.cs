using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogAn.Chapter7._7_6_1_1_Abstract_Infrastructure;
namespace LogAn.Test.Chapter7._7_6_1_1_Abstract_Infrastructure
{
  [TestFixture]
  public class LogAnalyzerTests
  {
    [Test]
    public void Analyze_EmptyFile_ThrowsException()
    {
      var logAnalyzer = new LogAnalyzer();
      logAnalyzer.Analyze("myemptyfile.text");
    }
    [TearDown]
    public void TestDown()
    {
      LoggingFacility.Logger = null;
    }
  }
}
