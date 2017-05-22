using LogAn.Chapter3._3_4_3_Constructor_Injection;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogAn.Test.Chapter3._3_4_3_Constructor_Injection
{
  [TestFixture]
  class LogAnalyzerTests
  {
    [Test]
    public void IsValidFileName_NameSupportedExtension_RetuensTrue()
    {
      FakeExtensionManager fake = new FakeExtensionManager { WillBeValid = true };
      //fake.WillThrow = new Exception("fake exception");
      LogAnalyzer logAnalyzer = new LogAnalyzer(fake);
      bool isValid = logAnalyzer.IsValidLogFileName("a.txt");
      Assert.IsTrue(isValid);
    }
  }
}
