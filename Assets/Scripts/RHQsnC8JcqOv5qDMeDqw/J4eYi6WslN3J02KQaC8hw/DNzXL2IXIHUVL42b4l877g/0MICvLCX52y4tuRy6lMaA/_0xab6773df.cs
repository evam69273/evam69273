using UnityEngine;
using UnityEngine.UI;

public class _0xab6773df : MonoBehaviour
{
    public Button Button;
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    private void Start()
    {
        this.Button.onClick.AddListener(() => _0xfa2aadfc.Instance._0xb6166d7b(this.IsPhysicsRunOnClick));
    }

    public bool IsPhysicsRunOnClick;
}