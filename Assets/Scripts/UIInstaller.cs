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

        public override void InstallBindings()
        {
            BindUI();
            BindSignal();
        }

        private void BindUI()
        {
            Container.BindViewController<ConfirmBoxView, ConfirmBoxController>(m_setting.Views.ConfirmBoxView);
            Container.BindViewController<TestTabView, TestTabViewController> (m_setting.Views.TestTabView);
        }

        private void BindSignal()
        {
            Container.BindSignal<OpenConfirmBoxSignal>();

            // test
            Container.BindCommand<TestCommandSignal, TestCommand>();
            Container.BindSignal<OpenTestTabViewSignal>();
        }
    }
}