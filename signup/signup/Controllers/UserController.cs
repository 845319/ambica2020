using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using signup.Models;
using System.Net.Mail;
using System.Net;

namespace signup.Controllers
{
    public class UserController : Controller
    {
        // GET: User

        [HttpGet]
        public ActionResult Registration()
        {
            return View();
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Registration([Bind(Exclude = "Ismailverified ,  Activationcode")]User user)
        {
            bool Status = false;
            string message = "";

            if (ModelState.IsValid)
            {

                var isExist = IsEmailExists(user.Email);
                if (isExist)
                {
                    ModelState.AddModelError("Email Exists", "Email already exists");
                    return View(user);
                }

                user.Activationcode = Guid.NewGuid();


                user.Password = Crypto.Hash(user.Password);
                user.ConfirmPassword = Crypto.Hash(user.ConfirmPassword);


                user.Ismailverified = false;

                using (SigninEntities sc = new SigninEntities())
                {
                    sc.Users.Add(user);
                    sc.SaveChanges();


                    Sendverificationmail(user.Email, user.Activationcode.ToString());

                    message = "Registration successfully done.Account activation link has been sent to ur emailid:"+user.Email;
                    Status = true;
                }


            }
            else
            {
                message = "Invalid req";
            }
            ViewBag.Message = message;
            ViewBag.Status = Status;
            return View(user);
        }



        [NonAction]
        public bool IsEmailExists(string emailId)
        {
            using (SigninEntities sc = new SigninEntities())
            {
                var v = sc.Users.Where(a => a.Email == emailId).FirstOrDefault();
                return v != null;
            }

        }
        [NonAction]
        public void Sendverificationmail(string emailId, string activationcode)
        {
            var verifyurl = "/User/VerifyAccount/" + activationcode;
            var link = Request.Url.AbsoluteUri.Replace(Request.Url.PathAndQuery, verifyurl);
            var fromEmail = new MailAddress("ambicatummalapalli1998@gmail.com", "Ambica Tummalapalli");
            var tomail = new MailAddress(emailId);
            var fromEmailPassword = "tambica98";
            string subject = "Your account is successfully created";

            
           string body = "<br/><br/> We are excited to tell u that your account has been created. Please click on the below link to verify your account"+"<br/><br/><a href='"+link+"'>"+link+"</a>";
            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromEmail.Address , fromEmailPassword)
            };
            using (var message = new MailMessage(fromEmail, tomail)
            {
                Subject = subject,
                Body = body,
                IsBodyHtml = true

            })
                smtp.Send(message);
        }


    }

}