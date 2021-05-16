using Avalonia.Media;
using BugFablesEntityEditor.BugFablesEnums;
using System;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;

namespace BugFablesEntityEditor.Models
{
  public class Entity : INotifyPropertyChanged
  {
    public class IndexedElement<T> : INotifyPropertyChanged
    {
      private int _index;
      public int Index
      {
        get { return _index; }
        set { _index = value; NotifyPropertyChanged(); }
      }

      private T _value;
      public T Value
      {
        get { return _value; }
        set { _value = value; NotifyPropertyChanged(); }
      }

      public event PropertyChangedEventHandler? PropertyChanged;
      private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
      {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
      }
    }

    private string _name = "";
    public string Name
    {
      get { return _name; }
      set
      {
        _name = value;
        NotifyPropertyChanged();
        NotifyPropertyChanged(nameof(Holo));
        NotifyPropertyChanged(nameof(ICE));
        NotifyPropertyChanged(nameof(TIME));
        NotifyPropertyChanged(nameof(COT));
        NotifyPropertyChanged(nameof(Fixed));
        NotifyPropertyChanged(nameof(FxdCol));
        NotifyPropertyChanged(nameof(ALW));
        NotifyPropertyChanged(nameof(PAU));
        NotifyPropertyChanged(nameof(HIDE));
        NotifyPropertyChanged(nameof(ROT));
        NotifyPropertyChanged(nameof(ShwEm));
        NotifyPropertyChanged(nameof(COG));
        NotifyPropertyChanged(nameof(NGS));
        NotifyPropertyChanged(nameof(ITHD));
        NotifyPropertyChanged(nameof(NEAR));
        NotifyPropertyChanged(nameof(WTA));
        NotifyPropertyChanged(nameof(TOG));
        NotifyPropertyChanged(nameof(NGF));
        NotifyPropertyChanged(nameof(NDTCT));
        NotifyPropertyChanged(nameof(DDIST));
      }
    }

    public bool Holo { get { return Name.Contains("Holo"); } }
    public bool ICE { get { return Name.Contains("ICE"); } }
    public bool TIME { get { return Name.Contains("TIME"); } }
    public bool COT { get { return Name.Contains("COT"); } }
    public bool Fixed { get { return Name.Contains("Fixed"); } }
    public bool FxdCol { get { return Name.Contains("FxdCol"); } }
    public bool ALW { get { return Name.Contains("ALW"); } }
    public bool PAU { get { return Name.Contains("PAU"); } }
    public bool HIDE { get { return Name.Contains("HIDE"); } }
    public bool ROT { get { return Name.Contains("ROT"); } }
    public bool ShwEm { get { return Name.Contains("ShwEm"); } }
    public bool COG { get { return Name.Contains("COG"); } }
    public bool NGS { get { return Name.Contains("NGS"); } }
    public bool ITHD { get { return Name.Contains("ITHD"); } }
    public bool NEAR { get { return Name.Contains("NEAR"); } }
    public bool WTA { get { return Name.Contains("WTA"); } }
    public bool TOG { get { return Name.Contains("TOG"); } }
    public bool NGF { get { return Name.Contains("NGF"); } }
    public bool NDTCT { get { return Name.Contains("NDTCT"); } }
    public bool DDIST { get { return Name.Contains("DDIST"); } }

    private NPCType _entityType = NPCType.UNDEFINED;
    public NPCType EntityType
    {
      get { return _entityType; }
      set { _entityType = value; NotifyPropertyChanged(); }
    }

    private ObjectTypes objectTypes = ObjectTypes.UNDEFINED;
    public ObjectTypes ObjectType
    {
      get { return objectTypes; }
      set { objectTypes = value; NotifyPropertyChanged(); }
    }

    private ActionBehaviors[] _behaviors = new ActionBehaviors[2];
    public ActionBehaviors[] Behaviors
    {
      get { return _behaviors; }
      set { _behaviors = value; NotifyPropertyChanged(); }
    }

    private Interaction _interactType = Interaction.UNDEFINED;
    public Interaction InteractType
    {
      get { return _interactType; }
      set { _interactType = value; NotifyPropertyChanged(); }
    }

    private DeathType _destroyType = DeathType.UNDEFINED;
    public DeathType DestroyType
    {
      get { return _destroyType; }
      set { _destroyType = value; NotifyPropertyChanged(); }
    }

    private Vector3 _startPos = new Vector3();
    public Vector3 StartPos
    {
      get { return _startPos; }
      set { _startPos = value; NotifyPropertyChanged(); }
    }

    private int _animId = -1;
    public int AnimId
    {
      get { return _animId; }
      set { _animId = value; NotifyPropertyChanged(); }
    }

    private bool _flip;
    public bool Flip
    {
      get { return _flip; }
      set { _flip = value; NotifyPropertyChanged(); }
    }

    private float _ccolHeight;
    public float CcolHeight
    {
      get { return _ccolHeight; }
      set { _ccolHeight = value; NotifyPropertyChanged(); }
    }

    private float _ccolRadisu;
    public float CcolRadius
    {
      get { return _ccolRadisu; }
      set { _ccolRadisu = value; NotifyPropertyChanged(); }
    }

    private float _radius;
    public float Radius
    {
      get { return _radius; }
      set { _radius = value; NotifyPropertyChanged(); }
    }

    private float _timer;
    public float Timer
    {
      get { return _timer; }
      set { _timer = value; NotifyPropertyChanged(); }
    }

    private float _speed;
    public float Speed
    {
      get { return _speed; }
      set { _speed = value; NotifyPropertyChanged(); }
    }

    private float[] _actionFrequency = new float[2];
    public float[] ActionFrequency
    {
      get { return _actionFrequency; }
      set { _actionFrequency = value; NotifyPropertyChanged(); }
    }

    private float _speedMultiplier;
    public float SpeedMultiplier
    {
      get { return _speedMultiplier; }
      set { _speedMultiplier = value; NotifyPropertyChanged(); }
    }

    private float _radiusLimit;
    public float RadiusLimit
    {
      get { return _radiusLimit; }
      set { _radiusLimit = value; NotifyPropertyChanged(); }
    }

    private float _wanderRadius;
    public float WanderRadius
    {
      get { return _wanderRadius; }
      set { _wanderRadius = value; NotifyPropertyChanged(); }
    }

    private float _teleportRadius;
    public float TeleportRadius
    {
      get { return _teleportRadius; }
      set { _teleportRadius = value; NotifyPropertyChanged(); }
    }

    private bool _hasBoxCol;
    public bool HasBoxCol
    {
      get { return _hasBoxCol; }
      set { _hasBoxCol = value; NotifyPropertyChanged(); }
    }

    private bool _boxColIsTrigger;
    public bool BoxColIsTrigger
    {
      get { return _boxColIsTrigger; }
      set { _boxColIsTrigger = value; NotifyPropertyChanged(); }
    }

    private Vector3 _boxColSizr = new Vector3();
    public Vector3 BoxColSize
    {
      get { return _boxColSizr; }
      set { _boxColSizr = value; NotifyPropertyChanged(); }
    }

    private Vector3 _boxColCenter = new Vector3();
    public Vector3 BoxColCenter
    {
      get { return _boxColCenter; }
      set { _boxColCenter = value; NotifyPropertyChanged(); }
    }

    private float _freezeTime;
    public float FreezeTime
    {
      get { return _freezeTime; }
      set { _freezeTime = value; NotifyPropertyChanged(); }
    }

    private Vector3 _freezeSize = new Vector3();
    public Vector3 FreezeSize
    {
      get { return _freezeSize; }
      set { _freezeSize = value; NotifyPropertyChanged(); }
    }

    private Vector3 _freezeOffset = new Vector3();
    public Vector3 FreezeOffset
    {
      get { return _freezeOffset; }
      set { _freezeOffset = value; NotifyPropertyChanged(); }
    }

    private int _eventId;
    public int EventId
    {
      get { return _eventId; }
      set { _eventId = value; NotifyPropertyChanged(); }
    }

    private int _requiresLength;
    public int RequiresLength
    {
      get { return _requiresLength; }
      set { _requiresLength = value; NotifyPropertyChanged(); }
    }

    private IndexedElement<int>[] _requires = new IndexedElement<int>[10];
    public IndexedElement<int>[] Requires
    {
      get { return _requires; }
      set { _requires = value; NotifyPropertyChanged(); }
    }

    private int _limitLength;
    public int LimitLength
    {
      get { return _limitLength; }
      set { _limitLength = value; NotifyPropertyChanged(); }
    }

    private IndexedElement<int>[] _limit = new IndexedElement<int>[10];
    public IndexedElement<int>[] Limit
    {
      get { return _limit; }
      set { _limit = value; NotifyPropertyChanged(); }
    }

    private int _dataLenght;
    public int DataLength
    {
      get { return _dataLenght; }
      set { _dataLenght = value; NotifyPropertyChanged(); }
    }

    private IndexedElement<int>[] _data = new IndexedElement<int>[10];
    public IndexedElement<int>[] Data
    {
      get { return _data; }
      set { _data = value; NotifyPropertyChanged(); }
    }

    private int _vectorDataLength;
    public int VectorDataLength
    {
      get { return _vectorDataLength; }
      set { _vectorDataLength = value; NotifyPropertyChanged(); }
    }

    private IndexedElement<Vector3>[] _vectorData = new IndexedElement<Vector3>[10];
    public IndexedElement<Vector3>[] VectorData
    {
      get { return _vectorData; }
      set { _vectorData = value; NotifyPropertyChanged(); }
    }

    private int _dialoguesLength;
    public int DialoguesLength
    {
      get { return _dialoguesLength; }
      set { _dialoguesLength = value; NotifyPropertyChanged(); }
    }

    private IndexedElement<Vector3>[] _dialogues = new IndexedElement<Vector3>[20];
    public IndexedElement<Vector3>[] Dialogues
    {
      get { return _dialogues; }
      set { _dialogues = value; NotifyPropertyChanged(); }
    }

    private Vector3 _eulerAngles = new Vector3();
    public Vector3 EulerAngles
    {
      get { return _eulerAngles; }
      set { _eulerAngles = value; NotifyPropertyChanged(); }
    }

    private int _battleIdsLength;
    public int BattleIdsLength
    {
      get { return _battleIdsLength; }
      set { _battleIdsLength = value; NotifyPropertyChanged(); }
    }

    private IndexedElement<int>[] _battleIds = new IndexedElement<int>[4];
    public IndexedElement<int>[] BattleIds
    {
      get { return _battleIds; }
      set { _battleIds = value; NotifyPropertyChanged(); }
    }

    private Color _tagColor = new Color();
    public Color TagColor
    {
      get { return _tagColor; }
      set { _tagColor = value; NotifyPropertyChanged(); }
    }

    private Vector3 _emoticonOffset = new Vector3();
    public Vector3 EmoticonOffset
    {
      get { return _emoticonOffset; }
      set { _emoticonOffset = value; NotifyPropertyChanged(); }
    }

    private int _insideId;
    public int InsideId
    {
      get { return _insideId; }
      set { _insideId = value; NotifyPropertyChanged(); }
    }

    private IndexedElement<Vector2Int>[] _emoticonFlag = new IndexedElement<Vector2Int>[10];
    public IndexedElement<Vector2Int>[] EmoticonFlag
    {
      get { return _emoticonFlag; }
      set { _emoticonFlag = value; NotifyPropertyChanged(); }
    }

    private int _tattleId;
    public int TattleId
    {
      get { return _tattleId; }
      set { _tattleId = value; NotifyPropertyChanged(); }
    }

    private int _regionalFlag;
    public int RegionalFlag
    {
      get { return _regionalFlag; }
      set { _regionalFlag = value; NotifyPropertyChanged(); }
    }

    private float _initialHeight;
    public float InitialHeight
    {
      get { return _initialHeight; }
      set { _initialHeight = value; NotifyPropertyChanged(); }
    }

    private float _bobRange;
    public float BobRange
    {
      get { return _bobRange; }
      set { _bobRange = value; NotifyPropertyChanged(); }
    }

    private float _bobSpeed;
    public float BobSpeed
    {
      get { return _bobSpeed; }
      set { _bobSpeed = value; NotifyPropertyChanged(); }
    }

    private int _activationFlag;
    public int ActivationFlag
    {
      get { return _activationFlag; }
      set { _activationFlag = value; NotifyPropertyChanged(); }
    }

    private bool _returnToHeight;
    public bool ReturnToHeight
    {
      get { return _returnToHeight; }
      set { _returnToHeight = value; NotifyPropertyChanged(); }
    }

    public Entity()
    {
      for (int i = 0; i < Limit.Length; i++)
      {
        Limit[i] = new IndexedElement<int>();
        Limit[i].Index = i;
        Limit[i].Value = 0;
      }
      for (int i = 0; i < Requires.Length; i++)
      {
        Requires[i] = new IndexedElement<int>();
        Requires[i].Index = i;
        Requires[i].Value = 0;
      }
      for (int i = 0; i < VectorData.Length; i++)
      {
        VectorData[i] = new IndexedElement<Vector3>();
        VectorData[i].Index = i;
        VectorData[i].Value = new Vector3();
        VectorData[i].Value.x = 0f;
        VectorData[i].Value.y = 0f;
        VectorData[i].Value.z = 0f;
      }
      for (int i = 0; i < Dialogues.Length; i++)
      {
        Dialogues[i] = new IndexedElement<Vector3>();
        Dialogues[i].Index = i;
        Dialogues[i].Value = new Vector3();
        Dialogues[i].Value.x = 0f;
        Dialogues[i].Value.y = 0f;
        Dialogues[i].Value.z = 0f;
      }
      for (int i = 0; i < Data.Length; i++)
      {
        Data[i] = new IndexedElement<int>();
        Data[i].Index = i;
        Data[i].Value = 0;
      }
      for (int i = 0; i < BattleIds.Length; i++)
      {
        BattleIds[i] = new IndexedElement<int>();
        BattleIds[i].Index = i;
        BattleIds[i].Value = 0;
      }
      for (int i = 0; i < EmoticonFlag.Length; i++)
      {
        EmoticonFlag[i] = new IndexedElement<Vector2Int>();
        EmoticonFlag[i].Index = i;
        EmoticonFlag[i].Value = new Vector2Int();
        EmoticonFlag[i].Value.x = 0;
        EmoticonFlag[i].Value.y = 0;
      }
      Behaviors[0] = ActionBehaviors.UNDEFINED;
      Behaviors[1] = ActionBehaviors.UNDEFINED;
    }

    public string EncodeToEntityLine()
    {
      StringBuilder sb = new StringBuilder();

      sb.Append(EntityType);
      sb.Append(CommonUtils.FieldSeparator);
      sb.Append(ObjectType);
      sb.Append(CommonUtils.FieldSeparator);
      sb.Append(Behaviors[0]);
      sb.Append(CommonUtils.FieldSeparator);
      sb.Append(Behaviors[1]);
      sb.Append(CommonUtils.FieldSeparator);
      sb.Append(InteractType);
      sb.Append(CommonUtils.FieldSeparator);
      sb.Append(DestroyType);
      sb.Append(CommonUtils.FieldSeparator);
      sb.Append(StartPos.x);
      sb.Append(CommonUtils.FieldSeparator);
      sb.Append(StartPos.y);
      sb.Append(CommonUtils.FieldSeparator);
      sb.Append(StartPos.z);
      sb.Append(CommonUtils.FieldSeparator);
      sb.Append(AnimId);
      sb.Append(CommonUtils.FieldSeparator);
      sb.Append(Flip);
      sb.Append(CommonUtils.FieldSeparator);
      sb.Append(CcolHeight);
      sb.Append(CommonUtils.FieldSeparator);
      sb.Append(CcolRadius);
      sb.Append(CommonUtils.FieldSeparator);
      sb.Append(Radius);
      sb.Append(CommonUtils.FieldSeparator);
      sb.Append(Timer);
      sb.Append(CommonUtils.FieldSeparator);
      sb.Append(Speed);
      sb.Append(CommonUtils.FieldSeparator);
      sb.Append(ActionFrequency[0]);
      sb.Append(CommonUtils.FieldSeparator);
      sb.Append(ActionFrequency[1]);
      sb.Append(CommonUtils.FieldSeparator);
      sb.Append(SpeedMultiplier);
      sb.Append(CommonUtils.FieldSeparator);
      sb.Append(RadiusLimit);
      sb.Append(CommonUtils.FieldSeparator);
      sb.Append(WanderRadius);
      sb.Append(CommonUtils.FieldSeparator);
      sb.Append(TeleportRadius);
      sb.Append(CommonUtils.FieldSeparator);
      sb.Append(HasBoxCol);
      sb.Append(CommonUtils.FieldSeparator);
      sb.Append(BoxColIsTrigger);
      sb.Append(CommonUtils.FieldSeparator);
      sb.Append(BoxColSize.x);
      sb.Append(CommonUtils.FieldSeparator);
      sb.Append(BoxColSize.y);
      sb.Append(CommonUtils.FieldSeparator);
      sb.Append(BoxColSize.z);
      sb.Append(CommonUtils.FieldSeparator);
      sb.Append(BoxColCenter.x);
      sb.Append(CommonUtils.FieldSeparator);
      sb.Append(BoxColCenter.y);
      sb.Append(CommonUtils.FieldSeparator);
      sb.Append(BoxColCenter.z);
      sb.Append(CommonUtils.FieldSeparator);
      sb.Append(FreezeTime);
      sb.Append(CommonUtils.FieldSeparator);
      sb.Append(FreezeSize.x);
      sb.Append(CommonUtils.FieldSeparator);
      sb.Append(FreezeSize.y);
      sb.Append(CommonUtils.FieldSeparator);
      sb.Append(FreezeSize.z);
      sb.Append(CommonUtils.FieldSeparator);
      sb.Append(FreezeOffset.x);
      sb.Append(CommonUtils.FieldSeparator);
      sb.Append(FreezeOffset.y);
      sb.Append(CommonUtils.FieldSeparator);
      sb.Append(FreezeOffset.z);
      sb.Append(CommonUtils.FieldSeparator);
      sb.Append(EventId);
      sb.Append(CommonUtils.FieldSeparator);
      sb.Append(RequiresLength);
      sb.Append(CommonUtils.FieldSeparator);
      for (int i = 0; i < Requires.Length; i++)
      {
        sb.Append(Requires[i].Value);
        sb.Append(CommonUtils.FieldSeparator);
      }
      sb.Append(LimitLength);
      sb.Append(CommonUtils.FieldSeparator);
      for (int i = 0; i < Limit.Length; i++)
      {
        sb.Append(Limit[i].Value);
        sb.Append(CommonUtils.FieldSeparator);
      }
      sb.Append(DataLength);
      sb.Append(CommonUtils.FieldSeparator);
      for (int i = 0; i < Data.Length; i++)
      {
        sb.Append(Data[i].Value);
        sb.Append(CommonUtils.FieldSeparator);
      }
      sb.Append(VectorDataLength);
      sb.Append(CommonUtils.FieldSeparator);
      for (int i = 0; i < VectorData.Length; i++)
      {
        sb.Append(VectorData[i].Value.x);
        sb.Append(CommonUtils.FieldSeparator);
        sb.Append(VectorData[i].Value.y);
        sb.Append(CommonUtils.FieldSeparator);
        sb.Append(VectorData[i].Value.z);
        sb.Append(CommonUtils.FieldSeparator);
      }
      sb.Append(DialoguesLength);
      sb.Append(CommonUtils.FieldSeparator);
      for (int i = 0; i < Dialogues.Length; i++)
      {
        sb.Append(Dialogues[i].Value.x);
        sb.Append(CommonUtils.FieldSeparator);
        sb.Append(Dialogues[i].Value.y);
        sb.Append(CommonUtils.FieldSeparator);
        sb.Append(Dialogues[i].Value.z);
        sb.Append(CommonUtils.FieldSeparator);
      }
      sb.Append(EulerAngles.x);
      sb.Append(CommonUtils.FieldSeparator);
      sb.Append(EulerAngles.y);
      sb.Append(CommonUtils.FieldSeparator);
      sb.Append(EulerAngles.z);
      sb.Append(CommonUtils.FieldSeparator);
      sb.Append(BattleIdsLength);
      sb.Append(CommonUtils.FieldSeparator);
      for (int i = 0; i < BattleIds.Length; i++)
      {
        sb.Append(BattleIds[i].Value);
        sb.Append(CommonUtils.FieldSeparator);
      }
      sb.Append(TagColor.R);
      sb.Append(CommonUtils.FieldSeparator);
      sb.Append(TagColor.G);
      sb.Append(CommonUtils.FieldSeparator);
      sb.Append(TagColor.B);
      sb.Append(CommonUtils.FieldSeparator);
      sb.Append(TagColor.A);
      sb.Append(CommonUtils.FieldSeparator);
      sb.Append(EmoticonOffset.x);
      sb.Append(CommonUtils.FieldSeparator);
      sb.Append(EmoticonOffset.y);
      sb.Append(CommonUtils.FieldSeparator);
      sb.Append(EmoticonOffset.z);
      sb.Append(CommonUtils.FieldSeparator);
      sb.Append(InsideId);
      sb.Append(CommonUtils.FieldSeparator);
      for (int i = 0; i < EmoticonFlag.Length; i++)
      {
        sb.Append(EmoticonFlag[i].Value.x);
        sb.Append(CommonUtils.ElementSeparator);
        sb.Append(EmoticonFlag[i].Value.y);
        sb.Append(CommonUtils.FieldSeparator);
      }
      sb.Append(TattleId);
      sb.Append(CommonUtils.FieldSeparator);
      sb.Append(RegionalFlag);
      sb.Append(CommonUtils.FieldSeparator);
      sb.Append(InitialHeight);
      sb.Append(CommonUtils.FieldSeparator);
      sb.Append(BobRange);
      sb.Append(CommonUtils.FieldSeparator);
      sb.Append(BobSpeed);
      sb.Append(CommonUtils.FieldSeparator);
      sb.Append(ActivationFlag);
      sb.Append(CommonUtils.FieldSeparator);
      sb.Append(ReturnToHeight);
      for (int i = 196; i < 278; i++)
      {
        sb.Append(CommonUtils.FieldSeparator);
        sb.Append(0);
      }

      return sb.ToString();
    }

    public void ParseFromEntityLine(string entityLine)
    {
      string[] data = entityLine.Split(CommonUtils.FieldSeparator);

      if (data.Length != 278)
        throw new Exception("The entity line is in an invalid format");

      EntityType = ParseEnum<NPCType>(data, 0, nameof(EntityType));
      ObjectType = ParseEnum<ObjectTypes>(data, 1, nameof(ObjectType));
      Behaviors[0] = ParseEnum<ActionBehaviors>(data, 2, nameof(Behaviors) + "[0}");
      Behaviors[1] = ParseEnum<ActionBehaviors>(data, 3, nameof(Behaviors) + "[1]");
      InteractType = ParseEnum<Interaction>(data, 4, nameof(InteractType));
      DestroyType = ParseEnum<DeathType>(data, 5, nameof(DestroyType));
      StartPos = ParseVector3(data, 6, nameof(StartPos));
      AnimId = ParseInt(data, 9, nameof(AnimId));
      Flip = ParseBool(data, 10, nameof(Flip));
      CcolHeight = ParseFloat(data, 11, nameof(CcolHeight));
      CcolRadius = ParseFloat(data, 12, nameof(CcolRadius));
      Radius = ParseFloat(data, 13, nameof(Radius));
      Timer = ParseFloat(data, 14, nameof(Timer));
      Speed = ParseFloat(data, 15, nameof(Speed));
      ActionFrequency[0] = ParseFloat(data, 16, nameof(ActionFrequency) + "[0]");
      ActionFrequency[1] = ParseFloat(data, 17, nameof(ActionFrequency) + "[1]");
      SpeedMultiplier = ParseFloat(data, 18, nameof(SpeedMultiplier));
      RadiusLimit = ParseFloat(data, 19, nameof(RadiusLimit));
      WanderRadius = ParseFloat(data, 20, nameof(WanderRadius));
      TeleportRadius = ParseFloat(data, 21, nameof(TeleportRadius));
      HasBoxCol = ParseBool(data, 22, nameof(HasBoxCol));
      BoxColIsTrigger = ParseBool(data, 23, nameof(BoxColIsTrigger));
      BoxColSize = ParseVector3(data, 24, nameof(BoxColSize));
      BoxColCenter = ParseVector3(data, 27, nameof(BoxColCenter));
      FreezeTime = ParseFloat(data, 30, nameof(FreezeTime));
      FreezeSize = ParseVector3(data, 31, nameof(FreezeSize));
      FreezeOffset = ParseVector3(data, 34, nameof(FreezeOffset));
      EventId = ParseInt(data, 37, nameof(EventId));
      RequiresLength = ParseInt(data, 38, nameof(RequiresLength));
      for (int i = 0; i < Requires.Length; i++)
        Requires[i].Value = ParseInt(data, 39 + i, nameof(Requires) + "[" + i + "]");
      LimitLength = ParseInt(data, 49, nameof(LimitLength));
      for (int i = 0; i < Limit.Length; i++)
        Limit[i].Value = ParseInt(data, 50 + i, nameof(Limit) + "[" + i + "]");
      DataLength = ParseInt(data, 60, nameof(DataLength));
      for (int i = 0; i < Limit.Length; i++)
        Data[i].Value = ParseInt(data, 61 + i, nameof(Data) + "[" + i + "]");
      VectorDataLength = ParseInt(data, 71, nameof(VectorDataLength));
      for (int i = 0; i < VectorData.Length; i++)
        VectorData[i].Value = ParseVector3(data, 72 + i * 3, nameof(VectorData) + "[" + i + "]");
      DialoguesLength = ParseInt(data, 102, nameof(DialoguesLength));
      for (int i = 0; i < Dialogues.Length; i++)
        Dialogues[i].Value = ParseVector3(data, 103 + i * 3, nameof(Dialogues) + "[" + i + "]");
      EulerAngles = ParseVector3(data, 163, nameof(EulerAngles));
      BattleIdsLength = ParseInt(data, 166, nameof(BattleIdsLength));
      for (int i = 0; i < BattleIds.Length; i++)
        BattleIds[i].Value = ParseInt(data, 167 + i, nameof(BattleIds) + "[" + i + "]");
      TagColor = ParseColor(data, 171, nameof(TagColor));
      EmoticonOffset = ParseVector3(data, 175, nameof(EmoticonOffset));
      InsideId = ParseInt(data, 178, nameof(InsideId));
      for (int i = 0; i < EmoticonFlag.Length; i++)
      {
        string[] vec2Data = data[179 + i].Split(CommonUtils.ElementSeparator);
        EmoticonFlag[i].Value = ParseVector2Int(vec2Data, 0, nameof(EmoticonFlag) + "[" + i + "]");
      }
      TattleId = ParseInt(data, 189, nameof(TattleId));
      RegionalFlag = ParseInt(data, 190, nameof(RegionalFlag));
      InitialHeight = ParseFloat(data, 191, nameof(InitialHeight));
      BobRange = ParseFloat(data, 192, nameof(BobRange));
      BobSpeed = ParseFloat(data, 193, nameof(BobSpeed));
      ActivationFlag = ParseInt(data, 194, nameof(ActivationFlag));
      if (data[195].Length == 1)
        ReturnToHeight = ParseInt(data, 195, nameof(ReturnToHeight)) == 1;
      else
        ReturnToHeight = ParseBool(data, 195, nameof(ReturnToHeight));
    }

    public void ResetToDefault()
    {
      EntityType = NPCType.NPC;
      ObjectType = ObjectTypes.None;
      Behaviors[0] = ActionBehaviors.None;
      Behaviors[1] = ActionBehaviors.None;
      InteractType = Interaction.None;
      DestroyType = DeathType.None;
      StartPos.x = 0f;
      StartPos.y = 0f;
      StartPos.z = 0f;
      AnimId = 0;
      Flip = false;
      CcolHeight = 0f;
      CcolRadius = 0f;
      Radius = 0f;
      Timer = 0f;
      Speed = 0f;
      ActionFrequency[0] = 0f;
      ActionFrequency[1] = 0f;
      SpeedMultiplier = 0f;
      RadiusLimit = 0f;
      WanderRadius = 0f;
      TeleportRadius = 0f;
      HasBoxCol = false;
      BoxColIsTrigger = false;
      BoxColSize.x = 0f;
      BoxColSize.y = 0f;
      BoxColSize.z = 0f;
      BoxColCenter.x = 0f;
      BoxColCenter.y = 0f;
      BoxColCenter.z = 0f;
      FreezeTime = 0f;
      FreezeSize.x = 0f;
      FreezeSize.y = 0f;
      FreezeSize.z = 0f;
      FreezeOffset.x = 0f;
      FreezeOffset.y = 0f;
      FreezeOffset.z = 0f;
      EventId = 0;
      RequiresLength = 0;
      for (int i = 0; i < Requires.Length; i++)
        Requires[i].Value = 0;
      LimitLength = 0;
      for (int i = 0; i < Limit.Length; i++)
        Limit[i].Value = 0;
      DataLength = 0;
      for (int i = 0; i < Limit.Length; i++)
        Data[i].Value = 0;
      VectorDataLength = 0;
      for (int i = 0; i < VectorData.Length; i++)
      {
        VectorData[i].Value.x = 0f;
        VectorData[i].Value.y = 0f;
        VectorData[i].Value.z = 0f;
      }
      DialoguesLength = 0;
      for (int i = 0; i < Dialogues.Length; i++)
      {
        Dialogues[i].Value.x = 0f;
        Dialogues[i].Value.y = 0f;
        Dialogues[i].Value.z = 0f;
      }
      EulerAngles.x = 0f;
      EulerAngles.y = 0f;
      EulerAngles.z = 0f;
      BattleIdsLength = 0;
      for (int i = 0; i < BattleIds.Length; i++)
        BattleIds[i].Value = 0;
      TagColor = default(Color);
      EmoticonOffset.x = 0f;
      EmoticonOffset.y = 0f;
      EmoticonOffset.z = 0f;
      InsideId = 0;
      for (int i = 0; i < EmoticonFlag.Length; i++)
      {
        EmoticonFlag[i].Value.x = 0;
        EmoticonFlag[i].Value.y = 0;
      }
      TattleId = 0;
      RegionalFlag = 0;
      InitialHeight = 0f;
      BobRange = 0f;
      BobSpeed = 0f;
      ActivationFlag = 0;
      ReturnToHeight = false;
    }

    private T ParseEnum<T>(string[] data, int fieldIndex, string enumName) where T : struct, Enum
    {
      object enumOut;
      if (!Enum.TryParse(typeof(T), data[fieldIndex], true, out enumOut))
        throw new Exception(enumName + " failed to parse");
      return (T)enumOut;
    }

    private Vector2Int ParseVector2Int(string[] data, int fieldIndex, string nameVec)
    {
      int intOut = 0;
      Vector2Int vec = new Vector2Int();
      if (!int.TryParse(data[fieldIndex], out intOut))
        throw new Exception(nameVec + "." + nameof(Vector2Int.x) + " failed to parse");
      vec.x = intOut;
      if (!int.TryParse(data[fieldIndex + 1], out intOut))
        throw new Exception(nameVec + "." + nameof(Vector2Int.y) + " failed to parse");
      vec.y = intOut;
      return vec;
    }

    private Vector3 ParseVector3(string[] data, int fieldIndex, string nameVec)
    {
      float floatOut = 0;
      Vector3 vec = new Vector3();
      if (!float.TryParse(data[fieldIndex], NumberStyles.Float, NumberFormatInfo.InvariantInfo, out floatOut))
        throw new Exception(nameVec + "." + nameof(Vector3.x) + " failed to parse");
      vec.x = floatOut;
      if (!float.TryParse(data[fieldIndex + 1], NumberStyles.Float, NumberFormatInfo.InvariantInfo, out floatOut))
        throw new Exception(nameVec + "." + nameof(Vector3.y) + " failed to parse");
      vec.y = floatOut;
      if (!float.TryParse(data[fieldIndex + 2], NumberStyles.Float, NumberFormatInfo.InvariantInfo, out floatOut))
        throw new Exception(nameVec + "." + nameof(Vector3.z) + " failed to parse");
      vec.z = floatOut;
      return vec;
    }

    private Color ParseColor(string[] data, int fieldIndex, string nameColor)
    {
      float floatOut = 0;
      float r, g, b, a = 0f;
      if (!float.TryParse(data[fieldIndex], NumberStyles.Float, NumberFormatInfo.InvariantInfo, out floatOut))
        throw new Exception(nameColor + "." + nameof(Color.R) + " failed to parse");
      r = floatOut;
      if (!float.TryParse(data[fieldIndex + 1], NumberStyles.Float, NumberFormatInfo.InvariantInfo, out floatOut))
        throw new Exception(nameColor + "." + nameof(Color.G) + " failed to parse");
      g = floatOut;
      if (!float.TryParse(data[fieldIndex + 2], NumberStyles.Float, NumberFormatInfo.InvariantInfo, out floatOut))
        throw new Exception(nameColor + "." + nameof(Color.B) + " failed to parse");
      b = floatOut;
      if (!float.TryParse(data[fieldIndex + 2], NumberStyles.Float, NumberFormatInfo.InvariantInfo, out floatOut))
        throw new Exception(nameColor + "." + nameof(Color.A) + " failed to parse");
      a = floatOut;
      return Color.FromArgb((byte)a, (byte)r, (byte)g, (byte)b);
    }

    private int ParseInt(string[] data, int fieldIndex, string nameInt)
    {
      int intOut = 0;
      if (!int.TryParse(data[fieldIndex], out intOut))
        throw new Exception(nameInt + " failed to parse");
      return intOut;
    }

    private float ParseFloat(string[] data, int fieldIndex, string nameFloat)
    {
      float floatOut = 0;
      if (!float.TryParse(data[fieldIndex], out floatOut))
        throw new Exception(nameFloat + " failed to parse");
      return floatOut;
    }

    private bool ParseBool(string[] data, int fieldIndex, string nameBool)
    {
      bool boolOut = false;
      if (!bool.TryParse(data[fieldIndex], out boolOut))
        throw new Exception(nameBool + " failed to parse");
      return boolOut;
    }

    public event PropertyChangedEventHandler? PropertyChanged;
    private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
    {
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
