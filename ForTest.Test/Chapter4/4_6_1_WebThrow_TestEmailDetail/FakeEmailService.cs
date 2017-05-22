using LogAn.Chapter4._4_6_1_WebThrow_TestEmailDetail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogAn.Test.Chapter4._4_6_1_WebThrow_TestEmailDetail
{
  public class FakeEmailService : IEmailService
  {
    public EmailInfo emailInfo { get; set; }
    public void SendEmail(EmailInfo emailInfo)
    {
      this.emailInfo = emailInfo;
    }
  }
}
