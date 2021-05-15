using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using BugFablesEntityEditor.ViewModels;

namespace BugFablesEntityEditor.Views
{
  public partial class EmoticonsView : UserControl
  {
    public EmoticonsView()
    {
      InitializeComponent();
    }

    public EmoticonsView(MainWindowViewModel vm)
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
