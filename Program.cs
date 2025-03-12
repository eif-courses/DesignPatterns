using DesignPatterns.Adapter;
using DesignPatterns.Builder;
using DesignPatterns.Facade;
using DesignPatterns.Factory;
using DesignPatterns.Observer;
using DesignPatterns.Strategy;

// Builder pattern
var customFile = new CustomFile.Builder()
    .Name("myprofile.png")
    .Path("C://myprofile.png")
    .Type(FileType.IMAGE)
    .Size(100)
    .Build();

var shortVideo = new CustomFile.Builder()
    .Name("presentation.mkv")
    .Build();


// Factory pattern

ShapeFactory shapeFactory = new ShapeFactory();

IShape cirle = shapeFactory.CreateShape(ShapeType.Circle);
IShape rectangle = shapeFactory.CreateShape(ShapeType.Rectangle);
IShape triangle = shapeFactory.CreateShape(ShapeType.Triangle);

cirle.Draw();
rectangle.Draw();
triangle.Draw();


// Strategy pattern
StorageContext context = new StorageContext(new FirebaseStorageStrategy());
Console.WriteLine(context.Upload(customFile.Name));

context = new StorageContext(new ClouflareStorageStrategy());
Console.WriteLine(context.Upload(shortVideo.Name));



// Facade pattern 

var home = new SmartHomeFacade();
home.TurnOn();
home.SetTemperature(25);
home.TurnOff();

// Adapter pattern

Console.WriteLine("Client: Working with objects that use the Target interface:");
var target = new CurrentServiceTarget();
// Default metodas naujausias
ClientForAdapterTest.ClientCode(target);
Console.WriteLine("Client: Now I'll work with the LegacyService via the Adapter:");

LegacyService legacyService = new LegacyService();
ITarget adapter = new LegacyServiceAdapter(legacyService);
ClientForAdapterTest.ClientCode(adapter);

// Observer pattern

var course = new Course("Programavimas C#");

var marius = new Student("Marius");
var ona = new Student("Ona");

course.AddObserver(marius);
course.AddObserver(ona);

course.ChangeCourseName("Programvimas C# kalba");


