using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SobesWebAPI.Models;

namespace SobesWebAPI.Controllers;

public class ReportController: Controller
{
    
    [HttpPost]
    public IActionResult User_statistics(string id_user)
    {
        //User user = new User(id_user, start, end);
    
        return Json(id_user);
    }
    
    [HttpGet]
    public IActionResult Info(string GUID)
    {
        //Query query = new Query(GUID);

        return Json(GUID);
    }
}