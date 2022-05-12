using System.Windows;
using WpfMvvmExample.Logic.Stores;
using WpfMvvmExample.Logic.ViewModels;

namespace WpfMvvmExample;

public partial class App : Application
{
    private readonly NavigationStore _navigationStore;

    public App()
    {
        _navigationStore = new();
        _navigationStore.CurrentViewModel = new StudentsListViewModel(_navigationStore);
    }

    protected override void OnStartup(StartupEventArgs e)
    {
        MainWindow = new MainWindow()
        {
            DataContext = new MainViewModel(_navigationStore)
        };

        MainWindow.Show();

        base.OnStartup(e);
    }
}
