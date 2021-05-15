using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using BugFablesEntityEditor.ViewModels;
using System.Runtime.InteropServices;

namespace BugFablesEntityEditor.Views
{
  public partial class EditEntityNameView : Window
  {
    private TextBox txbName;

    private bool _confirmed = false;
    public bool Confirmed
    {
      get { return _confirmed; }
      set { _confirmed = value; }
    }

    public EditEntityNameView()
    {
      InitializeComponent();
      DataContext = new MainWindowViewModel();
    }

    public EditEntityNameView(MainWindowViewModel vm)
    {
      InitializeComponent();
#if DEBUG
      this.AttachDevTools();
#endif
      DataContext = vm;
      txbName = this.FindControl<TextBox>("txbName");
      txbName.Focus();

      if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
      {
        ExtendClientAreaToDecorationsHint = true;
        ExtendClientAreaChromeHints = Avalonia.Platform.ExtendClientAreaChromeHints.NoChrome;
        ExtendClientAreaTitleBarHeightHint = -1;

        var windowsTitleBar = this.FindControl<WindowsTitleBar>("windowsTitleBar");
        windowsTitleBar.IsVisible = true;
        TextBlock systemChromeTitle = windowsTitleBar.FindControl<TextBlock>("SystemChromeTitle");
        systemChromeTitle.Text = "Edit entity's name";
      }
    }

    private void InitializeComponent()
    {
      AvaloniaXamlLoader.Load(this);
    }

    public void OkClick(object sender, RoutedEventArgs e)
    {
      Confirmed = true;
      Close();
    }

    public void CancelClick(object sender, RoutedEventArgs e)
    {
      Confirmed = false;
      Close();
    }
  }
}
