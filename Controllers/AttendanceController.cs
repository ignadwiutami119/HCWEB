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

namespace HC_WEB_FINALPROJECT.Controllers
{
    public class AttendanceController : Controller
    {
        private AppDbContext _AppDbContext;
        private readonly ILogger<HomeController> _logger;

        public AttendanceController(ILogger<HomeController> logger, AppDbContext appDbContext)
        {
            _AppDbContext = appDbContext;
            _logger = logger;
        }


        public IActionResult AttendanceList(int Id)
        {
            var get_Attendance = from u in _AppDbContext.Attendances where u.EmployeeId == Id.ToString() select u;
            ViewBag.Attendance = get_Attendance;
            var get_employee = _AppDbContext.Employee.Find(Id);
            ViewBag.employee = get_employee;
            var now = DateTime.Now;
            var get = now.AddDays(-7);
            ViewBag.items = get;
            return View("AttendanceList");
        }

        public IActionResult AttendanceHome()
        {
            var get_employee = from a in _AppDbContext.Employee select a;
            ViewBag.items = get_employee;
            return View("AttendanceHome");
        }
        public IActionResult AttendanceThisMonth(int Id)
        {
            var get_Attendance = from u in _AppDbContext.Attendances where u.EmployeeId == Id.ToString() select u;
            ViewBag.Attendance = get_Attendance;
            var get_employee = _AppDbContext.Employee.Find(Id);
            ViewBag.Employee = get_employee;
            return View();
        }
        public IActionResult Create_ClockIn(int Id, string Remark)
        {
            var employee = _AppDbContext.Employee.Find(Id);
            var clckin = DateTime.Now;
            var spesific_clockin = from a in _AppDbContext.Attendances where ((a.ClockIn.Day == clckin.Day && a.ClockIn.Month == clckin.Month && a.ClockIn.Year == clckin.Year) && (a.EmployeeId == (employee.Id).ToString())) select a;
            if (!spesific_clockin.Any())
            {
                var obj = new Attendance()
                {
                    ClockIn = DateTime.Now,
                    Remarks_in = Remark,
                    EmployeeId = Id.ToString()
                };
                _AppDbContext.Attendances.Add(obj);
                _AppDbContext.SaveChanges();
            }
            return RedirectToAction("AttendanceHome", "Attendance");
        }
        public IActionResult Create_ClockOut(int Id, string Remark)
        {
            var employee = _AppDbContext.Employee.Find(Id);
            var clckout = DateTime.Now;
            var spesific_clockin = from a in _AppDbContext.Attendances where ((a.ClockIn.Day == clckout.Day && a.ClockIn.Month == clckout.Month && a.ClockIn.Year == clckout.Year) && (a.EmployeeId == (employee.Id).ToString())) select a;
            if (spesific_clockin.Any())
            {
                var obj = spesific_clockin.First();
                obj.ClockOut = clckout;
                obj.Remarks_out = Remark;
                obj.status = "success";
                _AppDbContext.SaveChanges();
            }
            return RedirectToAction("AttendanceHome", "Attendance");
        }

        public IActionResult ClockIn(int Id)
        {
            var get = _AppDbContext.Employee.Find(Id);
            ViewBag.Employee = get;
            return View();
        }
        public IActionResult ClockOut(int Id)
        {
            var get = _AppDbContext.Employee.Find(Id);
            ViewBag.Employee = get;
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}