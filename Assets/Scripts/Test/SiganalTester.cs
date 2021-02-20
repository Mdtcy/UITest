using Sirenix.OdinInspector;
using UnityEngine;
using Zenject;

public class SiganalTester : MonoBehaviour
{

    [Inject]
    readonly SignalBus _signalBus;

    [Button]
    public void TestOpenConfirmBoxSignal()
    {
        Debug.Log("TestOpenConfirmBoxSignal");
        _signalBus.Fire<OpenConfirmBoxSignal>();
    }

    // [Button]
    // public void TestCommandSignal()
    // {
    //     Debug.Log("TestCommandSignal");
    //     m_testCommandSignal.Fire();
    // }

    [Button]
    public void TestOpenTestTabViewSignal()
    {
        Debug.Log("TestOpenTestTabViewSignal");
        _signalBus.Fire<OpenTestTabViewSignal>();
    }
}

// public class TestCommand : Command
// {
//     protected override void Execute()
//     {
//         Debug.Log("Execute TestCommand");
//     }
// }
//
// public class TestCommandSignal : Signal { }
