﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogAn.Chapter4._4_6_1_WebThrow_TestEmailDetail
{
  public class LogAnalyzer
  {
    private IWebService webService;
    private IEmailService emailService;
    public LogAnalyzer(IWebService webService, IEmailService emailService)
    {
      this.webService = webService;
      this.emailService = emailService;
    }
    public void Analyze(string fileName)
    {
      try
      {
        if (fileName.Length < 8)
        {
          webService.LogError("Filename too short:" + fileName);
        }
      }
      catch (Exception e)
      {
        emailService.SendEmail(new EmailInfo
        {
          To = "To",
          Subject = "Subject",
          Body = e.Message
        });
      }

    }
  }
}
