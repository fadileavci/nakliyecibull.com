using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Nakliye.BLL
{
   public class MailBLL
    {
        public void MailSender(string body)
        {
            var fromAddress = new MailAddress("nakliyecibul34@gmail.com");
            var toAddress = new MailAddress("nakliyecibul34@gmail.com");
            const string subject = "NakliyeciBul | Sitenizden Gelen İletişim Formu";
            using (var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, "BKGFnakliye.34")
            })
            {
                using (var message = new MailMessage(fromAddress, toAddress) { Subject = subject, Body = body })
                {
                    smtp.Send(message);
                }
            }
        }
    }
}
