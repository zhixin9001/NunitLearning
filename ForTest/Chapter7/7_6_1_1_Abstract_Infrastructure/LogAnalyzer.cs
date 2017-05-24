using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogAn.Chapter7._7_6_1_1_Abstract_Infrastructure
{
  public class LogAnalyzer
  {
    public void Analyze(string fileName)
    {
      if (fileName.Length < 8)
      {
        LoggingFacility.Log("File name too short:" + fileName);
      }
      //LoggingFacility.LogK
    }
  }
}
