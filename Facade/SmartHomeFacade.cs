namespace DesignPatterns.Facade;

public class LightController
{
    public void TurnOn() => Console.WriteLine("Turning on light");
    public void TurnOff() => Console.WriteLine("Turning off light");
}
public class AudioController
{
    public void Play() => Console.WriteLine("Playing audio");
    public void Stop() => Console.WriteLine("Stop audio");
}

public class AirConditionerController
{
    public void TurnOn() => Console.WriteLine("Turning on air conditioner");
    public void TurnOff() => Console.WriteLine("Turning off air conditioner");
    public void SetTemperature(double temperature) => Console.WriteLine("Setting temperature to " + temperature);
}
public class HeatingController
{
    public void TurnOn() => Console.WriteLine("Turning on heating");
    public void TurnOff() => Console.WriteLine("Turning off heating");
    public void SetTemperature(double temperature) => Console.WriteLine("Setting temperature to " + temperature);
}

public class SmartHomeFacade
{
    private LightController _lightController;
    private AudioController _audioController;
    private AirConditionerController _airConditionerController;
    private HeatingController _heatingController;


    public SmartHomeFacade()
    {
        _lightController = new LightController();
        _audioController = new AudioController();
        _airConditionerController = new AirConditionerController();
        _heatingController = new HeatingController();
    }

    public void SetTemperature(double temperature)
    {
        Console.WriteLine("Setting temperature to " + temperature);
        _heatingController.SetTemperature(temperature);
        _airConditionerController.SetTemperature(temperature);
    }
    
    public void TurnOn()
    {
        Console.WriteLine("Turning on SmartHome configuration...");
        _heatingController.TurnOn();
        _airConditionerController.TurnOn();
        _audioController.Play();
        _lightController.TurnOn();
    }

    public void TurnOff()
    {
        Console.WriteLine("Turning off SmartHome configuration...");
        _heatingController.TurnOff();
        _airConditionerController.TurnOff();
        _audioController.Stop();
        _lightController.TurnOff();
    }
}