using TMPro;
using UnityEngine;
using static _0x9cf3c3e3;

public class _0xd08c4c3c : MonoBehaviour
{
    public TMP_Text MoneyCountText;
    public void _0x9857e34e()
    {
        this.MoneyCountText.text = _0x931bebe5._0x98ad77d8.ToString();
    }

    private void Start()
    {
        if (this.MoneyCountText == null)
        {
            TMP_Text _0x00692283;
            if (this.gameObject.TryGetComponent(out _0x00692283))
                this.MoneyCountText = _0x00692283;
        }

        this._0x9857e34e();
    }
}