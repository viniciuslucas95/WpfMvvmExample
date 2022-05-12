using System.Collections.ObjectModel;
using System.Windows.Input;
using WpfMvvmExample.Data.Models;
using WpfMvvmExample.Logic.Commands;
using WpfMvvmExample.Logic.Stores;

namespace WpfMvvmExample.Logic.ViewModels;

public class StudentsListViewModel : ViewModelBase
{
    public ICommand GoToStudentPageCommand { get; private init; }
    public IEnumerable<Student> Students => _students;

    private readonly ObservableCollection<Student> _students = new();
    private readonly NavigationStore _navigationStore;

    public StudentsListViewModel(NavigationStore navigationStore)
    {
        _navigationStore = navigationStore;

        _students.Add(new Student("Carlos", "Daniel de Almeida", "20", "EPCAR"));
        _students.Add(new Student("Ana", "Cláudia", "46", "ESPEX"));
        _students.Add(new Student("Fátima", "Bernardes", "250", "EPCAR"));

        GoToStudentPageCommand = new ExecuteCommand(() =>
        {
            _navigationStore.CurrentViewModel = new StudentViewModel(_navigationStore);
        });
    }
}
