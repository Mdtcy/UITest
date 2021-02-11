/**
 * @author BoLuo
 * @email [ tktetb@163.com ]
 * @create date 19:38:40
 * @modify date 19:38:40
 * @desc []
 */

using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class ConfirmBoxView : View
    {
        #region fields

        [SerializeField]
        private Text txtContent;

        [SerializeField]
        private Button btnConfirm;

        [SerializeField]
        private Button btnCancel;

        #endregion

        #region properties

        public Text TxtContent => txtContent;

        public Button BtnConfirm => btnConfirm;

        public Button BtnCancel => btnCancel;

        #endregion

    }
}