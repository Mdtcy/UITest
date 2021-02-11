using System;
using UnityEngine;
using Zenject;

public static class DiContainerExtensions
{
    public static void BindController<TController>(this DiContainer container)
        where TController : Controller
    {
        container.Bind<TController>().ToSingle();
        container.Bind<IInitializable>().ToSingle<TController>();
        container.Bind<IDisposable>().ToSingle<TController>();
    }

    public static void BindViewController<TView, TController>(this DiContainer container, GameObject viewPrefab)
        where TView : View
        where TController : Controller
    {
        container.Bind<TView>().ToSinglePrefab(viewPrefab);
        container.BindController<TController>();
    }

    public static void BindTransientViewController<TView, TController>(this DiContainer container, GameObject viewPrefab)
        where TView : View
        where TController : Controller
    {
        container.BindTransientViewController<TView, TController, TController>(viewPrefab);
    }

    public static void BindTransientViewController<TView, TController, TInjectTo>(this DiContainer container, GameObject viewPrefab)
        where TView : View
        where TController : Controller
    {
        container.Bind<TView>().ToTransientPrefab(viewPrefab).WhenInjectedInto<TInjectTo>();
        container.Bind<TController>().ToTransient();
    }

    public static void BindSignal<TSignal>(this DiContainer container)
        where TSignal : ISignal
    {
        container.Bind<TSignal>().ToSignal();
    }

    public static void BindCommand<TSignal, TCommand>(this DiContainer container)
        where TSignal : ISignal
        where TCommand : ICommand
    {
        container.Bind<TSignal>().ToCommand<TCommand>();
    }
}
