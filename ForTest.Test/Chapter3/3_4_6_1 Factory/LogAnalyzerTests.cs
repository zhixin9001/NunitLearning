using LogAn.Chapter3._3_4_6_1_Factory;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogAn.Test.Chapter3._3_4_6_1_Factory
{
  [TestFixture]
  class LogAnalyzerTests
  {
    [Test]
    public void IsValidFileName_NameSupportedExtension_RetuensTrue()
    {
      FakeExtensionManager fake = new FakeExtensionManager { WillBeValid = true };
      ExtensionManagerFactory.SetManager(fake);
      LogAnalyzer logAnalyzer = new LogAnalyzer();
      bool isValid = logAnalyzer.IsValidLogFileName("a.txt");
      Assert.IsTrue(isValid);
    }
  }
}
