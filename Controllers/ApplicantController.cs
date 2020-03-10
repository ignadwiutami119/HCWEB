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

        public IActionResult ApplicantList (string status,int _crntpage = 1) {
            if(status == null){
                status = "unproccess";
            }
            var pagesetting = _AppDbContext.ApplicantPagings.Find (1);
            pagesetting.Search = "";
            pagesetting.StatusPage = status;
            pagesetting.CurentPage = _crntpage;
            _AppDbContext.SaveChanges ();
            if (pagesetting.CurentPage == 1) {
                var take = pagesetting.ShowItem;
                var spesific_applicant = from a in _AppDbContext.Applicant where a.Status_Proccess == pagesetting.StatusPage select a;
                var get = from a in spesific_applicant.Take (take) where a.Status_Proccess == pagesetting.StatusPage select a;
                ViewBag.items = get;
                ViewBag.page = pagesetting;
            } else {
                var take = pagesetting.ShowItem;
                var spesific_applicant = from a in _AppDbContext.Applicant where a.Status_Proccess == pagesetting.StatusPage select a;
                var get = from a in spesific_applicant.Skip (take * (pagesetting.CurentPage - 1)).Take (take) select a;
                ViewBag.items = get;
                ViewBag.page = pagesetting;
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
                var obj = new Applicant () {
                Name = get_applicant.Name,
                Email = get_applicant.Email,
                Phone = get_applicant.Phone,
                Gender = get_applicant.Gender,
                BirthDate = get_applicant.BirthDate,
                BirthPlace = get_applicant.BirthPlace,
                Occupation = get_applicant.Occupation,
                Placement = get_applicant.Placement,
                Status_Proccess = "Probation",
                Address = get_applicant.Address,
                EmergencyContact = get_applicant.EmergencyContact
                };
                _AppDbContext.Applicant.Remove (get_applicant);
                _AppDbContext.Applicant.Add (obj);
                _AppDbContext.SaveChanges ();
            }
            return RedirectToAction ("ApplicantList", "Applicant");
        }
        public IActionResult ApplicantDetail (int Id) {
            var show = _AppDbContext.Applicant.Find (Id);
            ViewBag.items = show;
            return View ("ApplicantDetail");
        }
        public IActionResult Reject (int Id) {
            var rmv = _AppDbContext.Applicant.Find (Id);
            _AppDbContext.Applicant.Remove (rmv);
            _AppDbContext.SaveChanges ();
            return RedirectToAction ("ApplicantList", "Applicant");
        }

        public IActionResult Search (string keyword) {
            var paging = _AppDbContext.ApplicantPagings.Find (1);
            paging.Search = keyword;
            _AppDbContext.SaveChanges ();
            var get = from a in _AppDbContext.Applicant where a.Name.Contains (keyword) || a.Address.Contains (keyword) || a.Email.Contains (keyword) || a.Occupation.Contains (keyword) || a.Placement.Contains (keyword) select a;
            ViewBag.items = get;
            var set_page = _AppDbContext.Pagings.Find (1);
            ViewBag.page = set_page;
            return View ("ApplicantList");
        }

        public IActionResult ApplicantUpdate (int Id) {
            var show = _AppDbContext.Applicant.Find (Id);
            ViewBag.items = show;
            return View ("ApplicantUpdate");
        }
      public IActionResult ApplicantUpdateData (int Id, string name, string email, string address, string phone, string occupation, string placement, string emergency, string status, IFormFile image=null) {
            var file="";
            if(image == null){
            var getApplicant = _AppDbContext.Applicant.Find (Id);
            file = getApplicant.Image;
            }
            else if(image != null){
            var path = "wwwroot//image";
            Directory.CreateDirectory(path);
            var Filename = Path.Combine (path, Path.GetFileName (image.FileName));
            image.CopyTo (new FileStream (Filename, FileMode.Create));
            file = Filename.Substring(8).Replace(@"\","/");
            Console.WriteLine(file);
            Console.WriteLine("ini nama file"); }
            var get = _AppDbContext.Applicant.Find (Id);
            get.Image = file;
            get.Name = name;
            get.Email = email;
            get.Address = address;
            get.Phone = phone;
            get.Occupation = occupation;
            get.Placement = placement;
            get.EmergencyContact = emergency;
            _AppDbContext.SaveChanges ();
            ViewBag.items = get;
            return View ("ApplicantDetail");
        }

        public IActionResult ApplicantAddData (string name, string email, string address, string phone, string gender, DateTime birth_date, string birth_place, string occupation, string placement, string emergency, string status, IFormFile image, int addagain = 0) {
            var path = "wwwroot//image";
            Directory.CreateDirectory(path);
            var Filename = Path.Combine (path, Path.GetFileName (image.FileName));
            image.CopyTo (new FileStream (Filename, FileMode.Create));
            var file = Filename.Substring(8).Replace(@"\","/");
            Console.WriteLine(file);
            Console.WriteLine("ini nama file");
            var obj = new Applicant () {
            Image = file,
            Name = name,
            Email = email,
            Address = address,
            Phone = phone,
            BirthDate = birth_date,
            BirthPlace = birth_place,
            Gender = gender,
            Occupation = occupation,
            Placement = placement,
            EmergencyContact = emergency,
            Status_Proccess = "unproccess"
            };
            _AppDbContext.Add (obj);
            _AppDbContext.SaveChanges ();
            if (addagain == 1) {
                return View ("AddApplicant");
            } else if (addagain == 0) {
                return RedirectToAction ("ApplicantList", "Applicant");
            }
            return Ok();
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