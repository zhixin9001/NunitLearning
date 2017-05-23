using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogAn.Chapter5_New._5_4_3_Trigger
{
  public class Presenter
  {
    private readonly IView _view;

    public Presenter(IView view)
    {
      _view = view;
      this._view.Loaded += OnLoad;
    }

    private void OnLoad()
    {
      _view.Render("Hello World");
    }
  }
}
