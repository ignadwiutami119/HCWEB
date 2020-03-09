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


        public IActionResult AttendanceList()
        {
            var now = DateTime.Now;
            var get = now.AddDays(-7);
            ViewBag.items = get;
            return View("AttendanceList");
        }
        public IActionResult Create_ClockIn(string EmployeeID, string Remark)
        {
            var employees = from a in _AppDbContext.Employee where a.EmployeeID == EmployeeID select a;
            var employee = employees.First();
            var obj = new Attendance()
            {
                ClockIn = DateTime.Now,
                Remarks_in = Remark,
                EmployeeId = (employee.Id).ToString()
            };
            _AppDbContext.Attendances.Add(obj);
            _AppDbContext.SaveChanges();
            return RedirectToAction("AttendanceList", "Attendance");
        }
        public IActionResult Create_ClockOut(string EmployeeID, string Remark)
        {
            var employee_list = from a in _AppDbContext.Employee where a.EmployeeID == EmployeeID select a;
            var employee = employee_list.First();
            var clckout = DateTime.Now;
            var spesific_clockin = from a in _AppDbContext.Attendances where ((a.ClockIn.Day == clckout.Day  && a.ClockIn.Month == clckout.Month && a.ClockIn.Year == clckout.Year) && (a.EmployeeId == (employee.Id).ToString())) select a;
            if (spesific_clockin.Any())
            {
                var obj = spesific_clockin.First();
                obj.ClockOut = clckout;
                obj.Remarks_out = Remark;
                obj.status = "success";
                _AppDbContext.SaveChanges();
            }
            return RedirectToAction("AttendanceList", "Attendance");
        }

        public IActionResult ClockIn()
        {
            return View();
        }
        public IActionResult ClockOut()
        {
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