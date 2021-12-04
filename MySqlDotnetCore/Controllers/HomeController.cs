using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
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
