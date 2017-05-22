using LogAn.Chapter4._4_6_WebThrow_CallEmail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogAn.Test.Chapter4._4_6_WebThrow_CallEmail
{
  public class FakeEmailService : IEmailService
  {
    public string To { get; set; }
    public string Subject { get; set; }
    public string Body { get; set; }
    public void SendEmail(string to, string subject, string body)
    {
      this.To = to;
      this.Subject = subject;
      this.Body = body;
    }
  }
}
