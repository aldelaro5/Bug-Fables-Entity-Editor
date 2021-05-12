using Avalonia.Controls;
using BugFablesDataEditor.Models;
using Common.MessageBox.Enums;
using ReactiveUI;
using System;
using System.Linq;
using System.Reactive;

namespace BugFablesDataEditor.ViewModels
{
  public class MainWindowViewModel : ViewModelBase
  {
    private bool directorySaved = false;

    private string _currentDirectoryPath = "No entity directory, open an existing directory or create a new one";
    public string CurrentDirectoryPath
    {
      get { return _currentDirectoryPath; }
      set { _currentDirectoryPath = value; this.RaisePropertyChanged(); }
    }

    private EntityDirectory _entityDirectory;
    public EntityDirectory EntityDirectory
    {
      get { return _entityDirectory; }
      set { _entityDirectory = value; this.RaisePropertyChanged(); }
    }

    private bool _directoryInUse = false;
    public bool DirectoryInUse
    {
      get { return _directoryInUse; }
      set { _directoryInUse = value; this.RaisePropertyChanged(); }
    }

    public ReactiveCommand<Unit, Unit> CmdSaveDirectory { get; set; }

    public MainWindowViewModel()
    {
      EntityDirectory directory = new EntityDirectory();
      EntityDirectory = directory;
      Initialise(directory);
    }

    public MainWindowViewModel(EntityDirectory directory)
    {
      EntityDirectory = directory;
      Initialise(directory);
    }

    private void Initialise(EntityDirectory directory)
    {
      CmdSaveDirectory = ReactiveCommand.CreateFromTask(async () =>
      {
        OpenFolderDialog dlg = new OpenFolderDialog();
        dlg.Title = "Select the location to save the directory";
        string filePath = await dlg.ShowAsync(CommonUtils.MainWindow);
        if (!string.IsNullOrEmpty(filePath))
        {
          try
          {
            EntityDirectory.WriteDirectory(filePath);
            CurrentDirectoryPath = filePath;
            directorySaved = true;
          }
          catch (Exception ex)
          {
            var msg = CommonUtils.GetMessageBox("Error opening save file",
                        "An error occured while saving the save file: " + ex.Message, ButtonEnum.Ok, Icon.Error);
            await msg.ShowDialog(CommonUtils.MainWindow);
          }
        }
      }, this.WhenAnyValue(x => x.DirectoryInUse));
    }



    public async void NewDirectory()
    {
      if (DirectoryInUse && !directorySaved)
      {
        var msg = CommonUtils.GetMessageBox("Directory in use", "An unsaved directory is currently in use, " +
                  "creating a new directory will loose all unsaved changes,\nare you sure you want to proceed?",
                  ButtonEnum.YesNo, Icon.Question);
        await msg.ShowDialog(CommonUtils.MainWindow);
        if (msg.ButtonResult == ButtonResult.No)
          return;
      }

      EntityDirectory.ResetToDefault();
      CurrentDirectoryPath = "New directory being created, save it to store it";
      DirectoryInUse = true;
      directorySaved = false;
    }

    public async void OpenDirectory()
    {
      if (DirectoryInUse && !directorySaved)
      {
        var msg = CommonUtils.GetMessageBox("Directory in use", "An unsaved directory is currently in use, " +
                  "opening a directory will loose all unsaved changes,\nare you sure you want to proceed?",
                  ButtonEnum.YesNo, Icon.Question);
        await msg.ShowDialog(CommonUtils.MainWindow);
        if (msg.ButtonResult == ButtonResult.No)
          return;
      }

      OpenFolderDialog dlg = new OpenFolderDialog();
      dlg.Title = "Select a Bug Fables entitydata directory";
      string filePaths = await dlg.ShowAsync(CommonUtils.MainWindow);
      try
      {
        EntityDirectory.ResetToDefault();
        EntityDirectory.LoadDirectory(filePaths);
        CurrentDirectoryPath = filePaths;
        DirectoryInUse = true;
        directorySaved = true;
      }
      catch (Exception ex)
      {
        EntityDirectory.ResetToDefault();
        var msg = CommonUtils.GetMessageBox("Error opening directory",
                    "An error occured while opening the directory: " + ex.Message, ButtonEnum.Ok, Icon.Error);
        await msg.ShowDialog(CommonUtils.MainWindow);
      }
    }

    public void Exit()
    {
      CommonUtils.MainWindow.Close();
    }
  }
}
