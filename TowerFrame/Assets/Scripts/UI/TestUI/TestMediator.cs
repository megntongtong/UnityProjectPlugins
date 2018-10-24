using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PureMVC.Interfaces;
using PureMVC.Patterns;

public class TestMediator : Mediator {
    public new const string NAME = "TestMediator";
   
    public TestMediator(string mediatorName, object viewComponent = null) : base(mediatorName, viewComponent)
    {
        UIEventListener.Get(testUI.mTouchButton).onClick += OnClickTouchButton;

    }
    public override IList<string> ListNotificationInterests()
    {
       List<string> receives = new List<string> { GameEvent.STARTUP };
        return receives.ToArray();
    }


    public override void OnRegister()
    {
       
        base.OnRegister();
    }
    TestUI testUI
    {
        get { return (TestUI)ViewComponent; }
    }

    int i = 0;
    private void OnClickTouchButton(GameObject go)
    {
        SendNotification(GameEvent.OnClickTouchButton, "嘻嘻嘻");
        ConfigDataManager.Instance.LoadConfigs();

        i++;
        if (i == 2)
        {
            EquipTable table =  ConfigDataManager.GetDataById(typeof(EquipTable), 1050001) as EquipTable;
            Debug.Log(table.iconPath);
        }
    }


    public override void HandleNotification(INotification notification)
    {
        switch (notification.Name)
        {
            case GameEvent.STARTUP:
                string mmpStr = (string)notification.Body;
                Debug.Log("mmp"+ mmpStr);
                testUI.mTouchText.text = "mmp";
                break;
        }
        base.HandleNotification(notification);
    }

}
