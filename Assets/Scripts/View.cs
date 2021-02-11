using UnityEngine;

public class View : MonoBehaviour
{
    protected virtual GameObject GameObject
    {
        get { return gameObject; }
    }
    
    public virtual void Show()
    {
        GameObject.SetActive(true);
    }

    public virtual void Hide()
    {
        GameObject.SetActive(false);
    }
}
