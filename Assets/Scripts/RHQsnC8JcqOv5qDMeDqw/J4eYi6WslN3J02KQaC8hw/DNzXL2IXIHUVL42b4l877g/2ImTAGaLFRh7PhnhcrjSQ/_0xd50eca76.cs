using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class _0xd50eca76 : MonoBehaviour
{
    public void _0x993f77da()
    {
        {
#if B_LOGS
            {
                Debug.Log($"[Test] Animate Force");
            }
#endif
        }

        this._0x14c8802c?.Kill();
        if (AnimationSlider != null)
            this.AnimationSlider.value = 1f;
        _0x316c959c = false;
    }

    public void _0xf88b8831()
    {
        this._0x14c8802c?.Kill();
        this.AnimationSlider.value = _0x316c959c ? this.SecondPassSliderValue : 0.05f;
    }

    public static _0xd50eca76 Instance;
    private void _0xfc098663()
    {
        this.AnimationSlider.value = 0.05f;
        _0x316c959c = !_0x316c959c;
        this._0x14c8802c = DOTween.Sequence().Append(DOTween.To(() => this.AnimationSlider.value, _0x32f6e454 => this.AnimationSlider.value = _0x32f6e454, 1f, this.FirstAnimationTime)).SetEase(Ease.Linear).OnComplete(() =>
        {
            _0xf9f92de4._0x3b2e790c?._0x336524d3();
        });
    }

    public float FirstAnimationTime = 10.0f;
    public float DefaultAnimationTime = 0.4f;
    private static bool _0x316c959c = false;
    public float SecondPassSliderValue = 0.5f;
    public GameObject Error;
    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0xd50eca76>();
    }

    public GameObject Background;
    private void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == _0x9cf3c3e3._0xf290fefa.SCENE_0 && !_0x316c959c)
        {
            this._0xfc098663();
        }
        else
        {
            this._0x867cee0d();
        }
    }

    public void _0x4f88ef3c()
    {
        this._0x14c8802c?.Play();
    }

    public GameObject Content;
    public Slider AnimationSlider;
    public void _0x7b510003()
    {
        this._0x14c8802c?.Pause();
    }

    private Sequence _0x14c8802c;
    public void _0x867cee0d()
    {
        this._0xf88b8831();
        bool _0x7eba95c2 = _0x316c959c;
        this._0x14c8802c = DOTween.Sequence().Append(DOTween.To(() => this.AnimationSlider.value, _0x32f6e454 => this.AnimationSlider.value = _0x32f6e454, _0x7eba95c2 ? 1f : this.SecondPassSliderValue, this.DefaultAnimationTime)).SetEase(Ease.Linear);
        _0x316c959c = !_0x316c959c;
    }
}