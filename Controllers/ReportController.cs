using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SobesWebAPI.Models;

namespace SobesWebAPI.Controllers;

public class ReportController: Controller
{
    
    [HttpPost]
    public IActionResult User_statistics(string id_user, int start, int end)
    {
        User user = new User(id_user, start, end);

        return Json(user.getData());
    }
    
    [HttpGet]
    public IActionResult Info(string GUID)
    {
        Query query = new Query(GUID);

        return Json(query.getData());
    }
}