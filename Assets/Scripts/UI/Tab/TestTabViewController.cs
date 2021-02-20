using Doozy.Engine.UI;
using Zenject;

public class TestTabViewController : Controller<TestTabView>
{
    [Inject]
    readonly SignalBus _signalBus;

    public override void Initialise()
    {
        View.Hide();

        _signalBus.Subscribe<OpenTestTabViewSignal>(ShowTestTabView);

        View.AToggle.OnValueChanged.AddListener((value) => { OnToggleValueChanged(value, View.AView); });
        View.BToggle.OnValueChanged.AddListener((value) => { OnToggleValueChanged(value, View.BView); });
        View.CToggle.OnValueChanged.AddListener((value) => { OnToggleValueChanged(value, View.CView); });

        View.QuitButton.Button.onClick.AddListener(OnQuitButton);
    }

    public override void OnDestroy()
    {
        _signalBus.Unsubscribe<OpenTestTabViewSignal>(ShowTestTabView);
    }

    private void ShowTestTabView()
    {
        View.transform.SetAsLastSibling();
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
