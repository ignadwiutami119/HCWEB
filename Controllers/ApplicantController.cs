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

namespace HC_WEB_FINALPROJECT.Controllers {
    public class ApplicantController : Controller {
        private AppDbContext _AppDbContext;
        private readonly ILogger<HomeController> _logger;

        public ApplicantController (ILogger<HomeController> logger, AppDbContext appDbContext) {
            _AppDbContext = appDbContext;
            _logger = logger;
        }

        [Authorize]
        public IActionResult ApplicantList (string status, int _crntpage = 1) {
            if (status == null) {
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
            var leavereq = from a in _AppDbContext.LeaveRequests where a.status == "pending"
            select a;
            var countReq = leavereq.Count ();
            ViewBag.Req = countReq;
            return View ("ApplicantList");
        }

        [Authorize]
        public IActionResult NextProccess (int Id) {
            var get_applicant = _AppDbContext.Applicant.Find (Id);
            if (get_applicant.Status_Proccess == "unproccess") {
                get_applicant.Status_Proccess = "psychotest";
                _AppDbContext.SaveChanges ();
            } else if (get_applicant.Status_Proccess == "psychotest") {
                get_applicant.Status_Proccess = "interview";
                _AppDbContext.SaveChanges ();
            } else if (get_applicant.Status_Proccess == "interview") {
                var obj = new Employee () {
                Name = get_applicant.Name,
                Email = get_applicant.Email,
                Phone = get_applicant.Phone,
                Gender = get_applicant.Gender,
                BirthDate = get_applicant.BirthDate,
                BirthPlace = get_applicant.BirthPlace,
                Occupation = get_applicant.Occupation,
                Placement = get_applicant.Placement,
                Status = "probation",
                Address = get_applicant.Address,
                EmergencyContact = get_applicant.EmergencyContact
                };
                _AppDbContext.Applicant.Remove (get_applicant);
                _AppDbContext.Employee.Add (obj);
                _AppDbContext.SaveChanges ();
            }
            var leavereq = from a in _AppDbContext.LeaveRequests where a.status == "pending"
            select a;
            var countReq = leavereq.Count ();
            ViewBag.Req = countReq;
            return RedirectToAction ("ApplicantList", "Applicant");
        }

        [Authorize]
        public IActionResult ApplicantDetail (int Id) {
            var show = _AppDbContext.Applicant.Find (Id);
            ViewBag.items = show;
            var leavereq = from a in _AppDbContext.LeaveRequests where a.status == "pending"
            select a;
            var countReq = leavereq.Count ();
            ViewBag.Req = countReq;
            return View ("ApplicantDetail");
        }

        [Authorize]
        public IActionResult Reject (int Id) {
            var rmv = _AppDbContext.Applicant.Find (Id);
            _AppDbContext.Applicant.Remove (rmv);
            _AppDbContext.SaveChanges ();
            var leavereq = from a in _AppDbContext.LeaveRequests where a.status == "pending"
            select a;
            var countReq = leavereq.Count ();
            ViewBag.Req = countReq;
            return RedirectToAction ("ApplicantList", "Applicant");
        }

        [Authorize]
        public IActionResult Search (string keyword) {
            var paging = _AppDbContext.ApplicantPagings.Find (1);
            paging.Search = keyword;
            _AppDbContext.SaveChanges ();
            var get = from a in _AppDbContext.Applicant where (a.Status_Proccess == paging.StatusPage) && (a.Name.Contains (keyword) || a.Phone.Contains (keyword) || a.Address.Contains (keyword) || a.Email.Contains (keyword) || a.Occupation.Contains (keyword) || a.Placement.Contains (keyword)) select a;
            ViewBag.items = get;
            var set_page = _AppDbContext.ApplicantPagings.Find (1);
            ViewBag.page = set_page;
            var leavereq = from a in _AppDbContext.LeaveRequests where a.status == "pending"
            select a;
            var countReq = leavereq.Count ();
            ViewBag.Req = countReq;
            return View ("ApplicantList");
        }

        [Authorize]
        public IActionResult AddApplicant (int Id) {
            var leavereq = from a in _AppDbContext.LeaveRequests where a.status == "pending"
            select a;
            var countReq = leavereq.Count ();
            ViewBag.Req = countReq;
            return View ();
        }

        [Authorize]
        public IActionResult ApplicantUpdate (int Id) {
            var show = _AppDbContext.Applicant.Find (Id);
            ViewBag.items = show;
            var leavereq = from a in _AppDbContext.LeaveRequests where a.status == "pending"
            select a;
            var countReq = leavereq.Count ();
            ViewBag.Req = countReq;
            return View ("ApplicantUpdate");
        }

        [Authorize]
        public IActionResult ApplicantUpdateData (int Id, string name, string email, string address, string phone, string occupation, string placement, string emergency, string status, IFormFile image = null, IFormFile cv = null) {
            var file = "";
            var cvfile = "";
            if (cv != null) {
                Console.WriteLine ("MAsuk sinin ga");
            }
            if (image == null && cv == null) {
                var getApplicant = _AppDbContext.Applicant.Find (Id);
                file = getApplicant.Image;
                cvfile = getApplicant.CV;
            } else if (image != null && cv != null) {
                var path = "wwwroot//image";
                var pathCV = "wwwroot//cv";
                Directory.CreateDirectory (pathCV);
                Directory.CreateDirectory (path);
                var CVname = Path.Combine (pathCV, Path.GetFileName (cv.FileName));
                cv.CopyTo (new FileStream (CVname, FileMode.Create));
                cvfile = CVname.Substring (8).Replace (@"\", "/");

                var Filename = Path.Combine (path, Path.GetFileName (image.FileName));
                image.CopyTo (new FileStream (Filename, FileMode.Create));
                file = Filename.Substring (8).Replace (@"\", "/");
            } else if (image != null && cv == null) {
                var getApplicant = _AppDbContext.Applicant.Find (Id);
                cvfile = getApplicant.CV;

                var path = "wwwroot//image";
                Directory.CreateDirectory (path);
                var Filename = Path.Combine (path, Path.GetFileName (image.FileName));
                image.CopyTo (new FileStream (Filename, FileMode.Create));
                file = Filename.Substring (8).Replace (@"\", "/");
            } else {
                var getApplicant = _AppDbContext.Applicant.Find (Id);
                file = getApplicant.Image;

                var path = "wwwroot//cv";
                Directory.CreateDirectory (path);
                var Filename = Path.Combine (path, Path.GetFileName (cv.FileName));
                image.CopyTo (new FileStream (Filename, FileMode.Create));
                file = Filename.Substring (8).Replace (@"\", "/");
            }

            var get = _AppDbContext.Applicant.Find (Id);
            get.CV = cvfile;
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
            var leavereq = from a in _AppDbContext.LeaveRequests where a.status == "pending"
            select a;
            var countReq = leavereq.Count ();
            ViewBag.Req = countReq;
            return View ("ApplicantDetail");
        }

        [Authorize]
        public IActionResult ApplicantAddData (string name, string email, string address, string phone, string gender, DateTime birth_date, string birth_place, string occupation, string placement, string emergency, string status, IFormFile image = null, int addagain = 0, IFormFile cv = null) {
            var file = "";
            var cvfile = "";
            if (image == null && cv == null) {
                file = null;
                cvfile = null;
            } else if (image != null && cv != null) {
                var path = "wwwroot//image";
                var pathCV = "wwwroot//cv";
                Directory.CreateDirectory (pathCV);
                Directory.CreateDirectory (path);
                var CVname = Path.Combine (pathCV, Path.GetFileName (cv.FileName));
                cv.CopyTo (new FileStream (CVname, FileMode.Create));
                cvfile = CVname.Substring (8).Replace (@"\", "/");
                var Filename = Path.Combine (path, Path.GetFileName (image.FileName));
                image.CopyTo (new FileStream (Filename, FileMode.Create));
                file = Filename.Substring (8).Replace (@"\", "/");
            } else if (image != null && cv == null) {
                cvfile = null;
                var path = "wwwroot//image";
                Directory.CreateDirectory (path);
                var Filename = Path.Combine (path, Path.GetFileName (image.FileName));
                image.CopyTo (new FileStream (Filename, FileMode.Create));
                file = Filename.Substring (8).Replace (@"\", "/");
            } else {
                file = null;
                var path = "wwwroot//cv";
                Directory.CreateDirectory (path);
                var Filename = Path.Combine (path, Path.GetFileName (cv.FileName));
                image.CopyTo (new FileStream (Filename, FileMode.Create));
                file = Filename.Substring (8).Replace (@"\", "/");
            }
            var obj = new Applicant () {
                CV = cvfile,
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
                var leavereq = from a in _AppDbContext.LeaveRequests where a.status == "pending"
                select a;
                var countReq = leavereq.Count ();
                ViewBag.Req = countReq;
                return View ("AddApplicant");
            } else if (addagain == 0) {
                var leavereq = from a in _AppDbContext.LeaveRequests where a.status == "pending"
                select a;
                var countReq = leavereq.Count ();
                ViewBag.Req = countReq;
                return RedirectToAction ("ApplicantList", "Applicant");
            }
            return Ok ();
        }

        [HttpPost]
        [Authorize]
        public IActionResult Importy ([FromForm (Name = "file")] IFormFile file) {
            string filePath = string.Empty;
            if (file != null) {
                try {
                    string fileExtension = Path.GetExtension (file.FileName);
                    if (fileExtension != ".csv") {
                        ViewBag.Message = "Please select the csv file";
                        return RedirectToAction ("EmployeeList", "Employee");
                    }
                    using (var reader = new StreamReader (file.OpenReadStream ())) {
                        string[] header = reader.ReadLine ().Split (',');
                        while (!reader.EndOfStream) {
                            string[] rows = reader.ReadLine ().Split (',');
                            var obj = new Applicant () {
                                Name = rows[0].ToString (),
                                Email = rows[1].ToString (),
                                Phone = rows[2].ToString (),
                                Gender = rows[3].ToString (),
                                BirthDate = Convert.ToDateTime (rows[4].ToString ()),
                                BirthPlace = rows[5].ToString (),
                                Occupation = rows[6].ToString (),
                                Placement = rows[7].ToString (),
                                Address = rows[8].ToString (),
                                Status_Proccess = rows[9].ToString (),
                                EmergencyContact = rows[10].ToString (),
                                Image = rows[11].ToString (),
                                CV = rows[12].ToString ()
                            };
                            _AppDbContext.Applicant.Add (obj);
                        }
                        _AppDbContext.SaveChanges ();
                    }
                    var leavereq = from a in _AppDbContext.LeaveRequests where a.status == "pending"
                    select a;
                    var countReq = leavereq.Count ();
                    ViewBag.Req = countReq;
                    return RedirectToAction ("ApplicantList", "Applicant");
                } catch (Exception e) {
                    ViewBag.Message = e.Message;
                }
            }
              var leaver = from a in _AppDbContext.LeaveRequests where a.status == "pending" select a;
            var countR = leaver.Count();
            ViewBag.Req = countR;
            return RedirectToAction ("ApplicantList", "Applicant");
        }

        [Authorize]
        public IActionResult ExportAll () {
            var comlumHeadrs = new string[] {
                "Id",
                "Name",
                "Email",
                "Phone",
                "Gender",
                "BirthDate",
                "BirthPlace",
                "Occupation",
                "Placement",
                "Address",
                "Status Proccess",
                "Emergency Contact",
                "Image",
                "CV"
            };
            var items = (from item in _AppDbContext.Applicant select new object[] {
                item.Id,
                    $"{item.Name}",
                    $"{item.Email}",
                    $"{item.Phone}",
                    $"{item.Gender}",
                    $"{item.BirthDate}",
                    $"{item.BirthPlace}",
                    $"{item.Occupation}",
                    $"{item.Placement}",
                    $"{item.Address}",
                    $"{item.Status_Proccess}",
                    $"{item.EmergencyContact}",
                    $"{item.Image}",
                    $"{item.CV}",
            }).ToList ();

            var itemcsv = new StringBuilder ();
            items.ForEach (line => {
                itemcsv.AppendLine (string.Join (",", line));
            });

            byte[] buffer = Encoding.ASCII.GetBytes ($"{string.Join(",", comlumHeadrs)}\r\n{itemcsv.ToString()}");
              var leavereq = from a in _AppDbContext.LeaveRequests where a.status == "pending" select a;
            var countReq = leavereq.Count();
            ViewBag.Req = countReq;
            return File (buffer, "text/csv", $"AllApplicant.csv");
        }

        public IActionResult CSVformat () {
            var comlumHeadrs = new string[] {
                "Name",
                "Email",
                "Phone",
                "Gender",
                "BirthDate",
                "BirthPlace",
                "Occupation",
                "Placement",
                "Address",
                "Status Proccess",
                "Emergency Contact",
                "Image",
                "CV"
            };

            var itemcsv = new StringBuilder ();
            byte[] buffer = Encoding.ASCII.GetBytes ($"{string.Join(",", comlumHeadrs)}\r\n{itemcsv.ToString()}");
            var leavereq = from a in _AppDbContext.LeaveRequests where a.status == "pending" select a;
            var countReq = leavereq.Count();
            ViewBag.Req = countReq;
            return File (buffer, "text/csv", $"ApplicantFormat.csv");
        }

        [Authorize]
        public IActionResult ExportCSV () {
            var paging = _AppDbContext.ApplicantPagings.Find (1);
            var comlumHeadrs = new string[] {
                "Id",
                "Name",
                "Email",
                "Phone",
                "Gender",
                "BirthDate",
                "BirthPlace",
                "Occupation",
                "Departement",
                "Address",
                "Status Proccess",
                "Emergency Contact",
                "Image",
                "CV"
            };
            var items = new List<object[]> ();
            if (paging.Search == null) {
                items = (from item in _AppDbContext.Applicant where item.Status_Proccess == paging.StatusPage select new object[] {
                    item.Id,
                        $"{item.Name}",
                        $"{item.Email}",
                        $"{item.Phone}",
                        $"{item.Gender}",
                        $"{item.BirthDate}",
                        $"{item.BirthPlace}",
                        $"{item.Occupation}",
                        $"{item.Placement}",
                        $"{item.Address}",
                        $"{item.Status_Proccess}",
                        $"{item.EmergencyContact}",
                        $"{item.Image}",
                        $"{item.CV}"
                }).ToList ();
            } else if (paging.Search != null) {
                items = (from item in _AppDbContext.Applicant where item.Status_Proccess == paging.StatusPage && (item.Name.Contains (paging.Search) || item.Email.Contains (paging.Search) || item.Phone.Contains (paging.Search) || item.Occupation.Contains (paging.Search) || item.Address.Contains (paging.Search) || item.Placement.Contains (paging.Search)) select new object[] {
                    item.Id,
                        $"{item.Name}",
                        $"{item.Email}",
                        $"{item.Phone}",
                        $"{item.Gender}",
                        $"{item.BirthDate}",
                        $"{item.BirthPlace}",
                        $"{item.Occupation}",
                        $"{item.Placement}",
                        $"{item.Address}",
                        $"{item.Status_Proccess}",
                        $"{item.EmergencyContact}"
                }).ToList ();
            }

            var itemcsv = new StringBuilder ();
            items.ForEach (line => {
                itemcsv.AppendLine (string.Join (",", line));
            });

            byte[] buffer = Encoding.ASCII.GetBytes ($"{string.Join(",", comlumHeadrs)}\r\n{itemcsv.ToString()}");
            var leavereq = from a in _AppDbContext.LeaveRequests where a.status == "pending" select a;
            var countReq = leavereq.Count();
            ViewBag.Req = countReq;
            return File (buffer, "text/csv", $"Applicant.csv");
            // return RedirectToAction("ListEmployees","Employees");
        }

        [Authorize]
        public IActionResult Privacy () {
            var leavereq = from a in _AppDbContext.LeaveRequests where a.status == "pending" select a;
            var countReq = leavereq.Count();
            ViewBag.Req = countReq;
            return View ();
        }

        [ResponseCache (Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error () {
            return View (new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}