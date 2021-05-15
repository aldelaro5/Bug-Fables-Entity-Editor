using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace BugFablesEntityEditor.Views
{
  public class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
#if DEBUG
      this.AttachDevTools();
#endif

      SettingsManager.Load();

      if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
      {
        ExtendClientAreaToDecorationsHint = true;
        ExtendClientAreaChromeHints = Avalonia.Platform.ExtendClientAreaChromeHints.NoChrome;
        ExtendClientAreaTitleBarHeightHint = -1;

        var windowsTitleBar = this.FindControl<WindowsTitleBar>("windowsTitleBar");
        windowsTitleBar.IsVisible = true;
        TextBlock systemChromeTitle = windowsTitleBar.FindControl<TextBlock>("SystemChromeTitle");
        systemChromeTitle.Text = "Bug Fables Entity Editor";
      }

      Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
      Trace.AutoFlush = true;
    }

    private void InitializeComponent()
    {
      AvaloniaXamlLoader.Load(this);
    }

    public async void OnAbout_Click(object sender, RoutedEventArgs e)
    {
      AboutView view = new AboutView();
      view.Width = 500;
      view.Height = 350;
      await view.ShowDialog(CommonUtils.MainWindow);
    }
  }
}
