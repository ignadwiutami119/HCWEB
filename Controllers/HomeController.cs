using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using HC_WEB_FINALPROJECT.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;

namespace HC_WEB_FINALPROJECT.Controllers {
    public class HomeController : Controller {

        public IConfiguration Configuration;
        private AppDbContext _AppDbContext;
        private readonly ILogger<HomeController> _logger;

        public HomeController (ILogger<HomeController> logger, AppDbContext appDbContext, IConfiguration configuration) {
            _AppDbContext = appDbContext;
            _logger = logger;
            Configuration = configuration;
        }

        public IActionResult Index () {
            return View ();
        }

        public IActionResult Login (string Email, string Password) {
            IActionResult response = Unauthorized ();

            var user = AuthenticatedUser (Email, Password);
            if (user != null) {
                var token = GenerateJwtToken (user);
                HttpContext.Session.SetString ("JWTToken", token);
                var get = HttpContext.Session.GetString ("JWTToken");
                var cek = from x in _AppDbContext.Account select x;
                foreach (var item in cek) {
                    if (item.Email == Email && item.Password == Password) {
                        HttpContext.Response.Cookies.Append ("email", Email);
                        return View ("Dashboard");
                    }
                }
            }
            return View ("Index");
        }

        public IActionResult Logout () {
            HttpContext.Session.Remove ("JWTToken");
            return RedirectToAction ("Index", "Home");
        }

        private string GenerateJwtToken (Account user) {
            var secuityKey = new SymmetricSecurityKey (Encoding.UTF8.GetBytes (Configuration["Jwt:Key"]));
            var credentials = new SigningCredentials (secuityKey, SecurityAlgorithms.HmacSha256);

            var claims = new [] {
                new Claim (JwtRegisteredClaimNames.Sub, Convert.ToString (user.Email)),
                new Claim (JwtRegisteredClaimNames.Jti, Guid.NewGuid ().ToString ())
            };

            var token = new JwtSecurityToken (
                issuer: Configuration["Jwt:Issuer"],
                audience : Configuration["Jwt:Audience"],
                claims,
                expires : DateTime.Now.AddHours (2),
                signingCredentials : credentials);
            var encodedToken = new JwtSecurityTokenHandler ().WriteToken (token);
            return encodedToken;
        }

        private Account AuthenticatedUser (string Email, string Password) {
            Account user = null;
            var get = from i in _AppDbContext.Account select i;
            foreach (var i in get) {
                if (i.Email == Email && i.Password == Password) {
                    user = new Account {
                    Email = Email,
                    Password = Password,
                    };
                }
            }
            return user;
        }

        public IActionResult Dashboard () {
            return View ();
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