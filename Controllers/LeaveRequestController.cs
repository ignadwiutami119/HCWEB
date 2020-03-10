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
    public class LeaveRequestController : Controller {
        private AppDbContext _AppDbContext;
        private readonly ILogger<LeaveRequestController> _logger;

        public LeaveRequestController (ILogger<LeaveRequestController> logger, AppDbContext appDbContext) {
            _AppDbContext = appDbContext;
            _logger = logger;
        }

        public IActionResult LeaveRequestList (string status,int _crntpage = 1) {
            if(status == null){
                status = "unproccess";
            }
            var pagesetting = _AppDbContext.LeavePagings.Find (1);
            pagesetting.Search = "";
            pagesetting.StatusPage = status;
            pagesetting.CurentPage = _crntpage;
            _AppDbContext.SaveChanges ();
            if (pagesetting.CurentPage == 1) {
                var take = pagesetting.ShowItem;
                var SpesificLeave = from a in _AppDbContext.LeaveRequests where a.status == pagesetting.StatusPage select a;
                var get = from a in SpesificLeave.Take (take) where a.status == pagesetting.StatusPage select a;
                ViewBag.items = get;
                ViewBag.page = pagesetting;
            } else {
                var take = pagesetting.ShowItem;
                var SpesificLeave = from a in _AppDbContext.LeaveRequests where a.status == pagesetting.StatusPage select a;
                var get = from a in SpesificLeave.Skip (take * (pagesetting.CurentPage - 1)).Take (take) select a;
                ViewBag.items = get;
                ViewBag.page = pagesetting;
            }
            return View ();
        }
        public IActionResult Approve (int Id) {
            var request = _AppDbContext.LeaveRequests.Find (Id);
            request.status = "approve";
            _AppDbContext.SaveChanges ();
            return RedirectToAction ("LeaveRequestList", "LeaveRequest");
        }

        public IActionResult Reject (int Id) {
            var reject = _AppDbContext.LeaveRequests.Find (Id);
            reject.status = "reject";
            _AppDbContext.SaveChanges ();
            return RedirectToAction ("LeaveRequestList", "LeaveRequest");
        }

        public IActionResult ApplicantDetail (int Id) {
            var show = _AppDbContext.Applicant.Find (Id);
            ViewBag.items = show;
            return View ("ApplicantDetail");
        }

        public IActionResult Search (string keyword) {
            var paging = _AppDbContext.LeavePagings.Find (1);
            paging.Search = keyword;
            _AppDbContext.SaveChanges ();
            var get = from a in _AppDbContext.LeaveRequests where a.EmployeeName.Contains (keyword) || a.Remarks.Contains (keyword) || a.EmployeeDepartment.Contains (keyword) || a.EmployeeOccupation.Contains (keyword) || a.EmployeeID.Contains (keyword) select a;
            ViewBag.items = get;
            var set_page = _AppDbContext.LeavePagings.Find (1);
            ViewBag.page = set_page;
            return View ("LeaveRequestList");
        }
        public IActionResult Remove (int Id) {
            var rmv = _AppDbContext.LeaveRequests.Find (Id);
            _AppDbContext.LeaveRequests.Remove (rmv);
            _AppDbContext.SaveChanges ();
            return RedirectToAction ("LeaveRequestList", "LeaveRequest");
        }

        public IActionResult ExportAll () {
            var comlumHeadrs = new string[] {
                "Id",
                "Employee ID",
                "Employee Name",
                "Department",
                "Occupation",
                "Leave Start",
                "Leave End",
                "Remarks",
                "Status"
            };
            var items = (from item in _AppDbContext.LeaveRequests select new object[] {
                item.Id,
                    $"{item.EmployeeID}",
                    $"{item.EmployeeName}",
                    $"{item.EmployeeDepartment}",
                    $"{item.EmployeeOccupation}",
                    $"{item.Start}",
                    $"{item.End}",
                    $"{item.Remarks}",
                    $"{item.status}"
            }).ToList ();

            var itemcsv = new StringBuilder ();
            items.ForEach (line => {
                itemcsv.AppendLine (string.Join (",", line));
            });

            byte[] buffer = Encoding.ASCII.GetBytes ($"{string.Join(",", comlumHeadrs)}\r\n{itemcsv.ToString()}");
            return File (buffer, "text/csv", $"AllLeaveRequest.csv");
        }

        public IActionResult ExportCSV () {
            var paging = _AppDbContext.LeavePagings.Find (1);
            var comlumHeadrs = new string[] {
                "Id",
                "Employee ID",
                "Employee Name",
                "Department",
                "Occupation",
                "Leave Start",
                "Leave End",
                "Remarks",
                "Status"
            };
            var items = new List<object[]> ();
            if (paging.Search == null) {
                items = (from item in _AppDbContext.LeaveRequests where item.status == paging.StatusPage select new object[] {
                    item.Id,
                        $"{item.EmployeeID}",
                        $"{item.EmployeeName}",
                        $"{item.EmployeeDepartment}",
                        $"{item.EmployeeOccupation}",
                        $"{item.Start}",
                        $"{item.End}",
                        $"{item.Remarks}",
                        $"{item.status}"
                }).ToList ();
            } else if (paging.Search != null) {
                items = (from item in _AppDbContext.LeaveRequests where (item.EmployeeName.Contains (paging.Search) || item.EmployeeDepartment.Contains (paging.Search) || item.EmployeeOccupation.Contains (paging.Search) || item.EmployeeID.Contains (paging.Search) || item.Remarks.Contains (paging.Search)) select new object[] {
                    item.Id,
                        $"{item.EmployeeID}",
                        $"{item.EmployeeName}",
                        $"{item.EmployeeDepartment}",
                        $"{item.EmployeeOccupation}",
                        $"{item.Start}",
                        $"{item.End}",
                        $"{item.Remarks}",
                        $"{item.status}"
                }).ToList ();
            }

            var itemcsv = new StringBuilder ();
            items.ForEach (line => {
                itemcsv.AppendLine (string.Join (",", line));
            });

            byte[] buffer = Encoding.ASCII.GetBytes ($"{string.Join(",", comlumHeadrs)}\r\n{itemcsv.ToString()}");
            return File (buffer, "text/csv", $"LeaveRequest.csv");
            // return RedirectToAction("ListEmployees","Employees");
        }

        public IActionResult ApplicantUpdate (int Id) {
            var show = _AppDbContext.Applicant.Find (Id);
            ViewBag.items = show;
            return View ("ApplicantUpdate");
        }
        public IActionResult ApplicantUpdateData (int Id, string name, string email, string address, string phone, string occupation, string placement, string emergency, string status, IFormFile image = null) {
            var file = "";
            if (image == null) {
                var getApplicant = _AppDbContext.Applicant.Find (Id);
                file = getApplicant.Image;
            } else if (image != null) {
                var path = "wwwroot//image";
                Directory.CreateDirectory (path);
                var Filename = Path.Combine (path, Path.GetFileName (image.FileName));
                image.CopyTo (new FileStream (Filename, FileMode.Create));
                file = Filename.Substring (8).Replace (@"\", "/");
                Console.WriteLine (file);
                Console.WriteLine ("ini nama file");
            }
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
            Directory.CreateDirectory (path);
            var Filename = Path.Combine (path, Path.GetFileName (image.FileName));
            image.CopyTo (new FileStream (Filename, FileMode.Create));
            var file = Filename.Substring (8).Replace (@"\", "/");
            Console.WriteLine (file);
            Console.WriteLine ("ini nama file");
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
            return Ok ();
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