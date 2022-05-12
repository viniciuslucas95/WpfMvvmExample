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
    public BaseCommand SubmitCommand { get; private init; }
    public BaseCommand CancelCommand { get; private init; }

    private readonly NavigationStore _navigationStore;
    private string _firstName = "";
    private string _lastName = "";
    private string _age = "";
    private string _class = "";

    public StudentViewModel(NavigationStore navigationStore)
    {
        _navigationStore = navigationStore;

        CancelCommand = new ExecuteCommand(() =>
        {
            _navigationStore.CurrentViewModel = new StudentsListViewModel(_navigationStore);
        });

        SubmitCommand = new ExecuteCommand(() =>
        {

        }, CanSubmiteCommandExecute);
    }

    protected override void OnPropertyChanged(string? propertyName)
    {
        base.OnPropertyChanged(propertyName);

        SubmitCommand.OnCanExecuteChanged();
    }

    private bool CanSubmiteCommandExecute()
        => !string.IsNullOrEmpty(FirstName) &&
           !string.IsNullOrEmpty(LastName) &&
           !string.IsNullOrEmpty(Age);
}
