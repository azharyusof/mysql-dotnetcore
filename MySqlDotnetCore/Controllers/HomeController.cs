using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MySqlDotnetCore.Context;
using MySqlDotnetCore.Models;

namespace MySqlDotnetCore.Controllers
{
    public class HomeController : Controller
    {
        readonly StaffDBContext staffDBContext = new StaffDBContext();

        public IActionResult Index()
        {
            List<StaffInfo> StaffInfoList = staffDBContext.GetStaffInfo().ToList();

            return View(StaffInfoList);
        }
    }
}
