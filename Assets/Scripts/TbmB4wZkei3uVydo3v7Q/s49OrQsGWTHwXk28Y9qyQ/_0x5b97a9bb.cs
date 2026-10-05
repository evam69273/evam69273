using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class _0x5b97a9bb : MonoBehaviour
{
    private List<string> _0x53dbc7b1 = new();
    private float _0xe525867c = 1.5f;
    private float _0x44a2b6d0;
    private void Update()
    {
        int _0x97bffa85 = 1;
        if (this._0x53dbc7b1.Count > 0)
        {
            string _0xb3eebd2f = this._0xe4985e0e.text;
            foreach (string _0x3e0fd8bf in this._0x53dbc7b1)
                while (_0xb3eebd2f.Contains(_0x3e0fd8bf))
                    _0xb3eebd2f = _0xb3eebd2f.Replace(_0x3e0fd8bf, "");
            _0x97bffa85 = _0xb3eebd2f.Length;
        }
        else
        {
            _0x97bffa85 = this._0xe4985e0e.text.Length;
        }

        float _0x5fa6010b = Mathf.Clamp(this._0x44a2b6d0 + this._0x53189d1b * _0x97bffa85, this._0xe525867c, this._0xfab098e6);
        if (!Mathf.Approximately(this._0xc001c7c8.aspectRatio, _0x5fa6010b))
            this._0xc001c7c8.aspectRatio = _0x5fa6010b;
    }

    private float _0xfab098e6 = 4;
    private AspectRatioFitter _0xc001c7c8;
    private TMP_Text _0xe4985e0e;
    private float _0x53189d1b = 0.6f;
}