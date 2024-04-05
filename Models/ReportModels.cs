namespace SobesWebAPI.Controllers;

//RequestData for POST/report/user_statistics
public record class User(
    string id_user,
    int start,
    int end    
);

//ResponseData for GET/report info
private record class Query(
    string GUID,
    int percent
        
);

