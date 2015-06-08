using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MessagingBoard.Models;
using MessagingBoard.Services;
using MessagingBoard.Data;

namespace MessagingBoard.Controllers
{
    public class HomeController : Controller
    {
        private IMailService _mail;
        private IMessagingBoardRepository _repo;

        public HomeController(IMailService mail, IMessagingBoardRepository repo)
        {
            _repo = repo;
            _mail = mail;
        }

        public ActionResult Index()
        {
            var Topiks = _repo.GetTopiks()
                .OrderByDescending(m => m.Created)
                .Take(25)
                .ToList();
            
            return View(Topiks);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            var Replys = _repo.GetReplysByTopic(1)
                .OrderByDescending(m => m.Created)
                .Take(25)
                .ToList();

            return View(Replys);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult Contact(ContactModel model)
        {
            var msg = string.Format("Comment From: {1}{2}{0}Email:{3}{0}Comment:{4}",
                Environment.NewLine,
                model.FirstName,
                model.LastName,
                model.Email,
                model.Comments);
    

            if(_mail.SendMail("noreply@yourdomain.com", 
                "foo@yourdomain.com", 
                "Website Contact",
                msg))
            {
                ViewBag.MailSent = true;
            }
            return View();
        }
        [Authorize]
        public ActionResult MyMessages()
        {
            return View();
        }
        [Authorize(Users = "jplou001@fiu.edu")]
        public ActionResult Moderation()
        {
            return View();
        }
    }
}