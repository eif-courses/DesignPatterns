interface IStorageStrategy
{
    string save(string name);
}

class ClouflareStorageStrategy : IStorageStrategy
{
    public string save(string name)
    {
        return name;
        //throw new NotImplementedException();
    }
}

class FirebaseStorageStrategy : IStorageStrategy
{
    public string save(string name)
    {
        return name;
        //throw new NotImplementedException();
    }
}

class StorageContext
{
    readonly IStorageStrategy _strategy;

    public StorageContext(IStorageStrategy strategy)
    {
        _strategy = strategy;
    }

    public string save(string name)
    {
        return _strategy.save(name);
    }
}


internal class Program
{
    public static void Main(string[] args)
    {
        StorageContext context = new StorageContext(new FirebaseStorageStrategy());
        Console.WriteLine(context.save("firebase.png"));
        
        context = new StorageContext(new ClouflareStorageStrategy());
        Console.WriteLine(context.save("clouflare.png"));
        
    }
}


