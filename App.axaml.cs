using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using BugFablesDataEditor.Models;
using BugFablesDataEditor.ViewModels;
using BugFablesDataEditor.Views;

namespace BugFablesDataEditor
{
  public class App : Application
  {
    public override void Initialize()
    {
      AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
      if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
      {
        desktop.MainWindow = new MainWindow
        {
          DataContext = new MainWindowViewModel(new EntityDirectory()),
        };
      }

      base.OnFrameworkInitializationCompleted();
    }
  }
}