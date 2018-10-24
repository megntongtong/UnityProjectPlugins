using PureMVC.Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestUI : UIBase {

    public GameObject mTouchButton;
    public UILabel mTouchText;
    private void Awake()
    {
        ApplicationFacade.Instance.RegisterCommand(GameEvent.OnClickTouchButton, typeof(TestCommand));
        ApplicationFacade.Instance.RegisterProxy(new TestProxy(TestProxy.NAME));
    }
    void Start () {
        curMediator = new TestMediator("TestMediator",this);
        Init();
	}
	
}
