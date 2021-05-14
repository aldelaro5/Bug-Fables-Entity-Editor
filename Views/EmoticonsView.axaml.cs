using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using BugFablesDataEditor.ViewModels;

namespace BugFablesDataEditor.Views
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
