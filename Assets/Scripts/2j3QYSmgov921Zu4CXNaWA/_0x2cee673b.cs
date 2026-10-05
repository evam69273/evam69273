using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The SPEED MODES sheet: a shade, a card and one chip per mode, each carrying its
/// own record. Picking a chip answers on the spot - the chosen chip lights up and
/// punches, the others dim, and the menu behind it repaints its caption and speeds up
/// its diorama, so the choice is visible in a single frame.
/// If the mode list were ever empty the card says so in the middle instead of showing
/// a blank sheet.
/// </summary>
public sealed class _0x2cee673b : MonoBehaviour
{
    private void _0x1b7f8998()
    {
        int _0xf33e1e76 = _0x6a3f9ee1._0xdb647cc0;
        for (int _0x3591c5d6 = 0; _0x3591c5d6 < this._0x8b605a19.Count; _0x3591c5d6++)
        {
            bool _0x695acfdc = _0x3591c5d6 == _0xf33e1e76;
            if (this._0x8b605a19[_0x3591c5d6] != null)
                this._0x8b605a19[_0x3591c5d6].color = _0x695acfdc ? _0xbe57dfde.Boon : _0xbe57dfde.Spent;
            if (this._0x1a689859[_0x3591c5d6] != null)
                this._0x1a689859[_0x3591c5d6].color = _0x695acfdc ? _0xbe57dfde.WithAlpha(_0xbe57dfde.Violet, 0.35f) : _0xbe57dfde.WithAlpha(_0xbe57dfde.SurfaceEdge, 0.45f);
            if (this._0xbbe03a2a[_0x3591c5d6] != null)
                this._0xbbe03a2a[_0x3591c5d6].color = _0x695acfdc ? _0xbe57dfde.Cream : _0xbe57dfde.Muted;
            if (this._0xbf733177[_0x3591c5d6] != null)
                this._0xbf733177[_0x3591c5d6].text = _0x6a3f9ee1.HasRecord(_0x3591c5d6) ? _0x0c969a6e._0x17464bf9(new byte[5] { 2, 5, 19, 20, 96 }, 64) + _0x6a3f9ee1.BestFlow(_0x3591c5d6).ToString() : _0x0c969a6e._0x17464bf9(new byte[7] { 1, 6, 16, 23, 99, 110, 110 }, 67);
        }
    }

    private readonly List<Image> _0x1a689859 = new List<Image>();
    private void _0xe9bc2b66(int _0xbd23ce9b)
    {
        _0x6a3f9ee1._0xdb647cc0 = _0x5f9ac917.ClampMode(_0xbd23ce9b);
        this._0x1b7f8998();
        if (_0xbd23ce9b >= 0 && _0xbd23ce9b < this._0x8b605a19.Count && this._0x8b605a19[_0xbd23ce9b] != null)
        {
            Transform _0x31e48a71 = this._0x8b605a19[_0xbd23ce9b].transform;
            DOTween.Kill(_0x31e48a71, true);
            _0x31e48a71.localScale = Vector3.one;
            _0x31e48a71.DOPunchScale(Vector3.one * 0.07f, 0.25f, 6, 0.6f);
        }

        if (this._0x39d11d46 != null)
            this._0x39d11d46._0x01eb36f6();
    }

    private readonly List<TextMeshProUGUI> _0xbf733177 = new List<TextMeshProUGUI>();
    [SerializeField]
    private GameObject _content;
    private readonly List<TextMeshProUGUI> _0xbbe03a2a = new List<TextMeshProUGUI>();
    public void _0x65a104ea(Transform _0x4b88c495, _0x66fab68f _0x60dc5e42)
    {
        this._0x39d11d46 = _0x60dc5e42;
        RectTransform _0x5a0dd59d = _0x07e13b60.Stretch(_0x4b88c495, _0x0c969a6e._0x17464bf9(new byte[11] { 23, 53, 62, 63, 21, 44, 63, 40, 54, 59, 35 }, 90));
        this._content = _0x5a0dd59d.gameObject;
        _0x07e13b60.Shade(_0x5a0dd59d, _0x0c969a6e._0x17464bf9(new byte[9] { 139, 169, 162, 163, 149, 174, 167, 162, 163 }, 198), _0xbe57dfde.WithAlpha(_0xbe57dfde.Ink, 0.82f));
        RectTransform _0x6489e7eb = _0x07e13b60.Node(_0x5a0dd59d, _0x0c969a6e._0x17464bf9(new byte[8] { 217, 251, 240, 241, 215, 245, 230, 240 }, 148), new Vector2(0.5f, 0.5f), new Vector2(980f, 1240f));
        Image _0x430cd458 = _0x6489e7eb.gameObject.AddComponent<Image>();
        _0x430cd458.color = _0xbe57dfde.WithAlpha(_0xbe57dfde.Violet, 0.95f);
        _0x430cd458.raycastTarget = true;
        RectTransform _0xc1102003 = _0x07e13b60.Stretch(_0x6489e7eb, _0x0c969a6e._0x17464bf9(new byte[12] { 58, 24, 19, 18, 52, 22, 5, 19, 53, 24, 19, 14 }, 119));
        _0xc1102003.offsetMin = new Vector2(8f, 8f);
        _0xc1102003.offsetMax = new Vector2(-8f, -8f);
        Image _0xb16fd868 = _0xc1102003.gameObject.AddComponent<Image>();
        _0xb16fd868.color = _0xbe57dfde.Surface;
        _0xb16fd868.raycastTarget = false;
        _0x07e13b60.Label(_0x6489e7eb, _0x0c969a6e._0x17464bf9(new byte[9] { 118, 84, 95, 94, 111, 82, 79, 87, 94 }, 59), _0x0c969a6e._0x17464bf9(new byte[11] { 72, 75, 94, 94, 95, 59, 86, 84, 95, 94, 72 }, 27), new Vector2(0.5f, 0.915f), new Vector2(840f, 110f), 56f, _0xbe57dfde.Gold, TextAlignmentOptions.Center);
        float _0xc4b25a28 = 220f;
        float _0xce2b62da = 36f;
        int _0xf1c6e250 = _0x5f9ac917.ModeCount;
        float _0xdf86a865 = 0.735f;
        for (int _0x71a42cec = 0; _0x71a42cec < _0xf1c6e250; _0x71a42cec++)
        {
            int _0x82ef8d63 = _0x71a42cec;
            float _0xe5966953 = _0xdf86a865 - _0x71a42cec * (_0xc4b25a28 + _0xce2b62da) / 1240f;
            RectTransform _0x85dfc68d = _0x07e13b60.Node(_0x6489e7eb, _0x0c969a6e._0x17464bf9(new byte[8] { 143, 173, 166, 167, 129, 170, 171, 178 }, 194) + _0x71a42cec.ToString(), new Vector2(0.5f, _0xe5966953), new Vector2(880f, _0xc4b25a28));
            Image _0x06df132e = _0x85dfc68d.gameObject.AddComponent<Image>();
            _0x06df132e.color = _0xbe57dfde.Spent;
            _0x06df132e.raycastTarget = true;
            RectTransform _0xd985d019 = _0x07e13b60.Stretch(_0x85dfc68d, _0x0c969a6e._0x17464bf9(new byte[8] { 211, 248, 249, 224, 214, 249, 252, 252 }, 144));
            _0xd985d019.offsetMin = new Vector2(4f, 4f);
            _0xd985d019.offsetMax = new Vector2(-4f, -4f);
            Image _0x3f3f8a87 = _0xd985d019.gameObject.AddComponent<Image>();
            _0x3f3f8a87.color = _0xbe57dfde.SurfaceEdge;
            _0x3f3f8a87.raycastTarget = false;
            TextMeshProUGUI _0x606687ac = _0x07e13b60.Label(_0x85dfc68d, _0x0c969a6e._0x17464bf9(new byte[8] { 178, 153, 152, 129, 191, 144, 156, 148 }, 241), _0x5f9ac917.ModeName(_0x71a42cec), new Vector2(0.3f, 0.66f), new Vector2(420f, 80f), 52f, _0xbe57dfde.Cream, TextAlignmentOptions.Left);
            _0x07e13b60.Label(_0x85dfc68d, _0x0c969a6e._0x17464bf9(new byte[9] { 52, 31, 30, 7, 36, 7, 18, 18, 19 }, 119), _0x0c969a6e._0x17464bf9(new byte[6] { 217, 218, 207, 207, 206, 170 }, 138) + _0x5f9ac917.ModeSpeedLabel[_0x71a42cec], new Vector2(0.3f, 0.32f), new Vector2(420f, 60f), 36f, _0xbe57dfde.Muted, TextAlignmentOptions.Left);
            TextMeshProUGUI _0x498ba0b4 = _0x07e13b60.Label(_0x85dfc68d, _0x0c969a6e._0x17464bf9(new byte[8] { 15, 36, 37, 60, 14, 41, 63, 56 }, 76), _0x0c969a6e._0x17464bf9(new byte[7] { 221, 218, 204, 203, 191, 178, 178 }, 159), new Vector2(0.76f, 0.5f), new Vector2(340f, 76f), 44f, _0xbe57dfde.Boon, TextAlignmentOptions.Right);
            Button _0xe616b9f1 = _0x85dfc68d.gameObject.AddComponent<Button>();
            _0xe616b9f1.targetGraphic = _0x06df132e;
            _0xe616b9f1.onClick.AddListener(() => this._0xe9bc2b66(_0x82ef8d63));
            this._0x8b605a19.Add(_0x06df132e);
            this._0x1a689859.Add(_0x3f3f8a87);
            this._0xbbe03a2a.Add(_0x606687ac);
            this._0xbf733177.Add(_0x498ba0b4);
        }

        if (_0xf1c6e250 == 0)
        {
            _0x07e13b60.Label(_0x6489e7eb, _0x0c969a6e._0x17464bf9(new byte[9] { 160, 130, 137, 136, 168, 128, 157, 153, 148 }, 237), _0x0c969a6e._0x17464bf9(new byte[21] { 112, 113, 30, 115, 113, 122, 123, 109, 30, 107, 112, 114, 113, 125, 117, 123, 122, 30, 103, 123, 106 }, 62), new Vector2(0.5f, 0.5f), new Vector2(840f, 100f), 46f, _0xbe57dfde.Muted, TextAlignmentOptions.Center);
        }

        Button _0xdd57c3f0 = _0x07e13b60.Cta(_0x6489e7eb, _0x0c969a6e._0x17464bf9(new byte[9] { 228, 198, 205, 204, 234, 197, 198, 218, 204 }, 169), _0x0c969a6e._0x17464bf9(new byte[5] { 247, 248, 251, 231, 241 }, 180), new Vector2(0.5f, 0.085f), new Vector2(520f, 132f), _0xbe57dfde.SurfaceEdge, _0xbe57dfde.WithAlpha(_0xbe57dfde.Gold, 0.7f), _0xbe57dfde.Cream, 46f);
        _0xdd57c3f0.onClick.AddListener(() => this._0x802b65d0(false));
        this._0x1b7f8998();
        this._content.SetActive(false);
    }

    public void _0x802b65d0(bool _0x95bf209c)
    {
        if (this._content == null)
            return;
        this._content.SetActive(_0x95bf209c);
        if (!_0x95bf209c)
            return;
        this._0x1b7f8998();
        this._content.transform.localScale = Vector3.one * 0.94f;
        this._content.transform.DOScale(1f, 0.22f).SetEase(Ease.OutBack);
    }

    private readonly List<Image> _0x8b605a19 = new List<Image>();
    private _0x66fab68f _0x39d11d46;
}

internal static class _0x0c969a6e
{
    internal static string _0x17464bf9(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}