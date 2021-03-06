﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogAn.Chapter3._3_4_6_1_Factory;

namespace LogAn.Test.Chapter3._3_4_6_1_Factory
{
  class FakeExtensionManager : IExtensionManager
  {
    public bool WillBeValid = false;
    public Exception WillThrow = null;

    public bool IsValid(string fileName)
    {
      if (WillThrow != null)
      { throw WillThrow; }
      return WillBeValid;
    }
  }
}
