using PureMVC.Patterns;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestProxy : Proxy {
    public new const string NAME = "TestProxy";
    private string touchStr ="";
    public TestProxy(string proxyName, object data = null) : base(proxyName,data)
    {
    }

    public void ChangeTouchString(string str)
    {
        touchStr = str;
        SendNotification(GameEvent.STARTUP, str);
    }
}
