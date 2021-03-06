﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogAn.Chapter3._3_4_6_2_Virtual;
namespace LogAn.Test.Chapter3._3_4_6_2_Virtual
{
  [TestFixture]
 public class LogAnalyzerTests
  {
    [Test]
    public void OverRideTest()
    {
      FakeExtensionManager stub = new FakeExtensionManager();
      stub.WillBeValid = true;

      LogAnalyzer log = new LogAnalyzer(stub);

      bool result = log.IsValidLogFileName("a.txt");

      Assert.True(result);
    }
  }
}
