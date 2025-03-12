namespace DesignPatterns.Adapter;

public interface ITarget
{
    string Request();
}

public class LegacyService
{
    public string GetSpecificRequest()
    {
        return "LegacyService specific request";
    }
}

public class LegacyServiceAdapter : ITarget
{

    private readonly LegacyService _legacyService;

    public LegacyServiceAdapter(LegacyService legacyService)
    {
        _legacyService = legacyService;
    }
    
    public string Request()
    {
        string result = _legacyService.GetSpecificRequest();    
        return "Transformed data from Legacy service response: " + result;
    }
}

public class CurrentServiceTarget : ITarget
{
    public string Request()
    {
        return "Current service: default request";
    }
}

public class ClientForAdapterTest
{
    public static void ClientCode(ITarget target)
    {
        Console.WriteLine(target.Request());
    }
}


