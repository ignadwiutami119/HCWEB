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
    public class AttendanceController : Controller {
        private AppDbContext _AppDbContext;
        private readonly ILogger<HomeController> _logger;

        public AttendanceController (ILogger<HomeController> logger, AppDbContext appDbContext) {
            _AppDbContext = appDbContext;
            _logger = logger;
        }

        [Authorize]
        public IActionResult AttendanceList (int Id) {
            var get_Attendance = from u in _AppDbContext.Attendances where u.EmployeeId == Id.ToString () select u;
            ViewBag.Attendance = get_Attendance;
            var get_employee = _AppDbContext.Employee.Find (Id);
            ViewBag.employee = get_employee;
            var now = DateTime.Now;
            var get = now.AddDays (-7);
            ViewBag.items = get;
            var leavereq = from a in _AppDbContext.LeaveRequests where a.status == "pending"
            select a;
            var countReq = leavereq.Count ();
            ViewBag.Req = countReq;
            return View ("AttendanceList");
        }

        [Authorize]
        public IActionResult AttendanceHome () {
            var get_employee = from a in _AppDbContext.Employee select a;
            ViewBag.items = get_employee;
            var leavereq = from a in _AppDbContext.LeaveRequests where a.status == "pending"
            select a;
            var countReq = leavereq.Count ();
            ViewBag.Req = countReq;
            return View ("AttendanceHome");
        }

        [Authorize]
        public IActionResult Search (string keyword) {
            var get = from a in _AppDbContext.Employee where (a.Name.Contains (keyword) || a.Phone.Contains (keyword) || a.Address.Contains (keyword) || a.Email.Contains (keyword) || a.Occupation.Contains (keyword) || a.Placement.Contains (keyword)) select a;
            ViewBag.items = get;
            var leavereq = from a in _AppDbContext.LeaveRequests where a.status == "pending"
            select a;
            var countReq = leavereq.Count ();
            ViewBag.Req = countReq;
            return View ("AttendanceHome");
        }

        [Authorize]
        public IActionResult AttendanceThisMonth (int Id) {
            var get_Attendance = from u in _AppDbContext.Attendances where u.EmployeeId == Id.ToString () select u;
            ViewBag.Attendance = get_Attendance;
            var get_employee = _AppDbContext.Employee.Find (Id);
            ViewBag.Employee = get_employee;
            var leavereq = from a in _AppDbContext.LeaveRequests where a.status == "pending"
            select a;
            var countReq = leavereq.Count ();
            ViewBag.Req = countReq;
            return View ();
        }

        [Authorize]
        public IActionResult Create_ClockIn (int Id, string Remark) {
            var employee = _AppDbContext.Employee.Find (Id);
            var clckin = DateTime.Now;
            var spesific_clockin = from a in _AppDbContext.Attendances where ((a.ClockIn.Day == clckin.Day && a.ClockIn.Month == clckin.Month && a.ClockIn.Year == clckin.Year) && (a.EmployeeId == (employee.Id).ToString ())) select a;
            if (!spesific_clockin.Any ()) {
                var obj = new Attendance () {
                    ClockIn = DateTime.Now,
                    Remarks_in = Remark,
                    EmployeeId = Id.ToString (),
                    status = "In"
                };
                _AppDbContext.Attendances.Add (obj);
                _AppDbContext.SaveChanges ();
            }
            var leavereq = from a in _AppDbContext.LeaveRequests where a.status == "pending"
            select a;
            var countReq = leavereq.Count ();
            ViewBag.Req = countReq;
            return (RedirectToAction("AttendanceList", new { Id = Id }));
        }

        [Authorize]
        public IActionResult Create_ClockOut (int Id, string Remark) {
            var employee = _AppDbContext.Employee.Find (Id);
            var clckout = DateTime.Now;
            var dt = new DateTime(2020, 1, 1, 17, 00, 00);
            if(clckout.TimeOfDay < dt.TimeOfDay){
                Console.WriteLine("kuramg dari");
            }
            Console.WriteLine(clckout.TimeOfDay);
            Console.WriteLine("ini clockout");
            var spesific_clockin = from a in _AppDbContext.Attendances where ((a.ClockIn.Day == clckout.Day && a.ClockIn.Month == clckout.Month && a.ClockIn.Year == clckout.Year) && (a.EmployeeId == (employee.Id).ToString ())) select a;
            if (spesific_clockin.Any ()) {
                var obj = spesific_clockin.First ();
                obj.ClockOut = clckout;
                obj.Remarks_out = Remark;
                obj.status = "Success";
                _AppDbContext.SaveChanges ();
            }
            var leavereq = from a in _AppDbContext.LeaveRequests where a.status == "pending"
            select a;
            var countReq = leavereq.Count ();
            ViewBag.Req = countReq;
            return (RedirectToAction("AttendanceList", new { Id = Id }));

        }

        [Authorize]
        public IActionResult ClockIn (int Id) {
            var get = _AppDbContext.Employee.Find (Id);
            ViewBag.Employee = get;
            var leavereq = from a in _AppDbContext.LeaveRequests where a.status == "pending"
            select a;
            var countReq = leavereq.Count ();
            ViewBag.Req = countReq;
            return View ();
        }

        [Authorize]
        public IActionResult ClockOut (int Id) {
            var get = _AppDbContext.Employee.Find (Id);
            ViewBag.Employee = get;
            var leavereq = from a in _AppDbContext.LeaveRequests where a.status == "pending" select a;
            var countReq = leavereq.Count();
            ViewBag.Req = countReq;
            return View ();
        }

        [Authorize]
        public IActionResult Privacy () {
            var leavereq = from a in _AppDbContext.LeaveRequests where a.status == "pending"
            select a;
            var countReq = leavereq.Count ();
            ViewBag.Req = countReq;
            return View ();
        }

        [ResponseCache (Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error () {
            return View (new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}