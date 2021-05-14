using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using BugFablesDataEditor.ViewModels;

namespace BugFablesDataEditor.Views
{
  public partial class ActionsView : UserControl
  {
    public ActionsView()
    {
      InitializeComponent();
    }

    public ActionsView(MainWindowViewModel vm)
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
