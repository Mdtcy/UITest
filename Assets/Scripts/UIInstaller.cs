/**
 * @author BoLuo
 * @email [ tktetb@163.com ]
 * @create date 18:50:03
 * @modify date 18:50:03
 * @desc []
 */

using UI;
using UnityEngine;
using Zenject;

namespace DefaultNamespace {
    public class UIInstaller : MonoInstaller
    {
        [SerializeField]
        private Setting m_setting;

        [SerializeField]
        private Transform m_mainCanvas;


        public override void InstallBindings()
        {
            BindUI();
            BindSignal();
        }

        private void BindUI()
        {
            Container.BindViewController<ConfirmBoxView, ConfirmBoxController>(m_setting.Views.ConfirmBoxView, m_mainCanvas);
            Container.BindViewController<TestTabView, TestTabViewController> (m_setting.Views.TestTabView, m_mainCanvas);
        }

        private void BindSignal()
        {
            SignalBusInstaller.Install(Container);

            Container.DeclareSignal<OpenConfirmBoxSignal>();
            Container.DeclareSignal<OpenTestTabViewSignal>();

            // Container.BindSignal<OpenConfirmBoxSignal>();
            //
            // // test
            // Container.BindCommand<TestCommandSignal, TestCommand>();
            // Container.BindSignal<OpenTestTabViewSignal>();
        }
    }
}