using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using BugFablesDataEditor.ViewModels;

namespace BugFablesDataEditor.Views
{
  public partial class LocationView : UserControl
  {
    public LocationView()
    {
      InitializeComponent();
    }

    public LocationView(MainWindowViewModel vm)
    {
      InitializeComponent();
      DataContext = vm;
    }

    private void InitializeComponent()
    {
      AvaloniaXamlLoader.Load(this);
    }
  }
}
