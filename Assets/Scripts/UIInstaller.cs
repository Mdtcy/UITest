/**
 * @author BoLuo
 * @email [ tktetb@163.com ]
 * @create date 18:50:03
 * @modify date 18:50:03
 * @desc []
 */

using UnityEngine;
using Zenject;

namespace DefaultNamespace {
    public class UIInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            BindUI();
        }

        private void BindUI()
        {

        }
    }
}