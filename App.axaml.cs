using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using BugFablesEntityEditor.Models;
using BugFablesEntityEditor.ViewModels;
using BugFablesEntityEditor.Views;

namespace BugFablesEntityEditor
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