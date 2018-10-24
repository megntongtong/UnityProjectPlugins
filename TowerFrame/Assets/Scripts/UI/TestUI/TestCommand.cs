using PureMVC.Interfaces;
using PureMVC.Patterns;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCommand : SimpleCommand {
    public override void Execute(INotification notification)
    {
        TestProxy proxy = Facade.RetrieveProxy(TestProxy.NAME) as TestProxy;
        proxy.ChangeTouchString((string)notification.Body);
        base.Execute(notification);
    }
}

public class TestTouchButtonCommand : SimpleCommand {
    public override void Execute(INotification notification)
    {
        TestProxy proxy = Facade.RetrieveProxy(TestProxy.NAME) as TestProxy;
        proxy.ChangeTouchString((string)notification.Body);
        base.Execute(notification);
    }
}