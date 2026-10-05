using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0xfe27f2a2 : MonoBehaviour
{
    public static void HideAllPops()
    {
        _0xc720b4f1.Instance._0xd1a75cd7();
    }

    public bool IsScaledDownOnAwake = true;
    public TMP_Text ContentMainText;
    public void Show()
    {
        this.Content.SetActive(true);
        if ((DOTween.TweensByTarget(this.Content.transform)?.Count ?? 0) > 0)
            DOTween.Kill(this.Content.transform, true);
        if (this.IsOnlyYScale)
            this.Content.transform.DOScaleY(1f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
            {
            });
        else
            this.Content.transform.DOScale(1f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
            {
            });
    }

    public Ease ease = Ease.OutSine;
    private void Awake()
    {
        this.Content.SetActive(true);
        if (this.IsScaledDownOnAwake)
            this._0x75bea057();
    }

    public void _0x39aac649()
    {
        if (this.Content.gameObject.activeSelf)
        {
            DOTween.Kill(this.Content.transform, true);
            if (this.IsOnlyYScale)
                this.Content.transform.DOScaleY(0f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
                {
                    this.Content.SetActive(false);
                });
            else
                this.Content.transform.DOScale(0f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
                {
                    this.Content.SetActive(false);
                });
        }
    }

    private bool _0x4b783abe => this.Content.transform.localScale.x > 0.5f && this.Content.transform.localScale.y > 0.5f;

    private void _0x75bea057()
    {
        DOTween.Kill(this.Content.transform, true);
        if (this.IsOnlyYScale)
            this.Content.transform.DOScaleY(0f, 0.01f);
        else
            this.Content.transform.DOScale(0f, 0.01f);
        this.Content.SetActive(false);
    }

    public Image ContentImage;
    private void Start()
    {
    // Content.SetActive(false);
    }

    public GameObject Content;
    public float scaleDuration = 0.4f;
    public bool IsOnlyYScale;
    public TMP_Text ContentAdditionalText;
    public TMP_Text ContentHeaderText;
}