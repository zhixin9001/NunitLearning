using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogAn.Chapter5_New._5_4_3_Trigger
{
  public interface IView
  {
    event Action Loaded;
    void Render(string text);
  }
}
