using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The menu: an abstract mark, a live diorama of the stage running behind the UI, the
/// player's total FLOW and the record of the chosen speed, and two sheets - SPEED
/// MODES and HOW TO PLAY - that open in place. The Play button is the template's own
/// instance; this only gives it a face, because the template already carries the
/// driver that loads the round.
/// </summary>
public sealed class _0x66fab68f : MonoBehaviour
{
    [SerializeField]
    private GameObject _dangerPrefab;
    [SerializeField]
    private GameObject _boonPrefab;
    private void _0x73aa444e(RectTransform _0xd20cd42d, int _0xa360836e, float _0x0473ad9e, Sprite _0xa41361c6, Color _0x6316f502, string _0x5f55a69e)
    {
        RectTransform _0x763a6be9 = _0x07e13b60.Node(_0xd20cd42d, _0xfd0019c3._0x092fa0a1(new byte[4] { 166, 129, 152, 145 }, 244) + _0xa360836e.ToString(), new Vector2(0.5f, _0x0473ad9e), new Vector2(860f, 150f));
        Image _0x2ec4e822 = _0x763a6be9.gameObject.AddComponent<Image>();
        _0x2ec4e822.color = _0xbe57dfde.WithAlpha(_0xbe57dfde.SurfaceEdge, 0.9f);
        _0x2ec4e822.raycastTarget = false;
        if (_0xa41361c6 != null)
            _0x07e13b60.Picture(_0x763a6be9, _0xfd0019c3._0x092fa0a1(new byte[8] { 199, 224, 249, 240, 220, 246, 250, 251 }, 149), new Vector2(0.11f, 0.5f), new Vector2(96f, 96f), _0xa41361c6, _0x6316f502);
        _0x07e13b60.Label(_0x763a6be9, _0xfd0019c3._0x092fa0a1(new byte[8] { 14, 41, 48, 57, 8, 57, 36, 40 }, 92), _0x5f55a69e, new Vector2(0.60f, 0.5f), new Vector2(600f, 96f), 38f, _0xbe57dfde.Cream, TextAlignmentOptions.Center);
    }

    [SerializeField]
    private Sprite _dangerSprite;
    [SerializeField]
    private Sprite _crystalSprite;
    private TextMeshProUGUI _0xf60be4b5;
    private TextMeshProUGUI _0x498c3e50;
    [SerializeField]
    private _0x6c4332d7 _playDriver;
    private TextMeshProUGUI _0xe0f587be(RectTransform _0x10d98570, float _0xb91d5386, string _0xda30e32f, Color _0x2c2f5f07)
    {
        RectTransform _0x7de8d581 = _0x07e13b60.Node(_0x10d98570, _0xfd0019c3._0x092fa0a1(new byte[4] { 84, 115, 102, 115 }, 7) + _0xda30e32f, new Vector2(_0xb91d5386, 0.5f), new Vector2(500f, 150f));
        Image _0x4f42a914 = _0x7de8d581.gameObject.AddComponent<Image>();
        _0x4f42a914.color = _0xbe57dfde.WithAlpha(_0x2c2f5f07, 0.55f);
        _0x4f42a914.raycastTarget = false;
        RectTransform _0x2307d597 = _0x07e13b60.Stretch(_0x7de8d581, _0xfd0019c3._0x092fa0a1(new byte[8] { 124, 91, 78, 91, 109, 64, 75, 86 }, 47));
        _0x2307d597.offsetMin = new Vector2(4f, 4f);
        _0x2307d597.offsetMax = new Vector2(-4f, -4f);
        Image _0x8815e255 = _0x2307d597.gameObject.AddComponent<Image>();
        _0x8815e255.color = _0xbe57dfde.WithAlpha(_0xbe57dfde.Surface, 0.94f);
        _0x8815e255.raycastTarget = false;
        TextMeshProUGUI _0x23000912 = _0x07e13b60.Label(_0x7de8d581, _0xfd0019c3._0x092fa0a1(new byte[9] { 23, 48, 37, 48, 18, 37, 40, 49, 33 }, 68), _0xfd0019c3._0x092fa0a1(new byte[1] { 198 }, 246), new Vector2(0.5f, 0.62f), new Vector2(440f, 80f), 54f, _0x2c2f5f07, TextAlignmentOptions.Center);
        _0x07e13b60.Label(_0x7de8d581, _0xfd0019c3._0x092fa0a1(new byte[11] { 224, 199, 210, 199, 240, 210, 195, 199, 218, 220, 221 }, 179), _0xda30e32f, new Vector2(0.5f, 0.24f), new Vector2(440f, 56f), 34f, _0xbe57dfde.Muted, TextAlignmentOptions.Center);
        return _0x23000912;
    }

    [SerializeField]
    private Sprite _boonSprite;
    private void Start()
    {
        if (this._preview != null)
        {
            this._preview._0x41e42ff6();
            this._0xa899c24d();
            if (this._preview._0xb759e073 != null)
                this._preview._0xb759e073.DOLocalRotate(new Vector3(0f, 0f, -90f), 3.5f, RotateMode.LocalAxisAdd).SetEase(Ease.Linear).SetLoops(-1, LoopType.Incremental);
        }

        Transform _0xe8eb07cd = this._0x4c034a49();
        if (_0xe8eb07cd == null)
            return;
        this._0x62c4df55(_0xe8eb07cd);
        this._0x1cdeecde(_0xe8eb07cd);
        this._0x75f55abf(_0xe8eb07cd);
        this._0xcc5799f2(_0xe8eb07cd);
        this._0x9ebb8bea();
        this._0x380d08f1(_0xe8eb07cd);
        this._0x1e95f6ab(_0xe8eb07cd);
        if (this._modes != null)
            this._modes._0x65a104ea(_0xe8eb07cd, this);
        if (this._tutorial != null)
            this._tutorial._0x2508cdf5();
        this._0x01eb36f6();
    }

    private readonly List<int> _0x436188bd = new List<int>();
    private void _0xef842dee(bool _0x5e6a7c95)
    {
        if (this._0xe3b487f9 == null)
            return;
        if (_0x5e6a7c95 && this._modes != null)
            this._modes._0x802b65d0(false);
        this._0xe3b487f9.SetActive(_0x5e6a7c95);
        if (!_0x5e6a7c95)
            return;
        this._0xe3b487f9.transform.localScale = Vector3.one * 0.94f;
        this._0xe3b487f9.transform.DOScale(1f, 0.22f).SetEase(Ease.OutBack);
    }

    /// <summary>The brand mark: a crystal inside a broken ring. A shape, never a name.</summary>
    private void _0x62c4df55(Transform _0xbf943540)
    {
        RectTransform _0xa3be8651 = _0x07e13b60.Node(_0xbf943540, _0xfd0019c3._0x092fa0a1(new byte[9] { 160, 144, 131, 140, 134, 175, 131, 144, 137 }, 226), new Vector2(0.5f, 0.858f), new Vector2(340f, 340f));
        if (this._ringSprite != null)
            _0x07e13b60.Picture(_0xa3be8651, _0xfd0019c3._0x092fa0a1(new byte[8] { 207, 227, 240, 233, 208, 235, 236, 229 }, 130), new Vector2(0.5f, 0.5f), new Vector2(312f, 312f), this._ringSprite, _0xbe57dfde.WithAlpha(_0xbe57dfde.Violet, 0.95f));
        if (this._shieldSprite != null)
        {
            Image _0xf244464a = _0x07e13b60.Picture(_0xa3be8651, _0xfd0019c3._0x092fa0a1(new byte[10] { 238, 194, 209, 200, 240, 198, 192, 215, 204, 209 }, 163), new Vector2(0.5f, 0.5f), new Vector2(210f, 210f), this._shieldSprite, _0xbe57dfde.Gold);
            _0xf244464a.rectTransform.anchoredPosition = new Vector2(0f, 104f);
            _0xf244464a.rectTransform.localRotation = Quaternion.Euler(0f, 0f, -90f);
        }

        if (this._crystalSprite != null)
        {
            Image _0xe80b4e03 = _0x07e13b60.Picture(_0xa3be8651, _0xfd0019c3._0x092fa0a1(new byte[11] { 54, 26, 9, 16, 56, 9, 2, 8, 15, 26, 23 }, 123), new Vector2(0.5f, 0.5f), new Vector2(170f, 170f), this._crystalSprite, Color.white);
            _0xe80b4e03.rectTransform.localScale = Vector3.one * 0.86f;
            _0xe80b4e03.rectTransform.DOScale(1f, 0.45f).SetEase(Ease.OutBack);
        }
    }

    /// <summary>
    /// The template's Play button ships invisible: every image inside BASE_PANEL has
    /// its raycast off and its chrome switched off. A face added as a CHILD with the
    /// raycast ON gives it both a look and a hit area - UGUI bubbles the click up to
    /// the ancestor Button, so the template driver still loads the round and nothing
    /// here calls LoadSceneByIndex a second time.
    /// </summary>
    private void _0x9ebb8bea()
    {
        if (this._playDriver == null)
            return;
        RectTransform _0x84e99895 = this._playDriver.transform as RectTransform;
        if (_0x84e99895 == null)
            return;
        RectTransform _0x4e9a82ee = _0x07e13b60.Stretch(_0x84e99895, _0xfd0019c3._0x092fa0a1(new byte[8] { 100, 88, 85, 77, 114, 85, 87, 81 }, 52));
        Image _0x0b70c8fa = _0x4e9a82ee.gameObject.AddComponent<Image>();
        _0x0b70c8fa.color = _0xbe57dfde.Danger;
        _0x0b70c8fa.raycastTarget = true;
        // The template aims this Button at BASE_PANEL's transparent Fade layer, so the
        // press tint is multiplied by alpha 0 and nothing happens on screen. Pointing
        // it at the face drawn just above gives PLAY a real press state.
        Button _0xcb1f8c4a = _0x84e99895.GetComponent<Button>();
        if (_0xcb1f8c4a != null)
        {
            _0xcb1f8c4a.targetGraphic = _0x0b70c8fa;
            ColorBlock _0x44cd7994 = _0xcb1f8c4a.colors;
            _0x44cd7994.normalColor = Color.white;
            _0x44cd7994.highlightedColor = Color.white;
            _0x44cd7994.pressedColor = new Color(0.72f, 0.62f, 0.42f, 1f);
            _0x44cd7994.selectedColor = Color.white;
            _0x44cd7994.disabledColor = new Color(0.5f, 0.5f, 0.5f, 0.6f);
            _0x44cd7994.fadeDuration = 0.09f;
            _0xcb1f8c4a.colors = _0x44cd7994;
        }

        RectTransform _0x8d4245a0 = _0x07e13b60.Stretch(_0x4e9a82ee, _0xfd0019c3._0x092fa0a1(new byte[8] { 103, 91, 86, 78, 113, 94, 91, 91 }, 55));
        _0x8d4245a0.offsetMin = new Vector2(6f, 6f);
        _0x8d4245a0.offsetMax = new Vector2(-6f, -6f);
        Image _0xa846e779 = _0x8d4245a0.gameObject.AddComponent<Image>();
        _0xa846e779.color = _0xbe57dfde.Gold;
        _0xa846e779.raycastTarget = false;
        TextMeshProUGUI _0xfe781461 = _0x07e13b60.StretchLabel(_0x4e9a82ee, _0xfd0019c3._0x092fa0a1(new byte[9] { 91, 103, 106, 114, 71, 106, 105, 110, 103 }, 11), _0xfd0019c3._0x092fa0a1(new byte[4] { 234, 246, 251, 227 }, 186), 74f, _0xbe57dfde.Ink, TextAlignmentOptions.Center);
        _0xfe781461.rectTransform.offsetMin = new Vector2(26f, 18f);
        _0xfe781461.rectTransform.offsetMax = new Vector2(-26f, -18f);
        _0x4e9a82ee.localScale = Vector3.one * 0.001f;
        _0x4e9a82ee.DOScale(1f, 0.38f).SetEase(Ease.OutBack);
    }

    [SerializeField]
    private _0x2cee673b _modes;
    private void _0x1cdeecde(Transform _0xf9768909)
    {
        _0x07e13b60.Label(_0xf9768909, _0xfd0019c3._0x092fa0a1(new byte[9] { 42, 7, 15, 0, 6, 17, 12, 19, 0 }, 101), _0xfd0019c3._0x092fa0a1(new byte[31] { 178, 181, 182, 190, 218, 174, 178, 191, 218, 185, 168, 163, 169, 174, 187, 182, 218, 188, 181, 168, 218, 205, 207, 218, 169, 191, 185, 181, 180, 190, 169 }, 250), new Vector2(0.5f, 0.742f), new Vector2(1080f, 78f), 40f, _0xbe57dfde.Cream, TextAlignmentOptions.Center);
    }

    private GameObject _0xe3b487f9;
    private void Update()
    {
        if (this._preview == null || this._0xaf8d0f89.Count == 0)
            return;
        float _0x137ad8f5 = (this._preview._0x32c3d67b - this._preview._0x038e2c28) / _0x5f9ac917.PulseTravelSeconds * _0x5f9ac917.ModeSpeed[_0x5f9ac917.ClampMode(_0x6a3f9ee1._0xdb647cc0)] * _0x5f9ac917.MenuDriftScale;
        for (int _0x9b9a9fd8 = 0; _0x9b9a9fd8 < this._0xaf8d0f89.Count; _0x9b9a9fd8++)
        {
            Transform _0x6e891195 = this._0xaf8d0f89[_0x9b9a9fd8];
            if (_0x6e891195 == null)
                continue;
            float _0xbf555ef3 = this._0xb99bccb4[_0x9b9a9fd8] - _0x137ad8f5 * Time.deltaTime;
            if (_0xbf555ef3 <= this._preview._0x038e2c28)
                _0xbf555ef3 = this._preview._0x32c3d67b;
            this._0xb99bccb4[_0x9b9a9fd8] = _0xbf555ef3;
            Vector2 _0x574ade28 = this._preview._0x98def0ff(this._0x436188bd[_0x9b9a9fd8], _0xbf555ef3);
            _0x6e891195.position = new Vector3(_0x574ade28.x, _0x574ade28.y, 0f);
        }
    }

    private TextMeshProUGUI _0x7c2aff4b;
    [SerializeField]
    private Sprite _ringSprite;
    private void _0xcc5799f2(Transform _0x576b933c)
    {
        RectTransform _0xffa0dcdb = _0x07e13b60.Node(_0x576b933c, _0xfd0019c3._0x092fa0a1(new byte[13] { 223, 253, 246, 247, 209, 250, 251, 226, 194, 254, 243, 230, 247 }, 146), new Vector2(0.5f, 0.585f), new Vector2(460f, 96f));
        Image _0x49a02ae3 = _0xffa0dcdb.gameObject.AddComponent<Image>();
        _0x49a02ae3.color = _0xbe57dfde.Boon;
        _0x49a02ae3.raycastTarget = false;
        RectTransform _0xc84b9b88 = _0x07e13b60.Stretch(_0xffa0dcdb, _0xfd0019c3._0x092fa0a1(new byte[12] { 151, 181, 190, 191, 153, 178, 179, 170, 152, 181, 190, 163 }, 218));
        _0xc84b9b88.offsetMin = new Vector2(4f, 4f);
        _0xc84b9b88.offsetMax = new Vector2(-4f, -4f);
        Image _0x28af6368 = _0xc84b9b88.gameObject.AddComponent<Image>();
        _0x28af6368.color = _0xbe57dfde.Ink;
        _0x28af6368.raycastTarget = false;
        this._0x7c2aff4b = _0x07e13b60.StretchLabel(_0xffa0dcdb, _0xfd0019c3._0x092fa0a1(new byte[13] { 183, 149, 158, 159, 185, 146, 147, 138, 182, 155, 152, 159, 150 }, 250), _0xfd0019c3._0x092fa0a1(new byte[13] { 112, 115, 102, 102, 103, 25, 3, 112, 119, 102, 98, 103, 122 }, 35), 38f, _0xbe57dfde.Cream, TextAlignmentOptions.Center);
        this._0x7c2aff4b.rectTransform.offsetMin = new Vector2(16f, 8f);
        this._0x7c2aff4b.rectTransform.offsetMax = new Vector2(-16f, -8f);
    }

    [SerializeField]
    private _0xaf3d63d9 _preview;
    /// <summary>Everything the menu has to answer with when a speed is picked.</summary>
    public void _0x01eb36f6()
    {
        int _0x6ed9c4b6 = _0x6a3f9ee1._0xdb647cc0;
        if (this._0x7c2aff4b != null)
            this._0x7c2aff4b.text = _0xfd0019c3._0x092fa0a1(new byte[7] { 185, 186, 175, 175, 174, 208, 202 }, 234) + _0x5f9ac917.ModeName(_0x6ed9c4b6);
        if (this._0xe61a3cb7 != null)
            this._0xe61a3cb7.text = _0x9cf3c3e3._0x931bebe5._0x98ad77d8.ToString();
        bool _0x7961e21e = _0x6a3f9ee1.HasRecord(_0x6ed9c4b6);
        if (this._0xf60be4b5 != null)
        {
            this._0xf60be4b5.transform.parent.gameObject.SetActive(_0x7961e21e);
            this._0xf60be4b5.text = _0x6a3f9ee1.BestFlow(_0x6ed9c4b6).ToString();
        }

        if (this._0x498c3e50 != null)
            this._0x498c3e50.gameObject.SetActive(!_0x7961e21e);
    }

    private void _0x75f55abf(Transform _0x5915f256)
    {
        RectTransform _0xc26611ec = _0x07e13b60.Node(_0x5915f256, _0xfd0019c3._0x092fa0a1(new byte[7] { 220, 251, 238, 251, 221, 224, 248 }, 143), new Vector2(0.5f, 0.662f), new Vector2(1080f, 160f));
        this._0xe61a3cb7 = this._0xe0f587be(_0xc26611ec, 0.255f, _0xfd0019c3._0x092fa0a1(new byte[4] { 31, 21, 22, 14 }, 89), _0xbe57dfde.Boon);
        this._0xf60be4b5 = this._0xe0f587be(_0xc26611ec, 0.745f, _0xfd0019c3._0x092fa0a1(new byte[4] { 90, 93, 75, 76 }, 24), _0xbe57dfde.Gold);
        this._0x498c3e50 = _0x07e13b60.Label(_0xc26611ec, _0xfd0019c3._0x092fa0a1(new byte[9] { 176, 151, 129, 134, 183, 159, 130, 134, 139 }, 242), _0xfd0019c3._0x092fa0a1(new byte[10] { 77, 76, 35, 81, 86, 77, 35, 90, 70, 87 }, 3), new Vector2(0.745f, 0.52f), new Vector2(420f, 70f), 40f, _0xbe57dfde.Muted, TextAlignmentOptions.Center);
    }

    /// <summary>
    /// The rules sheet. It lives inside the menu panel rather than in the template's
    /// tutorial pool, so there is no way for a reader to land on a page with no way
    /// back - CLOSE is always on it.
    /// </summary>
    private void _0x1e95f6ab(Transform _0x2e4af952)
    {
        RectTransform _0x7070f695 = _0x07e13b60.Stretch(_0x2e4af952, _0xfd0019c3._0x092fa0a1(new byte[12] { 60, 27, 3, 32, 27, 59, 2, 17, 6, 24, 21, 13 }, 116));
        this._0xe3b487f9 = _0x7070f695.gameObject;
        _0x07e13b60.Shade(_0x7070f695, _0xfd0019c3._0x092fa0a1(new byte[10] { 215, 240, 232, 203, 240, 204, 247, 254, 251, 250 }, 159), _0xbe57dfde.WithAlpha(_0xbe57dfde.Ink, 0.85f));
        RectTransform _0xb20e85fa = _0x07e13b60.Node(_0x7070f695, _0xfd0019c3._0x092fa0a1(new byte[9] { 96, 71, 95, 124, 71, 107, 73, 90, 76 }, 40), new Vector2(0.5f, 0.5f), new Vector2(980f, 1180f));
        Image _0xadfb74bd = _0xb20e85fa.gameObject.AddComponent<Image>();
        _0xadfb74bd.color = _0xbe57dfde.WithAlpha(_0xbe57dfde.Violet, 0.95f);
        _0xadfb74bd.raycastTarget = true;
        RectTransform _0x9e1de627 = _0x07e13b60.Stretch(_0xb20e85fa, _0xfd0019c3._0x092fa0a1(new byte[9] { 148, 179, 171, 136, 179, 158, 179, 184, 165 }, 220));
        _0x9e1de627.offsetMin = new Vector2(8f, 8f);
        _0x9e1de627.offsetMax = new Vector2(-8f, -8f);
        Image _0x0165d685 = _0x9e1de627.gameObject.AddComponent<Image>();
        _0x0165d685.color = _0xbe57dfde.Surface;
        _0x0165d685.raycastTarget = false;
        _0x07e13b60.Label(_0xb20e85fa, _0xfd0019c3._0x092fa0a1(new byte[10] { 174, 137, 145, 178, 137, 178, 143, 146, 138, 131 }, 230), _0xfd0019c3._0x092fa0a1(new byte[11] { 243, 244, 236, 155, 239, 244, 155, 235, 247, 250, 226 }, 187), new Vector2(0.5f, 0.915f), new Vector2(840f, 110f), 56f, _0xbe57dfde.Gold, TextAlignmentOptions.Center);
        this._0x73aa444e(_0xb20e85fa, 0, 0.74f, this._dangerSprite, _0xbe57dfde.Danger, _0xfd0019c3._0x092fa0a1(new byte[20] { 185, 183, 180, 184, 176, 219, 175, 179, 190, 219, 169, 190, 191, 219, 168, 179, 186, 169, 191, 168 }, 251));
        this._0x73aa444e(_0xb20e85fa, 1, 0.58f, this._boonSprite, _0xbe57dfde.Boon, _0xfd0019c3._0x092fa0a1(new byte[23] { 163, 170, 187, 207, 187, 167, 170, 207, 187, 170, 174, 163, 207, 172, 167, 174, 189, 168, 170, 188, 207, 166, 161 }, 239));
        this._0x73aa444e(_0xb20e85fa, 2, 0.42f, this._shieldSprite, _0xbe57dfde.Gold, _0xfd0019c3._0x092fa0a1(new byte[31] { 184, 185, 178, 215, 164, 178, 180, 163, 184, 165, 215, 184, 177, 215, 163, 191, 178, 215, 165, 190, 185, 176, 215, 190, 164, 215, 181, 187, 190, 185, 179 }, 247));
        this._0x73aa444e(_0xb20e85fa, 3, 0.26f, this._crystalSprite, _0xbe57dfde.Cream, _0xfd0019c3._0x092fa0a1(new byte[27] { 135, 155, 129, 150, 150, 243, 128, 131, 146, 129, 152, 128, 243, 146, 157, 151, 243, 228, 230, 243, 128, 150, 144, 156, 157, 151, 128 }, 211));
        Button _0xee46f6e7 = _0x07e13b60.Cta(_0xb20e85fa, _0xfd0019c3._0x092fa0a1(new byte[10] { 66, 101, 125, 94, 101, 73, 102, 101, 121, 111 }, 10), _0xfd0019c3._0x092fa0a1(new byte[5] { 95, 80, 83, 79, 89 }, 28), new Vector2(0.5f, 0.085f), new Vector2(520f, 132f), _0xbe57dfde.SurfaceEdge, _0xbe57dfde.WithAlpha(_0xbe57dfde.Gold, 0.7f), _0xbe57dfde.Cream, 46f);
        _0xee46f6e7.onClick.AddListener(() => this._0xef842dee(false));
        this._0xe3b487f9.SetActive(false);
    }

    private void _0x380d08f1(Transform _0xce27d6f0)
    {
        Button _0xbafa2777 = _0x07e13b60.Cta(_0xce27d6f0, _0xfd0019c3._0x092fa0a1(new byte[16] { 2, 33, 52, 52, 53, 28, 62, 53, 52, 34, 19, 36, 37, 37, 62, 63 }, 81), _0xfd0019c3._0x092fa0a1(new byte[11] { 253, 254, 235, 235, 234, 142, 227, 225, 234, 235, 253 }, 174), new Vector2(0.285f, 0.205f), new Vector2(520f, 132f), _0xbe57dfde.SurfaceEdge, _0xbe57dfde.WithAlpha(_0xbe57dfde.Violet, 0.85f), _0xbe57dfde.Cream, 42f);
        _0xbafa2777.onClick.AddListener(() => this._0x1a4dca84());
        Button _0x7c94bbee = _0x07e13b60.Cta(_0xce27d6f0, _0xfd0019c3._0x092fa0a1(new byte[15] { 203, 236, 244, 215, 236, 211, 239, 226, 250, 193, 246, 247, 247, 236, 237 }, 131), _0xfd0019c3._0x092fa0a1(new byte[11] { 180, 179, 171, 220, 168, 179, 220, 172, 176, 189, 165 }, 252), new Vector2(0.715f, 0.205f), new Vector2(520f, 132f), _0xbe57dfde.SurfaceEdge, _0xbe57dfde.WithAlpha(_0xbe57dfde.Violet, 0.85f), _0xbe57dfde.Cream, 42f);
        _0x7c94bbee.onClick.AddListener(() => this._0xef842dee(true));
        _0x07e13b60.Label(_0xce27d6f0, _0xfd0019c3._0x092fa0a1(new byte[8] { 31, 55, 60, 39, 26, 59, 60, 38 }, 82), _0xfd0019c3._0x092fa0a1(new byte[39] { 250, 239, 254, 142, 250, 251, 252, 224, 142, 226, 142, 225, 252, 142, 250, 251, 252, 224, 142, 252, 142, 250, 225, 142, 227, 225, 248, 235, 142, 250, 230, 235, 142, 253, 230, 231, 235, 226, 234 }, 174), new Vector2(0.5f, 0.122f), new Vector2(1080f, 68f), 34f, _0xbe57dfde.Muted, TextAlignmentOptions.Center);
    }

    /// <summary>
    /// The body of the template's DEFAULT panel. PanelController.GetPanel is private
    /// in this template, so the public Panels list is the supported way in.
    /// </summary>
    private Transform _0x4c034a49()
    {
        _0x64a8e136 _0xa0ec4774 = _0x64a8e136.Instance;
        if (_0xa0ec4774 == null || _0xa0ec4774.Panels == null)
            return null;
        int _0x9e8f3e77 = _0x9cf3c3e3._0xea9b069c.DEFAULT;
        if (_0x9e8f3e77 < 0 || _0x9e8f3e77 >= _0xa0ec4774.Panels.Count)
            return null;
        _0xe645a9ed _0x99f8faef = _0xa0ec4774.Panels[_0x9e8f3e77];
        if (_0x99f8faef == null || _0x99f8faef.Content == null)
            return null;
        return _0x99f8faef.Content.transform;
    }

    private TextMeshProUGUI _0xe61a3cb7;
    private readonly List<Transform> _0xaf8d0f89 = new List<Transform>();
    private readonly List<float> _0xb99bccb4 = new List<float>();
    [SerializeField]
    private _0x2e46c1e3 _tutorial;
    private void _0x1a4dca84()
    {
        this._0xef842dee(false);
        if (this._modes != null)
            this._modes._0x802b65d0(true);
    }

    // the diorama ------------------------------------------------------------
    private void _0xa899c24d()
    {
        if (this._preview == null)
            return;
        for (int _0xa98566a1 = 0; _0xa98566a1 < _0x5f9ac917.LaneCount; _0xa98566a1++)
        {
            bool _0x9b8faebb = _0xa98566a1 % 2 == 0;
            GameObject _0xb9c80118 = _0x9b8faebb ? this._dangerPrefab : this._boonPrefab;
            if (_0xb9c80118 == null)
                continue;
            GameObject _0xa9b57f3d = Instantiate(_0xb9c80118, this.transform);
            SpriteRenderer _0x298e50aa = _0xa9b57f3d.GetComponent<SpriteRenderer>();
            if (_0x298e50aa != null)
            {
                _0x298e50aa.sprite = _0x9b8faebb ? this._dangerSprite : this._boonSprite;
                _0x298e50aa.color = _0x9b8faebb ? _0xbe57dfde.Danger : _0xbe57dfde.Boon;
                float _0x8f1b4be7 = this._preview._0x946072b6 * _0x5f9ac917.PulseFraction * _0x5f9ac917.MenuBoardScale;
                _0x298e50aa.size = new Vector2(_0x8f1b4be7, _0x8f1b4be7);
                _0x298e50aa.sortingOrder = _0x5f9ac917.ClampOrder(_0x5f9ac917.OrderPulse);
            }

            _0xa9b57f3d.transform.localRotation = Quaternion.Euler(0f, 0f, _0xaf3d63d9.LaneAngle(_0xa98566a1) + 180f);
            _0x44afcaf5 _0x688cf682 = _0xa9b57f3d.GetComponent<_0x44afcaf5>();
            if (_0x688cf682 != null)
                Destroy(_0x688cf682);
            float _0x1a465f34 = this._preview._0x32c3d67b - this._preview._0x038e2c28;
            this._0xaf8d0f89.Add(_0xa9b57f3d.transform);
            this._0x436188bd.Add(_0xa98566a1);
            this._0xb99bccb4.Add(this._preview._0x038e2c28 + _0x1a465f34 * (0.18f + 0.22f * _0xa98566a1));
        }
    }

    [SerializeField]
    private Sprite _shieldSprite;
}

internal static class _0xfd0019c3
{
    internal static string _0x092fa0a1(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}