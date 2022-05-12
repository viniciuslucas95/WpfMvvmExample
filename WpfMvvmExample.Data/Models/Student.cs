namespace WPFTest.Models;

public class Student : Model
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Age { get; set; }
    public string Class { get; set; }

    public Student(string firstName, string lastName, string age, string className) : base()
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        Class = className;
    }
}
