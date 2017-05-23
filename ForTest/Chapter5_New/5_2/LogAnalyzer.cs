using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogAn.Chapter5_New._5_2
{
  public class LogAnalyzer
  {
    private ILogger _Logger;
    public LogAnalyzer(ILogger logger)
    {
      _Logger = logger;
    }

    public int MinNameLength { get; set; }

    public void Analyze(string fileName)
    {
      if (fileName.Length < MinNameLength)
      {
        _Logger.LogError(string.Format("Filename too short:{0}", fileName));
      }
    }
  }
}
