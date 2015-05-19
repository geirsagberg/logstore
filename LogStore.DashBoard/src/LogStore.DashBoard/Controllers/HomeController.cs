using LogStore.DashBoard.Models;
using LogStore.DashBoard.Services;
using Microsoft.AspNet.Mvc;
using System.Collections.Generic;

namespace LogStore.DashBoard.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogService logService;

        public HomeController(ILogService logService)
        {
            this.logService = logService;
        }

        public IActionResult Index()
        {
            var logs = logService.GetLogs();

            var viewModel = new DashBoardViewModel(logs);

            return View(viewModel);
        }

        public IActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View("~/Views/Shared/Error.cshtml");
        }
    }
}