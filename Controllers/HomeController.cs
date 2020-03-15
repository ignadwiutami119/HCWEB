using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using HC_WEB_FINALPROJECT.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;

namespace HC_WEB_FINALPROJECT.Controllers
{
    public class HomeController : Controller
    {

        public IConfiguration Configuration;
        private AppDbContext _AppDbContext;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, AppDbContext appDbContext, IConfiguration configuration)
        {
            _AppDbContext = appDbContext;
            _logger = logger;
            Configuration = configuration;
        }

        public IActionResult Search(string keyword)
        {
            var paging = _AppDbContext.AttendancesPagings.Find(1);
            paging.Search = keyword;
            _AppDbContext.SaveChanges();
            if (paging.StatusPage == "Employee")
            {
                var get = from a in _AppDbContext.Employee where (a.Name.Contains(keyword) || a.Phone.Contains(keyword) || a.Address.Contains(keyword) || a.Email.Contains(keyword) || a.Occupation.Contains(keyword) || a.Placement.Contains(keyword)) select a;
                ViewBag.items = get;
                ViewBag.page = paging;
                var leavereq = from a in _AppDbContext.LeaveRequests
                               where a.status == "pending"
                               select a;
                var countReq = leavereq.Count();
                ViewBag.Req = countReq;
                return View("test");
            }
            else
            {
                var today_attendance = from a in _AppDbContext.Attendances where a.ClockIn.Date == DateTime.Now.Date select a.EmployeeId;
                List<int> EmployeeId = new List<int>();
                List<string> EmployeeName = new List<string>();
                foreach (var item in today_attendance)
                {
                    EmployeeId.Add(Convert.ToInt32(item));
                }
                for (int i = 0; i < EmployeeId.Count; i++)
                {
                    var getnama = _AppDbContext.Employee.Find(EmployeeId[i]);
                    EmployeeName.Add(getnama.Name);
                }
                var show = from a in EmployeeName where a.Contains(keyword) select a;
                var set_page = _AppDbContext.AttendancesPagings.Find(1);
                ViewBag.items = show;
                ViewBag.page = set_page;
                var leavereq1 = from a in _AppDbContext.LeaveRequests
                               where a.status == "pending"
                               select a;
                var countReq1 = leavereq1.Count();
                ViewBag.Req = countReq1;
            }
            var leavereq2 = from a in _AppDbContext.LeaveRequests
                           where a.status == "pending"
                           select a;
            var countReq2 = leavereq2.Count();
            ViewBag.Req2 = countReq2;
            return View("test");
        }
        public IActionResult test(string status = "Today", int _crntpage = 1)
        {
            var get_employee = from a in _AppDbContext.Employee select a;
            ViewBag.items = get_employee;
            var set_page = _AppDbContext.AttendancesPagings.Find(1);
            set_page.Search = "";
            set_page.StatusPage = status;
            set_page.CurentPage = _crntpage;
            _AppDbContext.SaveChanges();
            if (set_page.StatusPage == "Today")
            {
                if (set_page.CurentPage == 1)
                {
                    var today_attendance = from a in _AppDbContext.Attendances where a.ClockIn.Date == DateTime.Now.Date select a.EmployeeId;
                    List<int> EmployeeId = new List<int>();
                    List<string> EmployeeName = new List<string>();
                    foreach (var item in today_attendance)
                    {
                        EmployeeId.Add(Convert.ToInt32(item));
                    }
                    for (int i = 0; i < EmployeeId.Count; i++)
                    {
                        var getnama = _AppDbContext.Employee.Find(EmployeeId[i]);
                        EmployeeName.Add(getnama.Name);
                    }
                    var show = EmployeeName.Take(set_page.ShowItem);
                    ViewBag.items = show;
                    ViewBag.page = set_page;
                    var leavereq1 = from a in _AppDbContext.LeaveRequests
                                    where a.status == "pending"
                                    select a;
                    var countReq1 = leavereq1.Count();
                    ViewBag.Req = countReq1;
                    return View("test");
                }
                else
                {
                    var today_attendance = from a in _AppDbContext.Attendances where a.ClockIn.Date == DateTime.Now.Date select a.EmployeeId;
                    List<int> EmployeeId = new List<int>();
                    List<string> EmployeeName = new List<string>();
                    foreach (var item in today_attendance)
                    {
                        EmployeeId.Add(Convert.ToInt32(item));
                    }
                    for (int i = 0; i < EmployeeId.Count; i++)
                    {
                        var getnama = _AppDbContext.Employee.Find(EmployeeId[i]);
                        EmployeeName.Add(getnama.Name);
                    }
                    var take = set_page.ShowItem;
                    var show = EmployeeName.Skip(take * (set_page.CurentPage - 1)).Take(take);
                    ViewBag.items = show;
                    ViewBag.page = set_page;
                    var leavereq2 = from a in _AppDbContext.LeaveRequests
                                    where a.status == "pending"
                                    select a;
                    var countReq2 = leavereq2.Count();
                    ViewBag.Req = countReq2;
                    return View("test");
                }
            }
            else if (set_page.StatusPage == "Employee")
            {
                if (set_page.CurentPage == 1)
                {
                    var take = set_page.ShowItem;
                    var spesific_employee = (from a in _AppDbContext.Employee select a).Take(take);
                    ViewBag.items = spesific_employee;
                    ViewBag.page = set_page;
                    var leavereq3 = from a in _AppDbContext.LeaveRequests
                                    where a.status == "pending"
                                    select a;
                    var countReq3 = leavereq3.Count();
                    ViewBag.Req = countReq3;
                    return View("test");
                }
                else
                {
                    var take = set_page.ShowItem;
                    var spesific_employee = from a in _AppDbContext.Employee select a;
                    var get = from a in spesific_employee.Skip(take * (set_page.CurentPage - 1)).Take(take) select a;
                    ViewBag.items = get;
                    ViewBag.page = set_page;
                    var leavereq4 = from a in _AppDbContext.LeaveRequests
                                    where a.status == "pending"
                                    select a;
                    var countReq4 = leavereq4.Count();
                    ViewBag.Req = countReq4;
                    return View("test");
                }
            }
            var leavereq = from a in _AppDbContext.LeaveRequests
                           where a.status == "pending"
                           select a;
            var countReq = leavereq.Count();
            var set_page_ = _AppDbContext.AttendancesPagings.Find(1);
            ViewBag.page = set_page_;
            ViewBag.Req = countReq;
            return View("test");
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login(string Email, string Password)
        {
            IActionResult response = Unauthorized();

            var user = AuthenticatedUser(Email, Password);
            if (user != null)
            {
                var token = GenerateJwtToken(user);
                HttpContext.Session.SetString("JWTToken", token);
                var get = HttpContext.Session.GetString("JWTToken");
                Console.WriteLine(get);
                Console.WriteLine("ini JWT token");
                var cek = from x in _AppDbContext.Account select x;
                foreach (var item in cek)
                {
                    if (item.Email == Email && item.Password == Password)
                    {
                        HttpContext.Response.Cookies.Append("email", Email);
                        return RedirectToAction("Dashboard", "Home");
                    }
                }
            }
            return View("Index");
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove("JWTToken");
            return RedirectToAction("Index", "Home");
        }

        private string GenerateJwtToken(Account user)
        {
            var secuityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Jwt:Key"]));
            var credentials = new SigningCredentials(secuityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[] {
                new Claim (JwtRegisteredClaimNames.Sub, Convert.ToString (user.Email)),
                new Claim (JwtRegisteredClaimNames.Jti, Guid.NewGuid ().ToString ())
            };

            var token = new JwtSecurityToken(
                issuer: Configuration["Jwt:Issuer"],
                audience: Configuration["Jwt:Audience"],
                claims,
                expires: DateTime.Now.AddHours(2),
                signingCredentials: credentials);
            var encodedToken = new JwtSecurityTokenHandler().WriteToken(token);
            return encodedToken;
        }

        private Account AuthenticatedUser(string Email, string Password)
        {
            Account user = null;
            var get = from i in _AppDbContext.Account select i;
            foreach (var i in get)
            {
                if (i.Email == Email && i.Password == Password)
                {
                    user = new Account
                    {
                        Email = Email,
                        Password = Password,
                    };
                }
            }
            return user;
        }

        // [Authorize]
        public IActionResult Dashboard()
        {
            var now = DateTime.Now;
            var Event = from a in _AppDbContext.Events where a.day.Date.AddDays(-3) == now.Date || a.day.Date.AddDays(-2) == now.Date || a.day.Date.AddDays(-1) == now.Date select a;
            var presence = from a in _AppDbContext.Attendances where a.ClockIn.Day == now.Day && a.ClockIn.Month == now.Month && a.ClockIn.Year == now.Year select a;
            var presenceCount = presence.Count();
            var Employee = from a in _AppDbContext.Employee select a;
            var Female = from a in _AppDbContext.Employee
                         where a.Gender == "female"
                         select a;
            var Male = from a in _AppDbContext.Employee
                       where a.Gender == "male"
                       select a;
            var Applicant = from a in _AppDbContext.Applicant
                            where a.Status_Proccess == "unproccess"
                            select a;
            var ApplicantView = (from a in _AppDbContext.Applicant
                                 where a.Status_Proccess == "unproccess"
                                 select a).Take(4);
            foreach (var a in ApplicantView)
            {
                Console.WriteLine(a.Name);
                Console.WriteLine("inicuy");
            }
            var CountApplicant = Applicant.Count();
            var countFemale = Female.Count();
            var countMale = Male.Count();
            var countEmployee = Employee.Count();
            var Leave = from a in _AppDbContext.LeaveRequests where (a.status == "approve") && (now.Date >= a.Start.Date && now.Date <= a.End.Date) select a;
            var countLeave = Leave.Count();
            Console.WriteLine("CEK ISI");
            Console.WriteLine(countLeave);
            Console.WriteLine(countEmployee);
            ViewBag.Event = Event;
            ViewBag.Leave = countLeave;
            ViewBag.Presence = presenceCount;
            ViewBag.Employee = countEmployee;
            ViewBag.Female = countFemale;
            ViewBag.Male = countMale;
            ViewBag.ApplicantView = ApplicantView;
            ViewBag.ApplicantCount = CountApplicant;
            var leavereq = from a in _AppDbContext.LeaveRequests
                           where a.status == "pending"
                           select a;
            var countReq = leavereq.Count();
            ViewBag.Req = countReq;
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