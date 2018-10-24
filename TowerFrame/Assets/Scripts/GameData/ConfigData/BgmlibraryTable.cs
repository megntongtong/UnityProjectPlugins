using System;
[Serializable]
public class BgmlibraryTable :IConfig{
   private uint _id;
   private string _bgm;
   public BgmlibraryTable (uint type_id,string type_bgm){
     _id =  (uint)type_id;
     _bgm =  type_bgm;
   }
  /// <summary>bgmID ID</summary>
  public uint id{ get { return _id; }}
  /// <summary>bgm文件  路径</summary>
  public string bgm{ get { return _bgm; }}
}
