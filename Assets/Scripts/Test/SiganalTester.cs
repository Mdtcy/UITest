using Sirenix.OdinInspector;
using UnityEngine;
using Zenject;

public class SiganalTester : MonoBehaviour
{
    [Inject]
    private OpenConfirmBoxSignal m_openConfirmBoxSignal;

    [Inject]
    private TestCommandSignal m_testCommandSignal;

    [Button]
    public void TestOpenConfirmBoxSignal()
    {
        m_openConfirmBoxSignal.Fire();
    }

    [Button]
    public void TestCommandSignal()
    {
        m_testCommandSignal.Fire();
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
