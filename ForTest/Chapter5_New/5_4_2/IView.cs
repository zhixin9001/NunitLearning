﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogAn.Chapter5_New._5_4_2
{
  public interface IView
  {
    event Action Loaded;
    event Action<string> ErrorOccured;
    void Render(string text);
  }
}
