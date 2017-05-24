using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogAn.Chapter7._7_6_1_1_Abstract_Infrastructure
{
  public class ConfigurationManager
  {
    private bool _configuredResult;

    public bool ConfuguredResult
    {
      get => _configuredResult;
      set => _configuredResult = value;
    }

    public bool IsConfigured(string configName)
    {
      LoggingFacility.Log("checking" + configName);
      return _configuredResult;
    }
  }
}
