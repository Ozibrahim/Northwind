using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Infrastucture.CrossCuttingConcern.Communication
{
    public class MailManager
    {
        public static bool Send(string to,string from,string title,string message)
        {
            MailMessage mailMessage = new MailMessage(from,to);
            mailMessage.Subject = title;
            mailMessage.Body = message;
            mailMessage.IsBodyHtml = true;

            //SMTP gönderme
            //POP alma

            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Credentials = new NetworkCredential("Username", "password");
            smtpClient.Port = 587;
            smtpClient.EnableSsl = false;
            smtpClient.Host = "mail.gmail.com";
            smtpClient.Send(mailMessage);
            return true;
        }
    }
}
