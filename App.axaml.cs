using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using BugFablesEntityEditor.Models;
using BugFablesEntityEditor.ViewModels;
using BugFablesEntityEditor.Views;
using Common.MessageBox.Enums;
using ReactiveUI;
using System;
using System.Reactive;

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

      RxApp.DefaultExceptionHandler = Observer.Create<Exception>((ex) =>
      {
        CommonUtils.GetMessageBox("Unexpected error", "An unexpected error occured: " +
            ex.Message, ButtonEnum.Ok, Icon.Error).ShowDialog(CommonUtils.MainWindow);
      });
    }
  }
}