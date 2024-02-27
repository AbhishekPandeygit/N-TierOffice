using BusinessLayer.Interface;
using DataAccessLayer.Models;
using IdentityBhrDev.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace IdentityBhrDev.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUserBL userBL;


        public HomeController(ILogger<HomeController> logger, IUserBL userBL)
        {
            this.userBL = userBL;
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<User> USERS = this.userBL.GetUsers();

            return View(USERS);
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