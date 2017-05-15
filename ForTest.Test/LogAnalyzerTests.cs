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
    [Test]
    public void Add_1()
    {
      var log = new LogAnalyzer();
      Assert.AreEqual(3, log.Add(1, 1));
    }
  }
}
