using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using BugFablesDataEditor.Views;
using Common.MessageBox.Enums;
using System;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace BugFablesDataEditor
{
  public enum ReorderDirection
  {
    Up,
    Down
  }

  public class Vector2Int : INotifyPropertyChanged
  {
    private int _x;
    public int x
    {
      get { return _x; }
      set { _x = value; NotifyPropertyChanged(); }
    }

    private int _y;
    public int y
    {
      get { return _y; }
      set { _y = value; NotifyPropertyChanged(); }
    }

    public event PropertyChangedEventHandler? PropertyChanged;
    private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
    {
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
  }

  public class Vector3 : INotifyPropertyChanged
  {
    private float _x;
    public float x
    {
      get { return _x; }
      set { _x = value; NotifyPropertyChanged(); }
    }

    private float _y;
    public float y
    {
      get { return _y; }
      set { _y = value; NotifyPropertyChanged(); }
    }

    private float _z;
    public float z
    {
      get { return _z; }
      set { _z = value; NotifyPropertyChanged(); }
    }

    public event PropertyChangedEventHandler? PropertyChanged;
    private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
    {
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
  }

  public class Color : INotifyPropertyChanged
  {
    private float _r;
    public float r
    {
      get { return _r; }
      set { _r = value; NotifyPropertyChanged(); }
    }

    private float _g;
    public float g
    {
      get { return _g; }
      set { _g = value; NotifyPropertyChanged(); }
    }

    private float _b;
    public float b
    {
      get { return _b; }
      set { _b = value; NotifyPropertyChanged(); }
    }

    private float _a;
    public float a
    {
      get { return _a; }
      set { _a = value; NotifyPropertyChanged(); }
    }

    public event PropertyChangedEventHandler? PropertyChanged;
    private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
    {
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
  }

  public static class CommonUtils
  {
    public const string FieldSeparator = "}";
    public const string ElementSeparator = ",";

    public static Window MainWindow { get => ((IClassicDesktopStyleApplicationLifetime)Application.Current.ApplicationLifetime).MainWindow; }

    public static MessageBoxView GetMessageBox(string title, string text, ButtonEnum buttons, Icon icon)
    {
      MessageBoxView view = new MessageBoxView(title, text, buttons, icon);

      return view;
    }

    public static string[] GetEnumDescriptions<T>()
      where T : struct, Enum
    {
      var type = typeof(T);
      var values = Enum.GetValues<T>().ToList();
      values.Remove(values.Last());
      string[] descriptions = new string[values.Count];
      for (int i = 0; i < values.Count; i++)
      {
        var memberInfo = type.GetMember(values[i].ToString());
        if (memberInfo.Length > 0)
        {
          var attrs = memberInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
          if (attrs.Length > 0)
          {
            descriptions[i] = ((DescriptionAttribute)attrs[0]).Description;
            continue;
          }
        }
        descriptions[i] = values[i].ToString();
      }

      return descriptions;
    }
  }
}
