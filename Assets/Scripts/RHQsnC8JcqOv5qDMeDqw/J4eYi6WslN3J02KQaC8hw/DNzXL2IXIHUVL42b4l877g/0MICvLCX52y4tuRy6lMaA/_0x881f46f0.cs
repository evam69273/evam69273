using UnityEngine;
using UnityEngine.UI;

public class _0x881f46f0 : MonoBehaviour
{
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    private void Start()
    {
        if (this.IsShowLastPop)
            this.Button.onClick.AddListener(() =>
            {
                _0xc720b4f1.Instance._0xf178ac39();
            });
        else if (this.IsHideAllPops)
            this.Button.onClick.AddListener(() => _0xc720b4f1.Instance._0xd1a75cd7());
        else
            this.Button.onClick.AddListener(() => _0xc720b4f1.Instance._0x2568b066(this.PopToShowIndex));
    }

    public int PopToShowIndex;
    public Button Button;
    public bool IsHideAllPops;
    public bool IsShowLastPop;
}