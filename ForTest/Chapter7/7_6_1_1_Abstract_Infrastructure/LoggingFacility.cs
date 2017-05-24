using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogAn.Chapter7._7_6_1_1_Abstract_Infrastructure
{
public  class LoggingFacility
  {
    private static ILogger _logger;
    public static ILogger Logger { get => _logger; set => _logger = value; }

    public static void Log(string text)
    {
      _logger.Log(text);
    }
  }
}
