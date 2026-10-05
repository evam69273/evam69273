using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x55cbc114 : MonoBehaviour
{
    private Image _0x1d712ee0;
    private void _0x9c2e13b1()
    {
        if (this._0x1d712ee0.canvasRenderer.GetColor() != this._0x5f28cac5.canvasRenderer.GetColor())
            this._0x5f28cac5.canvasRenderer.SetColor(this._0x1d712ee0.canvasRenderer.GetColor());
    }

    private void Update()
    {
        this._0x9c2e13b1();
    }

    private TMP_Text _0x5f28cac5;
}