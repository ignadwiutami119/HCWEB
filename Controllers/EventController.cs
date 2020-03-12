using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HC_WEB_FINALPROJECT.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MimeKit;

namespace HC_WEB_FINALPROJECT.Controllers {
    public class EventController : Controller {
        private AppDbContext _AppDbContext;
        private readonly ILogger<EventController> _logger;

        public EventController (ILogger<EventController> logger, AppDbContext appDbContext) {
            _AppDbContext = appDbContext;
            _logger = logger;
        }


        [Authorize]
        public IActionResult Event () {
            var Event = from a in _AppDbContext.Events select a;
            ViewBag.Event = Event;
            return View ();
        }
        public IActionResult Remove (int Id) {
            var Event = _AppDbContext.Events.Find(Id);
            _AppDbContext.Remove(Event);
            _AppDbContext.SaveChanges();
            return RedirectToAction ("Event","Event");
        }
        public IActionResult RemoveView (int Id) {
            var Event = _AppDbContext.Events.Find(Id);
            _AppDbContext.Remove(Event);
            _AppDbContext.SaveChanges();
            return RedirectToAction ("Event","Event");
        }

        [ResponseCache (Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error () {
            return View (new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}