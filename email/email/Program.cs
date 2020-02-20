using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace sendMail
{
    class Program
    {
        static void Main(string[] args)
        {
            var fromAddress = new MailAddress("ambicatummalapalli1998@gmail.com", "from");
            var toAddress = new MailAddress("vishnuavm5@gmail.com", "to");
            const string fromPassword = "tambica98";
            const string subject = "pichi vishnu";
            const string body = "niku hi cheppadam ekkuva peh";

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }
        }
    }
}