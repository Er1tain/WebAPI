using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SobesWebAPI.Models;

namespace SobesWebAPI.Controllers;

public class ReportController: Controller
{
    
    [HttpPost]
    public IActionResult User_statistics()
    {
        User user = new User("0317871602", 0, 12);
    
        return Json(user);
    }
    
    [HttpGet]
    public IActionResult Info(string GUID)
    {
        Query query = new Query("438h438th4389h", 75);

        return Json(query);
    }
}