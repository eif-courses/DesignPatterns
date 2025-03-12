namespace DesignPatterns.Builder;


public enum FileType
{
    VIDEO,
    DOC,
    ZIP,
    IMAGE,
    AUDIO
}

public class CustomFile
{
    public string Name { get; private set; }
    public string Path { get; private set; }
    public int Size { get; private set; }
    public FileType Type { get; private set; }

    private CustomFile() { }

    public class Builder
    {
        private readonly CustomFile _customFile = new();

        public Builder Name(string name)
        {
            _customFile.Name = name;
            return this;
        }
        public Builder Path(string path)
        {
            _customFile.Path = path;
            return this;
        }

        public Builder Size(int size)
        {
            _customFile.Size = size;
            return this;
        }

        public Builder Type(FileType type)
        {
            _customFile.Type = type;
            return this;
        }

        // Čia galite atlikti patikrinimą parametrų ir
        // nesukurti objekto jeigu kažkas netaip
        // Pvz. failo dydis yra 0.
        public CustomFile Build()
        {
            return _customFile;
        }
        
    }
    
    
}