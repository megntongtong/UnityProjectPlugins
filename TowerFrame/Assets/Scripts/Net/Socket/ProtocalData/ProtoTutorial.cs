//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: model/ProtoTutorial.proto
namespace com.sporger.server.proto.model
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"player_tutorial_info")]
  public partial class player_tutorial_info : global::ProtoBuf.IExtensible
  {
    public player_tutorial_info() {}
    
    private uint _tutorialStep;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"tutorialStep", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint tutorialStep
    {
      get { return _tutorialStep; }
      set { _tutorialStep = value; }
    }
    private readonly global::System.Collections.Generic.List<uint> _triggerTutorialSteps = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(2, Name=@"triggerTutorialSteps", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> triggerTutorialSteps
    {
      get { return _triggerTutorialSteps; }
    }
  
    private uint _careerPlotId;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"careerPlotId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint careerPlotId
    {
      get { return _careerPlotId; }
      set { _careerPlotId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"req_tutorial_info_out")]
  public partial class req_tutorial_info_out : global::ProtoBuf.IExtensible
  {
    public req_tutorial_info_out() {}
    
    private com.sporger.server.proto.model.player_tutorial_info _tutorialInfo;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"tutorialInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public com.sporger.server.proto.model.player_tutorial_info tutorialInfo
    {
      get { return _tutorialInfo; }
      set { _tutorialInfo = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"req_save_tutorial_in")]
  public partial class req_save_tutorial_in : global::ProtoBuf.IExtensible
  {
    public req_save_tutorial_in() {}
    
    private uint _tutorialStep;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"tutorialStep", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint tutorialStep
    {
      get { return _tutorialStep; }
      set { _tutorialStep = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"req_save_trigger_tutorial_in")]
  public partial class req_save_trigger_tutorial_in : global::ProtoBuf.IExtensible
  {
    public req_save_trigger_tutorial_in() {}
    
    private uint _triggerTutorialStep;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"triggerTutorialStep", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint triggerTutorialStep
    {
      get { return _triggerTutorialStep; }
      set { _triggerTutorialStep = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"req_save_career_plot_in")]
  public partial class req_save_career_plot_in : global::ProtoBuf.IExtensible
  {
    public req_save_career_plot_in() {}
    
    private uint _careerPlotId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"careerPlotId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint careerPlotId
    {
      get { return _careerPlotId; }
      set { _careerPlotId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}