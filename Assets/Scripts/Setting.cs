using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Setting
{
    [SerializeField]
    private ViewPrefabs m_views = null;

    public ViewPrefabs Views => m_views;

    [Serializable]
    public class ViewPrefabs
    {
        #region Fields

        [SerializeField]
        private GameObject m_confirmBoxView = null;

        #endregion

        #region Properties

        public GameObject ConfirmBoxView => m_confirmBoxView;

        #endregion
    }
}
