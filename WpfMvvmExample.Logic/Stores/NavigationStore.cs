using WpfMvvmExample.Logic.ViewModels;

namespace WpfMvvmExample.Logic.Stores;
public class NavigationStore
{
    public event Action? CurrentViewModelChanged;
    public ViewModelBase? CurrentViewModel
    {
        get => _currentViewModel;
        set
        {
            _currentViewModel = value;
            OnCurrentViewModelChanged();
        }
    }

    private ViewModelBase? _currentViewModel;

    private void OnCurrentViewModelChanged()
    {
        CurrentViewModelChanged?.Invoke();
    }
}
