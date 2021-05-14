using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using BugFablesDataEditor.ViewModels;

namespace BugFablesDataEditor.Views
{
  public partial class CollidersView : UserControl
  {
    public CollidersView()
    {
      InitializeComponent();
    }

    public CollidersView(MainWindowViewModel vm)
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
