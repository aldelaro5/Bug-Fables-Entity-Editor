using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using BugFablesEntityEditor.ViewModels;

namespace BugFablesEntityEditor.Views
{
  public partial class ArraysView : UserControl
  {
    public ArraysView()
    {
      InitializeComponent();
    }

    public ArraysView(MainWindowViewModel vm)
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
