using System.Collections;
using System.Collections.Generic;
using Doozy.Engine.UI;
using UnityEngine;

public class TestTabView : View
{
    [SerializeField]
    private UIView m_aView;

    [SerializeField]
    private UIView m_bView;

    [SerializeField]
    private UIView m_cView;

    [SerializeField]
    private UIToggle m_aToggle;

    [SerializeField]
    private UIToggle m_bToggle;

    [SerializeField]
    private UIToggle m_cToggle;

    [SerializeField]
    private UIButton m_quitButton;

    public UIView AView => m_aView;

    public UIView BView => m_bView;

    public  UIView CView => m_cView;

    public UIToggle AToggle => m_aToggle;

    public UIToggle BToggle => m_bToggle;

    public UIToggle CToggle => m_cToggle;

    public UIButton QuitButton => m_quitButton;
}
