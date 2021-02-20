/**
 * @author BoLuo
 * @email [ tktetb@163.com ]
 * @create date 15:05:24
 * @modify date 15:05:24
 * @desc []
 */

using UnityEngine;
using Zenject;

namespace UI
{
    public class ConfirmBoxController : Controller<ConfirmBoxView>
    {
        #region fields

        [Inject]
        readonly SignalBus _signalBus;

        #endregion

        #region public

        #endregion

        public override void Initialise()
        {
            View.Hide();

            // bind
            View.BtnConfirm.onClick.AddListener(OnConfirm);
            View.BtnCancel.onClick.AddListener(OnCancel);

            // signal
            _signalBus.Subscribe<OpenConfirmBoxSignal>(ShowConfirmBox);
        }

        public override void OnDestroy()
        {
            _signalBus.Unsubscribe<OpenConfirmBoxSignal>(ShowConfirmBox);

        }

        private void ShowConfirmBox()
        {
            View.transform.SetAsLastSibling();
            View.Show();
        }

        private void HideConfirmBox()
        {
            View.Hide();
        }

        private void OnConfirm()
        {
            Debug.Log("OnConfirm");
            View.TxtContent.text = "OnConfirm";
        }

        private void OnCancel()
        {
            HideConfirmBox();
            Debug.Log("OnCancel");
        }
    }
}