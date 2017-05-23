using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogAn.Chapter5_New._5_2_1_FakeValue
{
  public class LogAnalyzer
  {
    private IFileNameRules fileNameRules;
    public LogAnalyzer(IFileNameRules fileNameRules)
    {
      this.fileNameRules = fileNameRules;
    }

    public int MinNameLength { get; set; }

    public bool IsValidFileName(string fileName)
    {
      return fileNameRules.IsValidLogFileName(fileName);
    }
  }
}
