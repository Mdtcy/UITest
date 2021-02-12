using System.Collections;
using System.Collections.Generic;
using Doozy.Engine.UI;
using UnityEngine;
using Zenject;

public class TestTabViewController : Controller<TestTabView>
{
    [Inject]
    private OpenTestTabViewSignal m_openTestTabViewSignal;
    public override void Initialise()
    {
        View.Hide();

        m_openTestTabViewSignal.AddListener(ShowTestTabView);

        View.AToggle.OnValueChanged.AddListener((value) => { OnToggleValueChanged(value, View.AView); });
        View.BToggle.OnValueChanged.AddListener((value) => { OnToggleValueChanged(value, View.BView); });
        View.CToggle.OnValueChanged.AddListener((value) => { OnToggleValueChanged(value, View.CView); });

        View.QuitButton.Button.onClick.AddListener(OnQuitButton);
    }

    public override void OnDestroy()
    {
        m_openTestTabViewSignal.RemoveListener(ShowTestTabView);
    }

    private void ShowTestTabView()
    {
        View.Show();
    }

    private void OnQuitButton()
    {
        View.Hide();
    }
    private void OnToggleValueChanged(bool value, UIView uiView)
    {
        if (value)
        {
            uiView.Show();
        }
        else
        {
            uiView.Hide();
        }
    }

}
