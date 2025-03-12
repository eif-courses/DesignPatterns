namespace DesignPatterns.Observer;

public interface ICourseObserver {
    void Update(string courseName);
}

// https://www.scholarhat.com/tutorial/designpatterns/design-patterns-in-c-sharp
public interface ICourseSubject
{
    void AddObserver(ICourseObserver observer);
    void RemoveObserver(ICourseObserver observer);
    void NotifyObservers();
}

class Course: ICourseSubject
{
    private List<ICourseObserver> _observers = [];
    private string _courseName;

    public Course(string courseName)
    {
        _courseName = courseName;
    }

    public void AddObserver(ICourseObserver observer)
    {
        _observers.Add(observer);
    }

    public void RemoveObserver(ICourseObserver observer)
    {
        _observers.Remove(observer);
    }

    public void NotifyObservers()
    {
        foreach (ICourseObserver observer in _observers)
        {
            observer.Update(_courseName);
        }
    }

    public void ChangeCourseName(string newCourseName)
    {
        _courseName = newCourseName;
        NotifyObservers();
    }
}



class Student : ICourseObserver
{
    private string studentName;

    public Student(string studentName)
    {
        this.studentName = studentName;
    }

    public void Update(string courseName)
    {
        Console.WriteLine(studentName + " received update: " + courseName);
    }
}
