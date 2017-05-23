using LogAn.Chapter5_New._5_4_3_Trigger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogAn.Test.Chapter5_New._5_4_3_Trigger
{
  class SomeView : IView
  {
    public event Action Loaded;

    public void Render(string text)
    {
      throw new NotImplementedException();
    }

    public void DoShomething()
    {
      Loaded();
    }
  }
}
