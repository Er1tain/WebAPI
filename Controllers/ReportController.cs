using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SobesWebAPI.Models;

namespace SobesWebAPI.Controllers;

public class ReportController: Controller
{
    //RequestData for POST/report/user_statistics
    private record class User(
            string id_user,
            int start,
            int end    
        );
    
    //ResponseData for GET/report info
    private record class Query(
        string GUID,
        int percent,
        
        );
    
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