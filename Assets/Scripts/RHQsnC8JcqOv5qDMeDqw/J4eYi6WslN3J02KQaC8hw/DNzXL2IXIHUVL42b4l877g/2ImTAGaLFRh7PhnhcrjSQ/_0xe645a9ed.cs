using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0xe645a9ed : MonoBehaviour
{
    public GameObject OuterBackground;
    public Ease Ease = Ease.OutSine;
    public void _0x60305c4c()
    {
        this._0xd2f14f1e();
        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.DOScale(0f, this.ScaleDuration).SetEase(this.Ease).OnComplete(() =>
        {
            this.Content.SetActive(false);
        });
    }

    public bool IsScaledDownOnAwake = true;
    private void _0x659728b0()
    {
        if (this.OuterBackground != null)
        {
            Image _0xe2ec9286 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0xe2ec9286, true);
            _0xe2ec9286.DOFade(1f, 0f);
        }
    }

    public TMP_Text MainText;
    public GameObject Content;
    public void _0xe739e643()
    {
        this._0x659728b0();
        this.Content.SetActive(true);
        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.localScale = Vector3.one;
        _0x64a8e136.Instance._0x84b99d82(_0x64a8e136.Instance.CurrentPanelIndex);
    }

    public void Show()
    {
        this._0x158f69f0();
        if (this.Content != null)
        {
            DOTween.Kill(this.Content.transform, true);
            this.Content.SetActive(true);
            this.Content.transform.DOScale(1f, this.ScaleDuration).SetEase(this.Ease).OnComplete(() =>
            {
                _0x64a8e136.Instance._0x84b99d82(_0x64a8e136.Instance.CurrentPanelIndex);
            });
        }
    }

    private void _0x31be6c01()
    {
        if (this.OuterBackground != null)
        {
            Image _0xa311b5a1 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0xa311b5a1, true);
            _0xa311b5a1.DOFade(0f, 0.01f);
        }

        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.DOScale(0f, 0.01f);
    }

    private void _0xd2f14f1e()
    {
        if (this.OuterBackground != null)
        {
            Image _0x1d5b31ed = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x1d5b31ed, true);
            _0x1d5b31ed.DOFade(0f, this.ScaleDuration);
        }
    }

    public float ScaleDuration = 0.4f;
    private void Awake()
    {
        this.Content.SetActive(true);
        if (this.OuterBackground != null)
            this.OuterBackground.gameObject.SetActive(true);
        if (this.IsScaledDownOnAwake)
            this._0x31be6c01();
    }

    public TMP_Text HeaderText;
    private void _0x158f69f0()
    {
        if (this.OuterBackground != null)
        {
            Image _0x9805a1c5 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x9805a1c5, true);
            _0x9805a1c5.DOFade(1f, this.ScaleDuration / 2f);
        }
    }

    private bool _0x2ea3b30e => this.Content.transform.localScale.x > 0.5f && this.Content.transform.localScale.y > 0.5f;
}