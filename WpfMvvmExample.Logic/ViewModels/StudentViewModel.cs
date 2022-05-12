using System.Windows.Input;

namespace WPFTest.ViewModels;

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
    public int Age
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
    public ICommand CreateCommand { get; private init; }
    public ICommand CancelCommand { get; private init; }

    private string _firstName = "";
    private string _lastName = "";
    private int _age = 0;
    private string _class = "";
}
