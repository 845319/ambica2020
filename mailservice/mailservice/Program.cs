using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.Configuration;
using System.IO;

namespace email
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter To Address:");
            string to = Console.ReadLine().Trim();

            Console.WriteLine("Enter Subject:");
            string subject = Console.ReadLine().Trim();

            Console.WriteLine("Enter Body:");
            string body = Console.ReadLine().Trim();

            using (MailMessage mm = new MailMessage(ConfigurationManager.AppSettings["FromEmail"], to))
            {
                mm.Subject = subject;
                mm.Body = body;
                mm.IsBodyHtml = false;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = ConfigurationManager.AppSettings["stmp.gmail.com"];
                smtp.EnableSsl = true;
                NetworkCredential NetworkCred = new NetworkCredential(ConfigurationManager.AppSettings["ambicatummalapalli1998@gmail.com"], ConfigurationManager.AppSettings["tambica98"]);
                smtp.UseDefaultCredentials = true;
                smtp.Credentials = NetworkCred;
                smtp.Port = int.Parse(ConfigurationManager.AppSettings[587]);
                Console.WriteLine("Sending Email......");
                smtp.Send(mm);
                Console.WriteLine("Email Sent.");
                System.Threading.Thread.Sleep(3000);
                Environment.Exit(0);
            }
        }
    }
}