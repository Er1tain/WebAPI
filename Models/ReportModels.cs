namespace SobesWebAPI.Models;


//RequestData for POST/report/user_statistics
public record class User(
    string id_user,
    int start,
    int end    
);

//ResponseData for GET/report info
public record class Query(
    string GUID,
    int percent
        
);

