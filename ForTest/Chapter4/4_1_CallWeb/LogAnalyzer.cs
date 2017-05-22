using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogAn.Chapter4._4_1_CallWeb
{
  public class LogAnalyzer
  {
    private IWebService service;
    public LogAnalyzer(IWebService service)
    {
      this.service = service;
    }
    public void Analyze(string fileName)
    {
      if (fileName.Length < 8)
      {
        service.LogError("Filename too short:" + fileName);
      }
    }
  }
}
