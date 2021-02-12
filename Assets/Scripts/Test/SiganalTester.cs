using Sirenix.OdinInspector;
using UnityEngine;
using Zenject;

public class SiganalTester : MonoBehaviour
{
    [Inject]
    private OpenConfirmBoxSignal m_openConfirmBoxSignal;

    [Inject]
    private TestCommandSignal m_testCommandSignal;

    [Inject]
    private OpenTestTabViewSignal m_openTestTabViewSignal;

    [Button]
    public void TestOpenConfirmBoxSignal()
    {
        Debug.Log("TestOpenConfirmBoxSignal");
        m_openConfirmBoxSignal.Fire();
    }

    [Button]
    public void TestCommandSignal()
    {
        Debug.Log("TestCommandSignal");
        m_testCommandSignal.Fire();
    }

    [Button]
    public void TestOpenTestTabViewSignal()
    {
        Debug.Log("TestOpenTestTabViewSignal");
        m_openTestTabViewSignal.Fire();
    }
}

public class TestCommand : Command
{
    protected override void Execute()
    {
        Debug.Log("Execute TestCommand");
    }
}

public class TestCommandSignal : Signal { }
