namespace SobesWebAPI.Models;

public interface ModelsMethod
{
    public void getData();
}

//RequestData for POST/report/user_statistics
public class User: ModelsMethod
{
    private string id_user;
    private int start;
    private int end;
    
    public User(string id_user, int start, int end)
    {
        this.id_user = id_user;
        this.start = start;
        this.end = end;
    }

    public void getData()
    {
        
    }
}

//ResponseData for GET/report info
public class Query: ModelsMethod
{
    private string GUID;
    private int percent;
    
    public Query(string GUID, int percent)
    {
        this.GUID = GUID;
        this.percent = percent;
    }
    
    public void getData()
    {
        
    }
    
}

