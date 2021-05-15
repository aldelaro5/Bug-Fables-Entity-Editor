using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using BugFablesEntityEditor.ViewModels;

namespace BugFablesEntityEditor.Views
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
