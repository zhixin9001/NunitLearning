using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogAn.Test
{
  [TestFixture]
  public class LogAnalyzerTests
  {
    private LogAnalyzer m_analyzer = null;
    [SetUp]
    public void Setup()
    {
      m_analyzer = new LogAnalyzer();
    }
    [TearDown]
    public void TearDown()
    {
      m_analyzer = null;
    }

    [Test]
    [Category("Simple")]
    public void IsValidLogFileName_ValidFIleLowerCased_ReturnTure()
    {
      bool result = m_analyzer.IsValidLogFileName("whaterer.slf");
      Assert.IsTrue(result);
    }
    [Test]
    [Ignore("ignore")]
    [Category("Complex")]
    public void IsValidLogFileName_EmptyFileName_ThrowException()
    {
      Exception ex = Assert.Throws<ArgumentException>(() => m_analyzer.IsValidLogFileName(string.Empty));
      Assert.AreEqual(ex.Message, "filename has to be provided");
    }
  }
}
