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
    public class EmployeeController : Controller
    {
        private AppDbContext _AppDbContext;
        private readonly ILogger<HomeController> _logger;

        public EmployeeController(ILogger<HomeController> logger, AppDbContext appDbContext)
        {
            _AppDbContext = appDbContext;
            _logger = logger;
        }


        // [Authorize]
        public IActionResult EmployeeList(string status_employee, int _crntpage = 1)
        {
            if (status_employee == null)
            {
                status_employee = "permanent";
            }
            var set_page = _AppDbContext.Pagings.Find(1);
            set_page.Search = "";
            set_page.StatusPage = status_employee;
            set_page.CurentPage = _crntpage;
            _AppDbContext.SaveChanges();
            if (set_page.CurentPage == 1)
            {
                var take = set_page.ShowItem;
                var spesific_employee = from a in _AppDbContext.Employee where a.Status == set_page.StatusPage select a;
                var get = from a in spesific_employee.Take(take) where a.Status == set_page.StatusPage select a;
                ViewBag.items = get;
                ViewBag.page = set_page;
            }
            else
            {
                var take = set_page.ShowItem;
                var spesific_employee = from a in _AppDbContext.Employee where a.Status == set_page.StatusPage select a;
                var get = from a in spesific_employee.Skip(take * (set_page.CurentPage - 1)).Take(take) select a;
                ViewBag.items = get;
                ViewBag.page = set_page;
            }
            return View("EmployeeList");
        }


        //Search belum dihandling kalo munculnya banyak harus tetep bisa pagination
        // [Authorize]
        public IActionResult Search(string keyword)
        {
            var paging = _AppDbContext.Pagings.Find(1);
            paging.Search = keyword;
            _AppDbContext.SaveChanges();
            var get = from a in _AppDbContext.Employee where (a.Status == paging.StatusPage) && (a.Name.Contains(keyword) || a.Phone.Contains(keyword) || a.Address.Contains(keyword) || a.Email.Contains(keyword) || a.Occupation.Contains(keyword) || a.Placement.Contains(keyword)) select a;
            ViewBag.items = get;
            var set_page = _AppDbContext.Pagings.Find(1);
            ViewBag.page = set_page;
            return View("EmployeeList");
        }

        // [Authorize]
        public IActionResult EmployeeRemove(int Id)
        {
            var rmv = _AppDbContext.Employee.Find(Id);
            _AppDbContext.Remove(rmv);
            _AppDbContext.SaveChanges();
            return RedirectToAction("EmployeeList", "Employee");
        }

        // [Authorize]
        public IActionResult EmployeeDetail(int Id)
        {
            var show = _AppDbContext.Employee.Find(Id);
            ViewBag.items = show;
            return View("EmployeeDetail");
        }
        public IActionResult EmployeeUpdate(int Id)
        {
            var show = _AppDbContext.Employee.Find(Id);
            ViewBag.items = show;
            return View("EmployeeUpdate");
        }

        // [Authorize]
        public IActionResult EmployeeUpdateData(int Id, string name, string email, string address, string phone, string occupation, string placement, string emergency, string status, IFormFile image = null)
        {
            var file = "";
            if (image == null)
            {
                var getemployee = _AppDbContext.Employee.Find(Id);
                file = getemployee.Image;
            }
            else if (image != null)
            {
                var path = "wwwroot//image";
                Directory.CreateDirectory(path);
                var Filename = Path.Combine(path, Path.GetFileName(image.FileName));
                image.CopyTo(new FileStream(Filename, FileMode.Create));
                file = Filename.Substring(8).Replace(@"\", "/");
                Console.WriteLine(file);
                Console.WriteLine("ini nama file");
            }
            var get = _AppDbContext.Employee.Find(Id);
            get.Image = file;
            get.Name = name;
            get.Email = email;
            get.Address = address;
            get.Phone = phone;
            get.Occupation = occupation;
            get.Placement = placement;
            get.EmergencyContact = emergency;
            get.Status = status;
            _AppDbContext.SaveChanges();
            ViewBag.items = get;
            return View("EmployeeDetail");
        }

        // [Authorize]
        public IActionResult EmployeeAddData(string name, string email, string address, string phone, string gender, DateTime birth_date, string birth_place, string occupation, string placement, string emergency, string status, IFormFile image, int addagain = 0)
        {
            var path = "wwwroot//image";
            Directory.CreateDirectory(path);
            var Filename = Path.Combine(path, Path.GetFileName(image.FileName));
            image.CopyTo(new FileStream(Filename, FileMode.Create));
            var file = Filename.Substring(8).Replace(@"\", "/");
            Console.WriteLine(file);
            Console.WriteLine("ini nama file");
            var obj = new Employee()
            {
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
                Status = status
            };
            _AppDbContext.Add(obj);
            _AppDbContext.SaveChanges();
            if (addagain == 1)
            {
                return View("AddEmployee");
            }
            else if (addagain == 0)
            {
                return RedirectToAction("EmployeeList", "Employee");
            }
            return Ok();
        }

        // [Authorize]
        [HttpPost]
        public IActionResult Importy([FromForm(Name = "file")] IFormFile file)
        {
            Console.WriteLine("masuk method sini");
            string filePath = string.Empty;
            if (file != null)
            {
                Console.WriteLine(file.FileName);
                try
                {
                    string fileExtension = Path.GetExtension(file.FileName);
                    if (fileExtension != ".csv")
                    {
                        ViewBag.Message = "Please select the csv file";
                        return RedirectToAction("EmployeeList", "Employee");
                    }
                    using (var reader = new StreamReader(file.OpenReadStream()))
                    {
                        string[] header = reader.ReadLine().Split(',');
                        while (!reader.EndOfStream)
                        {
                            Console.WriteLine("Masuk while");
                            string[] rows = reader.ReadLine().Split(',');
                            var obj = new Employee()
                            {
                                Name = rows[0].ToString(),
                                Email = rows[1].ToString(),
                                Phone = rows[2].ToString(),
                                Gender = rows[3].ToString(),
                                BirthDate = Convert.ToDateTime(rows[4].ToString()),
                                BirthPlace = rows[5].ToString(),
                                Occupation = rows[6].ToString(),
                                Placement = rows[7].ToString(),
                                Address = rows[8].ToString(),
                                Status = rows[9].ToString(),
                                EmergencyContact = rows[10].ToString(),
                                Image = rows[11].ToString()
                            };
                            _AppDbContext.Employee.Add(obj);
                        }
                        _AppDbContext.SaveChanges();
                    }
                    return RedirectToAction("EmployeeList", "Employee");
                }
                catch (Exception e)
                {
                    ViewBag.Message = e.Message;
                }
            }
            return RedirectToAction("EmployeeList", "Employee");
        }


        // [Authorize]
        public IActionResult ExportAll()
        {
            var comlumHeadrs = new string[]
            {
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
                "Status",
                "EmergencyContact",
                "Image"
            };
            var items = (from item in _AppDbContext.Employee
                         select new object[]
                         {
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
                                       $"{item.Status}",
                                       $"{item.EmergencyContact}",
                                       $"{item.Image}"
                         }).ToList();

            var itemcsv = new StringBuilder();
            items.ForEach(line =>
                {
                    itemcsv.AppendLine(string.Join(",", line));
                });

            byte[] buffer = Encoding.ASCII.GetBytes($"{string.Join(",", comlumHeadrs)}\r\n{itemcsv.ToString()}");
            return File(buffer, "text/csv", $"AllEmployees.csv");
        }
        public IActionResult CSVformat()
        {
            var comlumHeadrs = new string[]
            {
                "Name",
                "Email",
                "Phone",
                "Gender",
                "BirthDate",
                "BirthPlace",
                "Occupation",
                "Placement",
                "Address",
                "Status",
                "EmergencyContact",
                "Image"
            };
            var itemcsv = new StringBuilder();
            byte[] buffer = Encoding.ASCII.GetBytes($"{string.Join(",", comlumHeadrs)}\r\n{itemcsv.ToString()}");
            return File(buffer, "text/csv", $"EmployeeFormat.csv");
        }


        // [Authorize]
        public IActionResult ExportCSV()
        {
            var paging = _AppDbContext.Pagings.Find(1);

            var comlumHeadrs = new string[]
            {
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
                "Status",
                "Emergency Contact",
                "Image"
            };
            var items = new List<object[]>();
            if (paging.Search == null)
            {
                items = (from item in _AppDbContext.Employee
                         where item.Status == paging.StatusPage
                         select new object[]
                         {
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
                                       $"{item.Status}",
                                       $"{item.EmergencyContact}",
                                       $"{item.Image}"
                         }).ToList();
            }
            else if (paging.Search != null)
            {
                items = (from item in _AppDbContext.Employee
                         where item.Status == paging.StatusPage && (item.Name.Contains(paging.Search) || item.Email.Contains(paging.Search) || item.Phone.Contains(paging.Search) || item.Occupation.Contains(paging.Search) || item.Address.Contains(paging.Search) || item.Placement.Contains(paging.Search))
                         select new object[]
                         {
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
                                       $"{item.Status}",
                                       $"{item.EmergencyContact}",
                                       $"{item.Image}"
                         }).ToList();
            }

            var itemcsv = new StringBuilder();
            items.ForEach(line =>
                {
                    itemcsv.AppendLine(string.Join(",", line));
                });

            byte[] buffer = Encoding.ASCII.GetBytes($"{string.Join(",", comlumHeadrs)}\r\n{itemcsv.ToString()}");
            return File(buffer, "text/csv", $"Employees.csv");
            // return RedirectToAction("ListEmployees","Employees");
        }

        // [Authorize]
        public IActionResult AddEmployee()
        {
            return View();
        }

        // [Authorize]
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