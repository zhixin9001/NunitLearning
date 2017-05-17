using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("ABOUT.CH3.Logan.Tests")]
namespace LogAn
{
  public class LogAnalyzer
  {
    private IWebService webService;
    public LogAnalyzer(IWebService web)
    {
      this.webService = web;
    }

    public bool WasLastFileNameValid { get; set; }

    public bool IsValidLogFileName(string fileName)
    {
      IExtensionManger mgr = new FileExtensionManager();
      return mgr.IsValid(fileName);
    }

    public void Analyze(string fileName)
    {
      if (fileName.Length < 8)
      {
        webService.LogError("Filename too short: " + fileName);
      }
    }
  }

  public interface IExtensionManger
  {
    bool IsValid(string fileName);
  }
  public class FileExtensionManager : IExtensionManger
  {
    public bool IsValid(String fileName)
    {
      if (string.IsNullOrEmpty(fileName))
      {
        throw new ArgumentException("filename has to be provided");
      }
      if (!fileName.EndsWith(".SLF", StringComparison.CurrentCultureIgnoreCase))
      {
        return false;
      }
      return true;
    }
  }
  public class StubExtensionManager : IExtensionManger
  {
    public bool IsValid(string fileName)
    {
      return true;
    }
  }
}
