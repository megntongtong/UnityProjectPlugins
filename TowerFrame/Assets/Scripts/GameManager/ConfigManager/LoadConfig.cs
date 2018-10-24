using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Runtime.Serialization;
using Stars;
using System;
using System.Reflection;


public class LoadConfig
{
    Type configType = null;
    public LoadConfig(Type _type)
    {
        configType = _type;
    }

    public void load()
    {
        TextAsset info = Resources.Load<TextAsset>(@"Config\Data\" + configType.ToString()) ;
        DataCallBackHandler(info);
    }

    void DataCallBackHandler(TextAsset info)
    {
        if (info == null)
        {
            Debug.LogError("can not found this table:" + configType);
            return;
        }
        TextAsset textAsset = info as TextAsset;
        if (textAsset == null)
        {
            Debug.LogError("can not found this table:" + configType);
            return;
        }

        IFormatter formatter = new BinaryFormatter();
        formatter.Binder = new UBinder();
        MemoryStream stream = new MemoryStream(textAsset.bytes);
        try
        {
            object[] dataArr = formatter.Deserialize(stream) as object[];
            IConfig[] iConfigArr = Array.ConvertAll<object, IConfig>(dataArr, delegate (object s) { return s as IConfig; });
            ConfigDataManager.addConfigData(configType, iConfigArr);
        }
        catch (Exception e)
        {
            Debug.Log(e.Message);
        }
        stream.Close();
    }

}

public class UBinder : SerializationBinder
{
    public override Type BindToType(string assemblyName, string typeName)
    {
        Assembly ass = Assembly.GetExecutingAssembly();
        return ass.GetType(typeName);
    }
}


