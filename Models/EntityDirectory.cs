using BugFablesEntityEditor.BugFablesEnums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugFablesEntityEditor.Models
{
  public class EntityDirectory
  {
    public Dictionary<int, List<Entity>> Entities { get; set; }

    public EntityDirectory()
    {
      Entities = new Dictionary<int, List<Entity>>();

      Map[] maps = (Map[])Enum.GetValues(typeof(Map));
      foreach (var mapValue in maps)
      {
        if (mapValue != Map.COUNT)
          Entities.Add((int)mapValue, new List<Entity>());
      }
    }

    public void LoadDirectory(string path)
    {
      var dataFilePaths = Directory.GetFiles(path);
      var namesFilePaths = Directory.GetFiles(Path.Combine(path, "names"));

      foreach (var dataFile in dataFilePaths)
      {
        string mapIdStr = Path.GetFileNameWithoutExtension(dataFile);
        int mapIdInt = 0;
        // There is an unused file called MapNames so skip if the filename isn't an integer
        if (!int.TryParse(mapIdStr, out mapIdInt))
          continue;

        if (mapIdInt < 0)
          throw new Exception(mapIdInt + " is not a valid map id");

        string[] names = new string[] { };
        string namesPath = namesFilePaths.FirstOrDefault(x => Path.GetFileNameWithoutExtension(x) == mapIdStr + "names");
        if (namesPath != null)
          names = File.ReadAllLines(namesPath);
        string[] entityLines = File.ReadAllLines(dataFile);
        for (int i = 0; i < entityLines.Length; i++)
        {
          Entity entity = new Entity();
          entity.ParseFromEntityLine(entityLines[i]);
          if (names.Length > i)
            entity.Name = names[i];
          if (!Entities.ContainsKey(mapIdInt))
            Entities.Add(mapIdInt, new List<Entity>());
          Entities[mapIdInt].Add(entity);
        }
      }
    }

    public void WriteDirectory(string path)
    {
      string namesDirectoryPath = Path.Combine(path, "names");
      if (!Directory.Exists(namesDirectoryPath))
        Directory.CreateDirectory(namesDirectoryPath);

      foreach (var mapEntities in Entities)
      {
        string dataPath = Path.Combine(path, mapEntities.Key.ToString() + ".bytes");
        string namesPath = Path.Combine(path, "names", mapEntities.Key.ToString() + "names.bytes");

        if (File.Exists(dataPath))
          File.Delete(dataPath);
        if (File.Exists(namesPath))
          File.Delete(namesPath);

        List<string> entityLines = new List<string>();
        List<string> names = new List<string>();
        foreach (var entity in mapEntities.Value)
        {
          entityLines.Add(entity.EncodeToEntityLine());
          names.Add(entity.Name);
        }

        File.WriteAllText(dataPath, string.Join('\n', entityLines) + "\n");
        File.WriteAllText(namesPath, string.Join('\n', names) + "\n");
      }
    }

    internal void ResetToDefault()
    {
      foreach (var mapEntities in Entities)
        mapEntities.Value.Clear();
    }
  }
}
