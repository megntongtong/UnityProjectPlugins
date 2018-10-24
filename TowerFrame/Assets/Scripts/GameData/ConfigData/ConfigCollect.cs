using System;
[Serializable]
 /// <summary>配置表集合</summary>
public class ConfigCollect  {
 public static Type[] CONFIG_ARRAY = {
     typeof(AttributeTable),
     typeof(BgmlibraryTable),
     typeof(BgmTable),
     typeof(CoachTable),
     typeof(DrawPrizeTable),
     typeof(EquipTable),
     typeof(ZhCNTable)
    };
}
