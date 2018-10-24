using PureMVC.Interfaces;
using PureMVC.Patterns;
using System.Collections.Generic;
using UnityEngine;

public class UIBase : MonoBehaviour {
    public int panelDepth = 1;
    protected Mediator curMediator;
    protected List<UIPanel> PanelList = new List<UIPanel>();
    public virtual void Init(params object[] data)
    {
        RigisterMediator(curMediator);
    }

    public virtual void OnUpdate()
    {

    }

    public virtual void Close()
    {
        if (null != curMediator)
            RomoveMediator(curMediator.MediatorName);
    }

    public virtual void DisPlay()
    {
        this.gameObject.SetActive(true);
    }

    public virtual void Hiding()
    {
        this.gameObject.SetActive(false);
    }

    public virtual void OnLoadEnd()
    {

    }

    /// <summary>
    /// 注册界面Mediator
    /// </summary>
    /// <param name="mediator"></param>
    protected void RigisterMediator(IMediator mediator)
    {
        if (null == mediator)
            return;
        ApplicationFacade.Instance.RegisterMediator(mediator);
    }

    /// <summary>
    /// 注销界面Mediator
    /// </summary>
    /// <param name="NAME"></param>
    protected void RomoveMediator(string NAME)
    {
        ApplicationFacade.Instance.RemoveMediator(NAME);
    }


    public virtual void FindPanel(GameObject obj)
    {
        for (int i = 0; i < obj.transform.childCount; i++)
        {
            UIPanel up = obj.transform.GetChild(i).GetComponent<UIPanel>();
            if (up != null)
            {
                PanelList.Add(up);
            }
            FindPanel(obj.transform.GetChild(i).gameObject);
        }
        for (int i = 0; i < PanelList.Count; i++)
        {
            PanelList[i].depth = panelDepth + i + 1;
        }
    }

}
