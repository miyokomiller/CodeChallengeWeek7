using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Mail;

namespace CodeChallengeWeek7.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return PartialView();
        }
        [HttpGet]
        public ActionResult Contact()
        {
           

            return PartialView( new Models.ContactsFake());
        }
        

        [HttpPost]
        public ActionResult Contact(Models.ContactsFake contactForm)
        {
            try
            {
                contactForm.DateCreated = DateTime.Now.ToString();
                

                Models.ContactsFakeEntities db = new Models.ContactsFakeEntities();
                db.ContactsFakes.Add(contactForm);
                db.SaveChanges();

            }
            catch (Exception exception)
            {
                

                ViewBag.Error = exception.Message;
                return View("Error");
            }
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(contactForm.Email);
                mail.To.Add("miyokomiller@gmail.com");
                mail.Subject = "contact message form" + contactForm.FirstName;
                mail.Body = string.Format("{0} at {1} says: {2}", contactForm.FirstName, contactForm.Email, contactForm.Comment);

                SmtpClient SetupServer = new SmtpClient("mail.dustinkraft.com");
                SetupServer.Port = 587;
                SetupServer.Credentials = new System.Net.NetworkCredential("postmaster@dustinkraft.com", "techIsFun1");
                SetupServer.Send(mail);
               return PartialView("ThankYou");

        }

        public ActionResult ThankYou()
        {
            return PartialView();
        }

        public ActionResult Work()
        {
            return PartialView();
        }

        public ActionResult Careers()
        {
            return PartialView();
        }

        public ActionResult Who()
        {
            return PartialView();
        }
        public ActionResult What()
        {
            return PartialView();
        }
        public ActionResult Why()
        {
            return PartialView();
        }
        public ActionResult How()
        {
            return PartialView();
        }
        public ActionResult Where()
        {
            return PartialView();
        }
    }
}