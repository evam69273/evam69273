using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The whole in-round HUD, built from this game's own objects: clock, three energy
/// pips, FLOW, CHAIN, the two turn buttons and the two corner buttons. Nothing here
/// reads or writes a template placeholder - the scene template's own timer, score
/// pill and corner slots are left untouched and unused.
/// </summary>
public sealed class _0xbddc72e7 : MonoBehaviour
{
    private TextMeshProUGUI _0x490ec829;
    private TextMeshProUGUI _0x72d9e010;
    [SerializeField]
    private Sprite _backIcon;
    [SerializeField]
    private Sprite _turnRightIcon;
    private RectTransform _0x9a41f3d6;
    private readonly Image[] _0xf06c8ecb = new Image[PipCount];
    public void _0x939e212c(bool _0x7b33574a)
    {
        if (this._0x9a41f3d6 != null)
            this._0x9a41f3d6.gameObject.SetActive(_0x7b33574a);
    }

    private const int PipCount = _0x5f9ac917.MaxEnergy;
    public void _0xb5573b62(int _0x2b63d33a)
    {
        if (this._0x490ec829 != null)
            this._0x490ec829.text = _0x5b1a305e._0x6edcfc47(new byte[5] { 5, 15, 12, 20, 99 }, 67) + _0x2b63d33a.ToString();
    }

    public void _0x8d3372a2(int _0x11957d2a)
    {
        for (int _0x253f9e3d = 0; _0x253f9e3d < this._0xf06c8ecb.Length; _0x253f9e3d++)
        {
            Image _0x192d00fd = this._0xf06c8ecb[_0x253f9e3d];
            if (_0x192d00fd == null)
                continue;
            bool _0xaa50dac2 = _0x253f9e3d < _0x11957d2a;
            _0x192d00fd.color = _0xaa50dac2 ? _0xbe57dfde.Gold : _0xbe57dfde.WithAlpha(_0xbe57dfde.Spent, 0.7f);
            _0x192d00fd.transform.localScale = _0xaa50dac2 ? Vector3.one : Vector3.one * 0.86f;
        }
    }

    private TextMeshProUGUI _0x93c65f91;
    public void _0xf9895f63(string _0xeb28890c)
    {
        if (this._0x72d9e010 != null)
            this._0x72d9e010.text = _0xeb28890c;
    }

    public void _0x309950c0(int _0x5a3b9524)
    {
        if (_0x5a3b9524 < 0 || _0x5a3b9524 >= this._0xf06c8ecb.Length || this._0xf06c8ecb[_0x5a3b9524] == null)
            return;
        Transform _0x5dc895ba = this._0xf06c8ecb[_0x5a3b9524].transform;
        DOTween.Kill(_0x5dc895ba, true);
        _0x5dc895ba.localScale = Vector3.one;
        _0x5dc895ba.DOPunchScale(Vector3.one * 0.25f, 0.28f, 6, 0.6f);
    }

    /// <summary>A short burst of feedback over the board: BLOCK, +1, -1, SEALED.</summary>
    public void _0x5ba7c4c7(string _0x0ff3063e, Color _0x38ef53f2)
    {
        if (this._0xd113cba4 == null)
            return;
        TextMeshProUGUI _0xfac65002 = this._0xd113cba4;
        if (this._0x142501b2 != null && this._0x142501b2.IsActive())
            this._0x142501b2.Kill();
        DOTween.Kill(_0xfac65002.rectTransform, true);
        _0xfac65002.text = _0x0ff3063e;
        _0xfac65002.color = _0x38ef53f2;
        _0xfac65002.alpha = 1f;
        _0xfac65002.rectTransform.localScale = Vector3.one * 0.8f;
        _0xfac65002.rectTransform.DOScale(1.05f, 0.22f).SetEase(Ease.OutBack);
        this._0x142501b2 = DOTween.To(() => _0xfac65002.alpha, _0x32f6e454 => _0xfac65002.alpha = _0x32f6e454, 0f, 0.85f).SetDelay(0.35f);
    }

    public void SetClock(float _0xa38015c9)
    {
        if (this._0x7a7a110d == null)
            return;
        this._0x7a7a110d.text = _0x5f9ac917.Clock(_0xa38015c9);
        bool _0x5ebc63b2 = _0xa38015c9 <= _0x5f9ac917.LastTenSeconds;
        if (_0x5ebc63b2 == this._0x19950977)
            return;
        this._0x19950977 = _0x5ebc63b2;
        this._0x7a7a110d.color = _0x5ebc63b2 ? _0xbe57dfde.Danger : _0xbe57dfde.Cream;
        if (this._0xa0e9e1ad != null && this._0xa0e9e1ad.IsActive())
            this._0xa0e9e1ad.Kill();
        DOTween.Kill(this._0x7a7a110d.rectTransform, true);
        this._0x7a7a110d.rectTransform.localScale = Vector3.one;
        if (_0x5ebc63b2)
            this._0xa0e9e1ad = this._0x7a7a110d.rectTransform.DOScale(1.06f, 0.5f).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo);
    }

    [SerializeField]
    private Sprite _turnLeftIcon;
    public void _0x7574155d(Transform _0xfda3e266, _0x5c719e88 _0xd33e0602)
    {
        this._0x9a41f3d6 = _0x07e13b60.Stretch(_0xfda3e266, _0x5b1a305e._0x6edcfc47(new byte[7] { 198, 236, 239, 247, 200, 245, 228 }, 128));
        // top bar -------------------------------------------------------------
        Image _0x39f30de1 = _0x07e13b60.Plate(this._0x9a41f3d6, _0x5b1a305e._0x6edcfc47(new byte[6] { 105, 82, 77, 127, 92, 79 }, 61), new Vector2(0.5f, 0.925f), new Vector2(1170f, 390f), _0xbe57dfde.WithAlpha(_0xbe57dfde.Surface, 0.9f), null);
        _0x07e13b60.Plate(_0x39f30de1.transform, _0x5b1a305e._0x6edcfc47(new byte[10] { 196, 255, 224, 210, 241, 226, 213, 244, 247, 245 }, 144), new Vector2(0.5f, 0f), new Vector2(1170f, 5f), _0xbe57dfde.WithAlpha(_0xbe57dfde.Violet, 0.85f), null);
        this._0x7a7a110d = _0x07e13b60.Label(this._0x9a41f3d6, _0x5b1a305e._0x6edcfc47(new byte[5] { 120, 87, 84, 88, 80 }, 59), _0x5f9ac917.Clock(_0x5f9ac917.RoundSeconds), new Vector2(0.5f, 0.963f), new Vector2(420f, 120f), 82f, _0xbe57dfde.Cream, TextAlignmentOptions.Center);
        // energy column: caption above the pips, so no icon gutter ever shares an
        // x band with a text column (and the pips stay readable at any width).
        _0x07e13b60.Label(this._0x9a41f3d6, _0x5b1a305e._0x6edcfc47(new byte[13] { 10, 33, 42, 61, 40, 54, 12, 46, 63, 59, 38, 32, 33 }, 79), _0x5b1a305e._0x6edcfc47(new byte[6] { 211, 216, 211, 196, 209, 207 }, 150), new Vector2(0.17f, 0.905f), new Vector2(260f, 52f), 34f, _0xbe57dfde.Muted, TextAlignmentOptions.Center);
        float _0xa756ff92 = 88f;
        float _0xbf30b6c3 = 16f;
        float _0x218e8a1b = PipCount * _0xa756ff92 + (PipCount - 1) * _0xbf30b6c3;
        RectTransform _0xffa20b7a = _0x07e13b60.Node(this._0x9a41f3d6, _0x5b1a305e._0x6edcfc47(new byte[9] { 122, 81, 90, 77, 88, 70, 109, 80, 72 }, 63), new Vector2(0.17f, 0.866f), new Vector2(_0x218e8a1b, _0xa756ff92));
        for (int _0xa23f7918 = 0; _0xa23f7918 < PipCount; _0xa23f7918++)
        {
            RectTransform _0x3acaca07 = _0x07e13b60.Node(_0xffa20b7a, _0x5b1a305e._0x6edcfc47(new byte[3] { 246, 207, 214 }, 166) + _0xa23f7918.ToString(), new Vector2(0.5f, 0.5f), new Vector2(_0xa756ff92, _0xa756ff92));
            _0x3acaca07.anchoredPosition = new Vector2(-_0x218e8a1b * 0.5f + _0xa756ff92 * 0.5f + _0xa23f7918 * (_0xa756ff92 + _0xbf30b6c3), 0f);
            Image _0x76b80a2a = _0x3acaca07.gameObject.AddComponent<Image>();
            _0x76b80a2a.sprite = this._pipSprite;
            _0x76b80a2a.preserveAspect = true;
            _0x76b80a2a.raycastTarget = false;
            _0x76b80a2a.color = _0xbe57dfde.Gold;
            this._0xf06c8ecb[_0xa23f7918] = _0x76b80a2a;
        }

        this._0x490ec829 = _0x07e13b60.Label(this._0x9a41f3d6, _0x5b1a305e._0x6edcfc47(new byte[9] { 196, 238, 237, 245, 212, 227, 238, 247, 231 }, 130), _0x5b1a305e._0x6edcfc47(new byte[6] { 49, 59, 56, 32, 87, 71 }, 119), new Vector2(0.80f, 0.905f), new Vector2(380f, 70f), 54f, _0xbe57dfde.Boon, TextAlignmentOptions.Right);
        this._0x93c65f91 = _0x07e13b60.Label(this._0x9a41f3d6, _0x5b1a305e._0x6edcfc47(new byte[10] { 61, 22, 31, 23, 16, 40, 31, 18, 11, 27 }, 126), _0x5b1a305e._0x6edcfc47(new byte[8] { 108, 103, 110, 102, 97, 15, 87, 31 }, 47), new Vector2(0.80f, 0.866f), new Vector2(380f, 56f), 38f, _0xbe57dfde.Gold, TextAlignmentOptions.Right);
        this._0x72d9e010 = _0x07e13b60.Label(this._0x9a41f3d6, _0x5b1a305e._0x6edcfc47(new byte[11] { 51, 17, 26, 27, 61, 31, 14, 10, 23, 17, 16 }, 126), _0x5f9ac917.ModeName(_0x6a3f9ee1._0xdb647cc0), new Vector2(0.5f, 0.882f), new Vector2(320f, 56f), 36f, _0xbe57dfde.Muted, TextAlignmentOptions.Center);
        // the standing control hint, above the buttons it talks about ----------
        _0x07e13b60.Label(this._0x9a41f3d6, _0x5b1a305e._0x6edcfc47(new byte[11] { 73, 101, 100, 126, 120, 101, 102, 66, 99, 100, 126 }, 10), _0x5b1a305e._0x6edcfc47(new byte[25] { 37, 48, 33, 81, 37, 36, 35, 63, 81, 37, 62, 81, 34, 33, 56, 63, 81, 37, 57, 52, 81, 35, 56, 63, 54 }, 113), new Vector2(0.5f, 0.235f), new Vector2(1060f, 70f), 36f, _0xbe57dfde.WithAlpha(_0xbe57dfde.Cream, 0.9f), TextAlignmentOptions.Center);
        // the two turn buttons -------------------------------------------------
        Button _0x0319f1ca = _0x07e13b60.IconCta(this._0x9a41f3d6, _0x5b1a305e._0x6edcfc47(new byte[8] { 192, 225, 230, 250, 216, 241, 242, 224 }, 148), _0x5b1a305e._0x6edcfc47(new byte[6] { 54, 55, 48, 44, 66, 46 }, 98), this._turnLeftIcon, new Vector2(0.275f, 0.115f), new Vector2(470f, 190f), _0xbe57dfde.Violet, _0xbe57dfde.Gold, _0xbe57dfde.Cream, 46f);
        _0x0319f1ca.onClick.AddListener(() => _0xd33e0602._0x171586f4());
        Button _0x12f2c652 = _0x07e13b60.IconCta(this._0x9a41f3d6, _0x5b1a305e._0x6edcfc47(new byte[9] { 204, 237, 234, 246, 202, 241, 255, 240, 236 }, 152), _0x5b1a305e._0x6edcfc47(new byte[6] { 76, 77, 74, 86, 56, 74 }, 24), this._turnRightIcon, new Vector2(0.725f, 0.115f), new Vector2(470f, 190f), _0xbe57dfde.Violet, _0xbe57dfde.Gold, _0xbe57dfde.Cream, 46f);
        _0x12f2c652.onClick.AddListener(() => _0xd33e0602._0x8425ea1f());
        // corner buttons last, so they win every tap ---------------------------
        Button _0x9a37708d = _0x07e13b60.SquareCta(this._0x9a41f3d6, _0x5b1a305e._0x6edcfc47(new byte[10] { 7, 36, 38, 46, 7, 48, 49, 49, 42, 43 }, 69), this._backIcon, new Vector2(0.085f, 0.962f), new Vector2(120f, 120f), _0xbe57dfde.WithAlpha(_0xbe57dfde.Violet, 0.92f), _0xbe57dfde.Cream);
        _0x9a37708d.onClick.AddListener(() => _0xd33e0602._0x113ee211());
        Button _0x8e53984a = _0x07e13b60.SquareCta(this._0x9a41f3d6, _0x5b1a305e._0x6edcfc47(new byte[11] { 244, 197, 209, 215, 193, 230, 209, 208, 208, 203, 202 }, 164), this._pauseIcon, new Vector2(0.915f, 0.962f), new Vector2(120f, 120f), _0xbe57dfde.WithAlpha(_0xbe57dfde.Violet, 0.92f), _0xbe57dfde.Cream);
        _0x8e53984a.onClick.AddListener(() => _0xd33e0602._0x317f874d());
        this._0xd113cba4 = _0x07e13b60.Label(this._0x9a41f3d6, _0x5b1a305e._0x6edcfc47(new byte[10] { 14, 61, 46, 37, 63, 13, 39, 42, 56, 35 }, 75), string.Empty, new Vector2(0.5f, 0.70f), new Vector2(760f, 150f), 88f, _0xbe57dfde.Gold, TextAlignmentOptions.Center);
        this._0xd113cba4.alpha = 0f;
    }

    public RectTransform _0x5315ef57
    {
        get
        {
            return this._0x9a41f3d6;
        }
    }

    private Tween _0x142501b2;
    private TextMeshProUGUI _0xd113cba4;
    private Tween _0xa0e9e1ad;
    [SerializeField]
    private Sprite _pipSprite;
    private TextMeshProUGUI _0x7a7a110d;
    private bool _0x19950977;
    [SerializeField]
    private Sprite _pauseIcon;
    public void _0x7c307dff(int _0x1a5a8d27)
    {
        if (this._0x93c65f91 != null)
            this._0x93c65f91.text = _0x5b1a305e._0x6edcfc47(new byte[7] { 170, 161, 168, 160, 167, 201, 145 }, 233) + _0x1a5a8d27.ToString();
    }
}

internal static class _0x5b1a305e
{
    internal static string _0x6edcfc47(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}