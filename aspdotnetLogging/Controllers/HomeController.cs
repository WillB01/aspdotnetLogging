using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspdotnetLogging.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace aspdotnetLogging.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUser _users;

        public HomeController(ILogger<HomeController> logger, IUser users)
        {
            _logger = logger;
            _users = users;
        }
        public IActionResult Index()
        {
            try
            {
                var user = _users.Users.FirstOrDefault(u => u.Id == 5);
                if (user == null)
                {
                    _logger.LogInformation($"User with id {5} wasn't found");
                }
                return View();
            }
            catch (Exception ex)
            {
                _logger.LogCritical($"Exception while getting users with id {5}.",ex);
                return StatusCode(500, "A problem happened while handling your request.");
            }
           
        }
    }
}