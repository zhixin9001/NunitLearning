using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogAn.Chapter3._3_4_6_2_Virtual;

namespace LogAn.Test.Chapter3._3_4_6_2_Virtual
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
