using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogAn.Chapter5_New._5_3_1
{
  public class LogAnalyzer
  {
    private ILogger logger;
    private IWebService webber;

    public LogAnalyzer(ILogger logger, IWebService webber)
    {
      this.logger = logger;
      this.webber = webber;
    }

    public void Analyze(string filename)
    {
      try
      {
        if (filename.Length < 8)
        {
          logger.LogError("filename too short:" + filename);
        }
      }
      catch (Exception e)
      {
        webber.SendMsg(e.Message);
      }

    }
  }
}
