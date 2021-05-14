using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using BugFablesDataEditor.ViewModels;

namespace BugFablesDataEditor.Views
{
  public partial class PropertiesView : UserControl
  {
    public PropertiesView()
    {
      InitializeComponent();
    }

    public PropertiesView(MainWindowViewModel vm)
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
