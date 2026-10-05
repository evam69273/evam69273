using UnityEngine;
using UnityEngine.UI;

public class _0xdb7f5397 : MonoBehaviour
{
    private void Start()
    {
        if (this._0x6498b6ca)
            this._0x2d87eec0.onClick.AddListener(() => _0x64a8e136.Instance._0x8d048634());
        else
            this._0x2d87eec0.onClick.AddListener(() => _0x64a8e136.Instance._0x193e969a(this._0x2e30f45e));
    }

    private bool _0x6498b6ca;
    private void Awake()
    {
        if (this._0x2d87eec0 == null)
            if (!this.TryGetComponent(out this._0x2d87eec0))
                this._0x2d87eec0 = this.GetComponentInChildren<Button>();
    }

    private int _0x2e30f45e;
    private Button _0x2d87eec0;
}