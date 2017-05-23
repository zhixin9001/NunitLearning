using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogAn.Chapter5_New._5_2_1_FakeValue
{
  public interface IFileNameRules
  {
    bool IsValidLogFileName(string fileName);
  }
}
