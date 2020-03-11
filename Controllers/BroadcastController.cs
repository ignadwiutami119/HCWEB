using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using HC_WEB_FINALPROJECT.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.IO;
using Microsoft.AspNetCore.Http;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using MimeKit;

namespace HC_WEB_FINALPROJECT.Controllers
{
    public class BroadcastController : Controller
    {
        private AppDbContext _AppDbContext;
        private readonly ILogger<BroadcastController> _logger;

        public BroadcastController(ILogger<BroadcastController> logger, AppDbContext appDbContext)
        {
            _AppDbContext = appDbContext;
            _logger = logger;
        }


        public IActionResult Add(string title, string body)
        {
            Broadcast broad = new Broadcast()
            {
                title = title,
                date = DateTime.Now,
                body = body,
            };
            _AppDbContext.Broadcasts.Add(broad);
            _AppDbContext.SaveChanges();
            var message = new MimeMessage();
            var get = from a in _AppDbContext.Employee select a;
            foreach (var a in get)
            {
                message.To.Add(new MailboxAddress(a.Name, a.Email));
                message.From.Add(new MailboxAddress("HR","HRAPP@hr.com"));
                message.Subject = title;
                message.Body = new TextPart("plain")
                {
                    Text = body
                };
                using (var emailClient = new MailKit.Net.Smtp.SmtpClient())
                {
                    emailClient.ServerCertificateValidationCallback = (s, c, h, e) => true;
                    emailClient.Connect("smtp.mailtrap.io", 587, false);
                    emailClient.Authenticate("31e443602f2a8a", "187ef92862e63c");
                    emailClient.Send(message);
                    emailClient.Disconnect(true);
                }
            }
            return View("Broadcast");
        }

        public IActionResult Broadcast(){
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}