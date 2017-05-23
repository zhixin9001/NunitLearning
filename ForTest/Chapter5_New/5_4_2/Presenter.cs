using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogAn.Chapter5_New._5_4_2
{
  public class Presenter
  {
    private readonly IView _view;
    private readonly ILogger _logger;

    public Presenter(IView view,ILogger logger)
    {
      _view = view;
      _logger = logger;
      this._view.Loaded += OnLoad;
      this._view.ErrorOccured += ErrorOccured;
    }

    private void ErrorOccured(string s)
    {
      _logger.LogError(s);
    }

    private void OnLoad()
    {
      _view.Render("Hello World");
    }
  }
}
