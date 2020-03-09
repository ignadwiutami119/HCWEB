using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HC_WEB_FINALPROJECT.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HC_WEB_FINALPROJECT.Controllers {
    public class ApplicantController : Controller {
        private AppDbContext _AppDbContext;
        private readonly ILogger<HomeController> _logger;

        public ApplicantController (ILogger<HomeController> logger, AppDbContext appDbContext) {
            _AppDbContext = appDbContext;
            _logger = logger;
        }

        public IActionResult ApplicantList (int _crntpage = 1, string status = "unproccess") {
            var set_page = _AppDbContext.Pagings.Find (1);
            set_page.Search= "";
            set_page.StatusPage = status;
            set_page.CurentPage = _crntpage;
            _AppDbContext.SaveChanges ();
            if (set_page.CurentPage == 1) {
                var take = set_page.ShowItem;
                var spesific_applicant = from a in _AppDbContext.Applicant where a.Status_Proccess == set_page.StatusPage select a;
                var get = from a in spesific_applicant.Take (take) where a.Status_Proccess == set_page.StatusPage select a;
                ViewBag.items = get;
                ViewBag.page = set_page;
            } else {
                var take = set_page.ShowItem;
                var spesific_applicant = from a in _AppDbContext.Applicant where a.Status_Proccess == set_page.StatusPage select a;
                var get = from a in spesific_applicant.Skip (take * (set_page.CurentPage - 1)).Take (take) select a;
                ViewBag.items = get;
                ViewBag.page = set_page;
            }
            return View ("ApplicantList");
        }
        public IActionResult NextProccess (int Id) {
            var get_applicant = _AppDbContext.Applicant.Find (Id);
            if (get_applicant.Status_Proccess == "unproccess") {
                get_applicant.Status_Proccess = "psychotest";
                _AppDbContext.SaveChanges ();
            } else if (get_applicant.Status_Proccess == "psychotest") {
                get_applicant.Status_Proccess = "interview";
                _AppDbContext.SaveChanges ();

            } else if (get_applicant.Status_Proccess == "interview") {
                get_applicant.Status_Proccess = "accepted";
                _AppDbContext.SaveChanges ();
            }
            var get = from a in _AppDbContext.Applicant select a;
            ViewBag.items = get;
            return View ("ApplicantList");
        }
        public IActionResult Privacy () {
            return View ();
        }

        [ResponseCache (Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error () {
            return View (new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}