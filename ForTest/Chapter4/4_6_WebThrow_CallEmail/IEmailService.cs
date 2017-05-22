using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogAn.Chapter4._4_6_WebThrow_CallEmail
{
  public interface IEmailService
  {
    void SendEmail(string to, string subject, string body);
  }
}
