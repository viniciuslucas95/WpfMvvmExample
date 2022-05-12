using WpfMvvmExample.Data.Models;
using WpfMvvmExample.Logic.Commands;
using WpfMvvmExample.Logic.Stores;

namespace WpfMvvmExample.Logic.ViewModels;

public class StudentViewModel : ViewModelBase
{
    public string FirstName
    {
        get => _firstName;
        set
        {
            _firstName = value;
            OnPropertyChanged(nameof(FirstName));
        }
    }
    public string LastName
    {
        get => _lastName;
        set
        {
            _lastName = value;
            OnPropertyChanged(nameof(LastName));
        }
    }
    public string Age
    {
        get => _age;
        set
        {
            _age = value;
            OnPropertyChanged(nameof(Age));
        }
    }
    public string Class
    {
        get => _class;
        set
        {
            _class = value;
            OnPropertyChanged(nameof(Class));
        }
    }
    public CommandBase SubmitCommand { get; private init; }
    public CommandBase CancelCommand { get; private init; }

    private Action<Student> _createStudentAction;

    private string _firstName = "";
    private string _lastName = "";
    private string _age = "";
    private string _class = "";
    private readonly NavigationStore _navigationStore;
    private readonly ViewModelBase _previousViewModel;

    public StudentViewModel(NavigationStore navigationStore, ViewModelBase previousViewModel, Action<Student> createStudentAction)
    {
        _createStudentAction = createStudentAction;
        _navigationStore = navigationStore;
        _previousViewModel = previousViewModel;

        CancelCommand = new ExecuteCommand(GoBackToPreviousViewModel);
        SubmitCommand = new ExecuteCommand(CreateStudent, CanSubmiteCommandExecute);
    }

    protected override void OnPropertyChanged(string? propertyName)
    {
        base.OnPropertyChanged(propertyName);

        SubmitCommand.OnCanExecuteChanged();
    }

    private void CreateStudent()
    {
        Student student = new(FirstName, LastName, Age, Class);

        _createStudentAction(student);

        GoBackToPreviousViewModel();
    }

    private void GoBackToPreviousViewModel()
        => _navigationStore.CurrentViewModel = _previousViewModel;

    private bool CanSubmiteCommandExecute()
        => !string.IsNullOrEmpty(FirstName) &&
           !string.IsNullOrEmpty(LastName) &&
           !string.IsNullOrEmpty(Age);
}
