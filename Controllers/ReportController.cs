using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SobesWebAPI.Models;

namespace SobesWebAPI.Controllers;

public class ReportController: Controller
{
    
    // [HttpPost]
    // public IActionResult User_statistics()
    // {
    //     User query = new User("Alex", 37, 1);
    //
    //     return Json(query);
    // }
    
    [HttpGet]
    public IActionResult Info(string GUID)
    {
        Query query = new Query("438h438th4389h", 75);

        return Json(query);
    }
}