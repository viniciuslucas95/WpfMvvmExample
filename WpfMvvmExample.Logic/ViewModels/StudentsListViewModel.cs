using System.Collections.ObjectModel;
using System.Windows.Input;
using WPFTest.Models;

namespace WPFTest.ViewModels;

public class StudentsListViewModel : ViewModelBase
{
    public ICommand CreateStudentCommand { get; private init; }
    public IEnumerable<Student> Students => _students;

    private readonly ObservableCollection<Student> _students = new();

    public StudentsListViewModel()
    {
        _students.Add(new Student("Carlos", "Daniel de Almeida", "20", "EPCAR"));
        _students.Add(new Student("Ana", "Cláudia", "46", "ESPEX"));
        _students.Add(new Student("Fátima", "Bernardes", "250", "EPCAR"));
    }
}
