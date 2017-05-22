using LogAn.Chapter3._3_4_5_Property_Injection;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogAn.Test.Chapter3._3_4_5_Property_Injection
{
  [TestFixture]
  class LogAnalyzerTests
  {
    [Test]
    public void IsValidFileName_NameSupportedExtension_RetuensTrue()
    {
      FakeExtensionManager fake = new FakeExtensionManager { WillBeValid = true };

      LogAnalyzer logAnalyzer = new LogAnalyzer() { ExtensionManager=fake};
      bool isValid = logAnalyzer.IsValidLogFileName("a.txt");
      Assert.IsTrue(isValid);
    }
  }
}
