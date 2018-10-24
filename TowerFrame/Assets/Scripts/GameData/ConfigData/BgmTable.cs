using System;
[Serializable]
public class BgmTable :IConfig{
   private uint _id;
   private string _scene;
   private string _bgm;
   private string _environmentalSoundEffect;
   private string _bgmID;
   public BgmTable (uint type_id,string type_scene,string type_bgm,string type_environmentalSoundEffect,string type_bgmID){
     _id =  (uint)type_id;
     _scene =  type_scene;
     _bgm =  type_bgm;
     _environmentalSoundEffect =  type_environmentalSoundEffect;
     _bgmID =  type_bgmID;
   }
  /// <summary>音乐ID ID</summary>
  public uint id{ get { return _id; }}
  /// <summary>对应场景  路径</summary>
  public string scene{ get { return _scene; }}
  /// <summary>bgm文件  路径</summary>
  public string bgm{ get { return _bgm; }}
  /// <summary>环境音效文件  路径</summary>
  public string environmentalSoundEffect{ get { return _environmentalSoundEffect; }}
  /// <summary>bgm随机ID  对应bgm库表中的id</summary>
  public string bgmID{ get { return _bgmID; }}
}
