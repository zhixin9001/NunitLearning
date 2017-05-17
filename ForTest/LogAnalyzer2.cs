using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("ABOUT.CH3.Logan.Tests")]
namespace LogAn
{
  public class LogAnalyzer2
  {
    private IWebService webService;
    private IEmailService emailService;
    public LogAnalyzer2(IWebService web, IEmailService emailService)
    {
      this.webService = web;
      this.emailService = emailService;
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
        try
        {
          webService.LogError("Filename too short: " + fileName);
        }
        catch (Exception e)
        {
          emailService.SendEmail("a", "subject", e.Message);
        }

      }
    }
  }

}
