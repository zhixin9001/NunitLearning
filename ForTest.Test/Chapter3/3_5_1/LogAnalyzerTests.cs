using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogAn.Chapter3._3_5_1;
namespace LogAn.Test.Chapter3._3_5_1
{
  [TestFixture]
  public class LogAnalyzerTests
  {
    [Test]
    public void OverRideTest()
    {
      LogAnalyzer log = new LogAnalyzer();
      log.IsSupported = true;

      bool result = log.IsValidLogFileName("a.txt");

      Assert.True(result);
    }
  }
}
