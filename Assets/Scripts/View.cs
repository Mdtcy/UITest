using Doozy.Engine.UI;
using UnityEngine;

public class View : MonoBehaviour
{
    [SerializeField]
    private UIView m_uiView;

    protected virtual GameObject GameObject => gameObject;

    protected UIView UIView => m_uiView;

    public virtual void Show()
    {
        m_uiView.Show();
        // GameObject.SetActive(true);
    }

    public virtual void Hide()
    {
        m_uiView.Hide();
        // GameObject.SetActive(false);
    }
}
