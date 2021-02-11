using System;
using Zenject;
using Object = UnityEngine.Object;

public abstract class Controller : IInitializable, IDisposable
{
    public virtual void Initialize()
    {
        Initialise();
    }

    public virtual void Dispose()
    {
        OnDestroy();
    }

    public abstract void Initialise();
    public abstract void OnDestroy();
}

public abstract class Controller<T> : Controller
    where T : View
{
    private event Action<Controller<T>> m_disposed = delegate { };

    public event Action<Controller<T>> Disposed
    {
        add { m_disposed += value; }
        remove { m_disposed -= value; }
    }

    [Inject]
    private T m_view = null;

    public T View { get { return m_view; } }

    public override void Dispose()
    {
        base.Dispose();

        Object.Destroy(View.gameObject);

        m_disposed.Invoke(this);
    }
}