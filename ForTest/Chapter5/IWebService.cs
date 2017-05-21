using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogAn.Chapter5
{
  public interface IWebService
  {
    void Write(string message);
    void Write(ErrorInfo message);
  }
}
