using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogAn.Chapter5
{
  public class LogAnalyzer2
  {
    private ILogger _Logger;
    private IWebService _WebService;
    public int MinNameLength { get; set; }

    public LogAnalyzer2(ILogger logger, IWebService webService)
    {
      _Logger = logger;
      _WebService = webService;
    }

    public void Analyze(string fileName)
    {
      if (fileName.Length < MinNameLength)
      {
        try
        {
          _Logger.LogError(string.Format("Filename too short:{0}", fileName));
        }
        catch (Exception e)
        {
          _WebService.Write("Error From Logger:" + e);
        }
      }
    }
  }
}
