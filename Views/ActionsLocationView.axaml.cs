using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using BugFablesEntityEditor.ViewModels;

namespace BugFablesEntityEditor.Views
{
  public partial class ActionsLocationView : UserControl
  {
    public ActionsLocationView()
    {
      InitializeComponent();
    }

    public ActionsLocationView(MainWindowViewModel vm)
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
