using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SobesWebAPI.Models;

namespace SobesWebAPI.Controllers;

public class ReportController: Controller
{
    [HttpPost]
    public string User_statistics()
    {
        return "User_statistics";
    }
    
    [HttpGet]
    public string Info(string GUID)
    {
        return "info_of_query";
    }
    
    
}