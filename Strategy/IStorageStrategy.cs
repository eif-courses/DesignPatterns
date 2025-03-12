namespace DesignPatterns.Strategy;

interface IStorageStrategy
{
    string Upload(string name);
}


class FirebaseStorageStrategy : IStorageStrategy
{
    public string Upload(string name)
    {
        return name;
        //throw new NotImplementedException();
    }
}
class ClouflareStorageStrategy : IStorageStrategy
{
    public string Upload(string name)
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

    public string Upload(string name)
    {
        return _strategy.Upload(name);
    }
}
