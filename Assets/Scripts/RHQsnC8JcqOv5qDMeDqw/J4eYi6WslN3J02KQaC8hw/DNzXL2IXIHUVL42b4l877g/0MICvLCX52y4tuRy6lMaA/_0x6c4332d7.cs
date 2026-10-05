using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class _0x6c4332d7 : MonoBehaviour
{
    public int LoadSceneId;
    public bool IsLoadCurrentScene;
    public Button Button;
    private void Start()
    {
        if (this.IsLoadCurrentScene)
            this.Button.onClick.AddListener(() =>
            {
                _0xfa2aadfc.Instance.LoadSceneByIndex(SceneManager.GetActiveScene().buildIndex);
            });
        else
            this.Button.onClick.AddListener(() => _0xfa2aadfc.Instance.LoadSceneByIndex(this.LoadSceneId));
    }

    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }
}