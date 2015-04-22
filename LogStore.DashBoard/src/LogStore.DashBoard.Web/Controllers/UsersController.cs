using Microsoft.AspNet.Mvc;

namespace LogStore.DashBoard.Web.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}