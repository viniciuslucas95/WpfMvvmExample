namespace WPFTest.ViewModels;

public class MainViewModel : ViewModelBase
{
    public ViewModelBase CurrentViewModel { get; private init; }

    public MainViewModel()
    {
        CurrentViewModel = new StudentsListViewModel();
    }
}
