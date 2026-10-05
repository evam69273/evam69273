using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Dresses the three template pops - pause (6), win (7) and lose (8) - completely.
/// Every template child of a pop's content is switched off and this game's own card
/// is built in its place, so no leftover "Score:" row, no unused reward counter and
/// no sprite-less Image that would ship as a white square survives on screen.
/// The close corner gets this game's own icon for exactly that reason.
/// </summary>
public sealed class _0x17982c08 : MonoBehaviour
{
    private TextMeshProUGUI _0x35d0c80a;
    [SerializeField]
    private Sprite _crystalSprite;
    private static readonly Vector2 _0x533d26bf = new Vector2(980f, 1180f);
    public void _0x89940594(int _0x4ef2bb26, float _0xc7a7d195)
    {
        if (this._0x35d0c80a != null)
            this._0x35d0c80a.text = _0xe58eb730._0x94c70d52(new byte[7] { 143, 132, 143, 152, 141, 147, 234 }, 202) + _0x4ef2bb26.ToString() + _0xe58eb730._0x94c70d52(new byte[3] { 249, 246, 249 }, 217) + _0x5f9ac917.MaxEnergy.ToString();
        if (this._0xe9da3e16 != null)
            this._0xe9da3e16.text = Mathf.Max(0, Mathf.CeilToInt(_0xc7a7d195)).ToString() + _0xe58eb730._0x94c70d52(new byte[13] { 26, 105, 127, 121, 117, 116, 126, 105, 26, 118, 127, 124, 110 }, 58);
        if (_0xc720b4f1.Instance != null)
            _0xc720b4f1.Instance._0x2568b066(_0x9cf3c3e3._0xef00101c.PAUSE);
    }

    private Button _0xa5f16672(RectTransform _0x6a474c13, string _0x621402fb)
    {
        return _0x07e13b60.Cta(_0x6a474c13, _0xe58eb730._0x94c70d52(new byte[11] { 233, 203, 216, 206, 250, 216, 195, 199, 203, 216, 211 }, 170), _0x621402fb, new Vector2(0.72f, 0.105f), new Vector2(420f, 140f), _0xbe57dfde.Gold, _0xbe57dfde.Danger, _0xbe57dfde.Ink, 48f);
    }

    public void _0x13e91af6(int _0x58afef33, int _0x93d31299, int _0xd1085330)
    {
        if (this._0x105a1d2f != null)
            this._0x105a1d2f.text = _0xe58eb730._0x94c70d52(new byte[7] { 126, 117, 126, 105, 124, 98, 27 }, 59) + _0x58afef33.ToString() + _0xe58eb730._0x94c70d52(new byte[3] { 48, 63, 48 }, 16) + _0x5f9ac917.MaxEnergy.ToString();
        if (this._0xe2418ae4 != null)
            this._0xe2418ae4.text = _0xe58eb730._0x94c70d52(new byte[5] { 254, 244, 247, 239, 152 }, 184) + _0x93d31299.ToString() + _0xe58eb730._0x94c70d52(new byte[16] { 45, 45, 32, 45, 45, 79, 72, 94, 89, 45, 78, 69, 76, 68, 67, 45 }, 13) + _0xd1085330.ToString();
        if (_0xc720b4f1.Instance != null)
            _0xc720b4f1.Instance._0x2568b066(_0x9cf3c3e3._0xef00101c.WIN);
    }

    public void _0x0f28f2b2(_0x5c719e88 _0x0d2a5e8f)
    {
        this._0x8b3639f7 = _0x0d2a5e8f;
        _0xc720b4f1 _0x242956ff = _0xc720b4f1.Instance;
        if (_0x242956ff == null)
            return;
        // The literal index at the fetch keeps the card and the raise in one place,
        // and GetPop indexes its list without a bounds check, so a null means "skip".
        _0xfe27f2a2 _0x56e46b26 = _0x242956ff._0x0ce78cc7(_0x9cf3c3e3._0xef00101c.PAUSE);
        _0xfe27f2a2 _0x53965f3e = _0x242956ff._0x0ce78cc7(_0x9cf3c3e3._0xef00101c.WIN);
        _0xfe27f2a2 _0xeb3b4a8e = _0x242956ff._0x0ce78cc7(_0x9cf3c3e3._0xef00101c.LOSE);
        RectTransform _0x93f841c4 = this._0xf3f9c6c9(_0x56e46b26);
        if (_0x93f841c4 != null)
        {
            this._0xbba18d87(_0x93f841c4, this._crystalSprite, _0xbe57dfde.WithAlpha(_0xbe57dfde.Violet, 0.95f));
            this._0xc2734256(_0x93f841c4, _0xe58eb730._0x94c70d52(new byte[13] { 81, 86, 85, 93, 57, 77, 81, 92, 57, 85, 80, 87, 92 }, 25), _0xbe57dfde.Gold);
            this._0x35d0c80a = this._0xe92f2bbc(_0x93f841c4, _0xe58eb730._0x94c70d52(new byte[12] { 178, 185, 178, 165, 176, 174, 215, 196, 215, 216, 215, 196 }, 247), 86f, _0xbe57dfde.Cream);
            this._0xe9da3e16 = this._0xf14991ab(_0x93f841c4, _0xe58eb730._0x94c70d52(new byte[15] { 190, 188, 169, 218, 204, 202, 198, 199, 205, 218, 169, 197, 204, 207, 221 }, 137));
            Button _0xaee2d16f = this._0xa5f16672(_0x93f841c4, _0xe58eb730._0x94c70d52(new byte[6] { 201, 222, 200, 206, 214, 222 }, 155));
            _0xaee2d16f.onClick.AddListener(() => this._0x8b3639f7._0x4d5d2bd4());
            Button _0x65fceb4c = this._0xeca0c8c0(_0x93f841c4, _0xe58eb730._0x94c70d52(new byte[4] { 105, 97, 106, 113 }, 36));
            _0x65fceb4c.onClick.AddListener(() => this._0x8b3639f7._0x113ee211());
            Button _0xad53ee55 = this._0x35891a41(_0x93f841c4);
            _0xad53ee55.onClick.AddListener(() => this._0x8b3639f7._0x4d5d2bd4());
        }

        RectTransform _0x7a4c54ce = this._0xf3f9c6c9(_0x53965f3e);
        if (_0x7a4c54ce != null)
        {
            this._0xbba18d87(_0x7a4c54ce, this._burstSprite, _0xbe57dfde.WithAlpha(_0xbe57dfde.Gold, 0.95f));
            this._0xc2734256(_0x7a4c54ce, _0xe58eb730._0x94c70d52(new byte[12] { 204, 221, 214, 220, 219, 206, 195, 175, 199, 202, 195, 203 }, 143), _0xbe57dfde.Boon);
            this._0x105a1d2f = this._0xe92f2bbc(_0x7a4c54ce, _0xe58eb730._0x94c70d52(new byte[12] { 7, 12, 7, 16, 5, 27, 98, 113, 98, 109, 98, 113 }, 66), 86f, _0xbe57dfde.Gold);
            this._0xe2418ae4 = this._0xf14991ab(_0x7a4c54ce, _0xe58eb730._0x94c70d52(new byte[23] { 49, 59, 56, 32, 87, 71, 87, 87, 90, 87, 87, 53, 50, 36, 35, 87, 52, 63, 54, 62, 57, 87, 71 }, 119));
            Button _0x0f61cb96 = this._0xa5f16672(_0x7a4c54ce, _0xe58eb730._0x94c70d52(new byte[9] { 142, 137, 146, 252, 157, 155, 157, 149, 146 }, 220));
            _0x0f61cb96.onClick.AddListener(() => this._0x8b3639f7._0xccb224bd());
            Button _0xfef84697 = this._0xeca0c8c0(_0x7a4c54ce, _0xe58eb730._0x94c70d52(new byte[10] { 239, 228, 249, 245, 129, 242, 241, 228, 228, 229 }, 161));
            _0xfef84697.onClick.AddListener(() => this._0x8b3639f7._0xc22672f8());
            Button _0x9e7f6206 = this._0x35891a41(_0x7a4c54ce);
            _0x9e7f6206.onClick.AddListener(() => this._0x8b3639f7._0x113ee211());
        }

        RectTransform _0x214d643b = this._0xf3f9c6c9(_0xeb3b4a8e);
        if (_0x214d643b != null)
        {
            this._0xbba18d87(_0x214d643b, this._crystalSprite, _0xbe57dfde.WithAlpha(_0xbe57dfde.Spent, 0.95f));
            this._0xc2734256(_0x214d643b, _0xe58eb730._0x94c70d52(new byte[17] { 40, 57, 50, 56, 63, 42, 39, 75, 56, 35, 42, 63, 63, 46, 57, 46, 47 }, 107), _0xbe57dfde.Danger);
            this._0x30859e46 = this._0xe92f2bbc(_0x214d643b, _0xe58eb730._0x94c70d52(new byte[16] { 155, 150, 159, 151, 243, 227, 233, 227, 227, 243, 252, 243, 226, 233, 226, 230 }, 211), 76f, _0xbe57dfde.Cream);
            this._0xc3b31b55 = this._0xf14991ab(_0x214d643b, _0xe58eb730._0x94c70d52(new byte[23] { 125, 119, 116, 108, 27, 11, 27, 27, 22, 27, 27, 121, 126, 104, 111, 27, 120, 115, 122, 114, 117, 27, 11 }, 59));
            Button _0x3c58dca9 = this._0xa5f16672(_0x214d643b, _0xe58eb730._0x94c70d52(new byte[9] { 228, 227, 248, 150, 247, 241, 247, 255, 248 }, 182));
            _0x3c58dca9.onClick.AddListener(() => this._0x8b3639f7._0xccb224bd());
            Button _0xd9d976ab = this._0xeca0c8c0(_0x214d643b, _0xe58eb730._0x94c70d52(new byte[10] { 144, 155, 134, 138, 254, 141, 142, 155, 155, 154 }, 222));
            _0xd9d976ab.onClick.AddListener(() => this._0x8b3639f7._0xc22672f8());
            Button _0xa7e26617 = this._0x35891a41(_0x214d643b);
            _0xa7e26617.onClick.AddListener(() => this._0x8b3639f7._0x113ee211());
        }
    }

    private TextMeshProUGUI _0xf14991ab(RectTransform _0x55c052d7, string _0x7bd5185b)
    {
        return _0x07e13b60.Label(_0x55c052d7, _0xe58eb730._0x94c70d52(new byte[9] { 64, 98, 113, 103, 70, 123, 119, 113, 98 }, 3), _0x7bd5185b, new Vector2(0.5f, 0.285f), new Vector2(870f, 80f), 42f, _0xbe57dfde.Cream, TextAlignmentOptions.Center);
    }

    public void _0xade619e4(float _0x827cae26, int _0xd174efd8, int _0x3d5a40bb)
    {
        if (this._0x30859e46 != null)
            this._0x30859e46.text = _0xe58eb730._0x94c70d52(new byte[5] { 35, 46, 39, 47, 75 }, 107) + _0x5f9ac917.Clock(_0x827cae26) + _0xe58eb730._0x94c70d52(new byte[3] { 33, 46, 33 }, 1) + _0x5f9ac917.Clock(_0x5f9ac917.RoundSeconds);
        if (this._0xc3b31b55 != null)
            this._0xc3b31b55.text = _0xe58eb730._0x94c70d52(new byte[5] { 82, 88, 91, 67, 52 }, 20) + _0xd174efd8.ToString() + _0xe58eb730._0x94c70d52(new byte[16] { 136, 136, 133, 136, 136, 234, 237, 251, 252, 136, 235, 224, 233, 225, 230, 136 }, 168) + _0x3d5a40bb.ToString();
        if (_0xc720b4f1.Instance != null)
            _0xc720b4f1.Instance._0x2568b066(_0x9cf3c3e3._0xef00101c.LOSE);
    }

    /// <summary>Clears every template child of the pop and returns this game's own card.</summary>
    private RectTransform _0xf3f9c6c9(_0xfe27f2a2 _0x0358568a)
    {
        if (_0x0358568a == null || _0x0358568a.Content == null)
            return null;
        Transform _0x833d68e4 = _0x0358568a.Content.transform;
        for (int _0x9dcedea2 = _0x833d68e4.childCount - 1; _0x9dcedea2 >= 0; _0x9dcedea2--)
            _0x833d68e4.GetChild(_0x9dcedea2).gameObject.SetActive(false);
        RectTransform _0x15718342 = _0x07e13b60.Node(_0x833d68e4, _0xe58eb730._0x94c70d52(new byte[10] { 40, 31, 9, 15, 22, 14, 57, 27, 8, 30 }, 122), new Vector2(0.5f, 0.5f), _0x533d26bf);
        Image _0xf7d34fe7 = _0x15718342.gameObject.AddComponent<Image>();
        _0xf7d34fe7.color = _0xbe57dfde.WithAlpha(_0xbe57dfde.Violet, 0.95f);
        _0xf7d34fe7.raycastTarget = true;
        RectTransform _0xf4ba66d0 = _0x07e13b60.Stretch(_0x15718342, _0xe58eb730._0x94c70d52(new byte[8] { 12, 46, 61, 43, 8, 35, 32, 56 }, 79));
        _0xf4ba66d0.offsetMin = new Vector2(4f, 4f);
        _0xf4ba66d0.offsetMax = new Vector2(-4f, -4f);
        Image _0xf497385c = _0xf4ba66d0.gameObject.AddComponent<Image>();
        _0xf497385c.color = _0xbe57dfde.WithAlpha(_0xbe57dfde.Danger, 0.35f);
        _0xf497385c.raycastTarget = false;
        RectTransform _0x3c1981cd = _0x07e13b60.Stretch(_0x15718342, _0xe58eb730._0x94c70d52(new byte[8] { 146, 176, 163, 181, 147, 190, 181, 168 }, 209));
        _0x3c1981cd.offsetMin = new Vector2(10f, 10f);
        _0x3c1981cd.offsetMax = new Vector2(-10f, -10f);
        Image _0x8b9944a3 = _0x3c1981cd.gameObject.AddComponent<Image>();
        _0x8b9944a3.color = _0xbe57dfde.Surface;
        _0x8b9944a3.raycastTarget = false;
        RectTransform _0xbf83b964 = _0x07e13b60.Stretch(_0x15718342, _0xe58eb730._0x94c70d52(new byte[9] { 51, 17, 2, 20, 57, 30, 30, 21, 2 }, 112));
        _0xbf83b964.offsetMin = new Vector2(36f, 36f);
        _0xbf83b964.offsetMax = new Vector2(-36f, -36f);
        Image _0x11bd4690 = _0xbf83b964.gameObject.AddComponent<Image>();
        _0x11bd4690.color = _0xbe57dfde.WithAlpha(_0xbe57dfde.SurfaceEdge, 0.92f);
        _0x11bd4690.raycastTarget = false;
        return _0x15718342;
    }

    private Button _0xeca0c8c0(RectTransform _0x539ec3d9, string _0x833471e5)
    {
        return _0x07e13b60.Cta(_0x539ec3d9, _0xe58eb730._0x94c70d52(new byte[13] { 152, 186, 169, 191, 136, 190, 184, 180, 181, 191, 186, 169, 162 }, 219), _0x833471e5, new Vector2(0.28f, 0.105f), new Vector2(420f, 140f), _0xbe57dfde.SurfaceEdge, _0xbe57dfde.WithAlpha(_0xbe57dfde.Violet, 0.75f), _0xbe57dfde.Cream, 44f);
    }

    private TextMeshProUGUI _0xe9da3e16;
    [SerializeField]
    private Sprite _closeIcon;
    [SerializeField]
    private Sprite _burstSprite;
    private Button _0x35891a41(RectTransform _0xfdd45108)
    {
        return _0x07e13b60.SquareCta(_0xfdd45108, _0xe58eb730._0x94c70d52(new byte[9] { 48, 18, 1, 23, 48, 31, 28, 0, 22 }, 115), this._closeIcon, new Vector2(0.925f, 0.945f), new Vector2(104f, 104f), _0xbe57dfde.WithAlpha(_0xbe57dfde.Danger, 0.9f), _0xbe57dfde.Cream);
    }

    private TextMeshProUGUI _0xe2418ae4;
    private TextMeshProUGUI _0xc2734256(RectTransform _0x1abe8a6b, string _0x603da50a, Color _0x91bc6013)
    {
        return _0x07e13b60.Label(_0x1abe8a6b, _0xe58eb730._0x94c70d52(new byte[10] { 212, 246, 229, 243, 223, 242, 246, 243, 242, 229 }, 151), _0x603da50a, new Vector2(0.5f, 0.885f), new Vector2(870f, 118f), 68f, _0x91bc6013, TextAlignmentOptions.Center);
    }

    private TextMeshProUGUI _0xe92f2bbc(RectTransform _0x4a69975f, string _0x9059dfb0, float _0xb74e039a, Color _0x32a82134)
    {
        return _0x07e13b60.Label(_0x4a69975f, _0xe58eb730._0x94c70d52(new byte[8] { 238, 204, 223, 201, 229, 200, 223, 194 }, 173), _0x9059dfb0, new Vector2(0.5f, 0.385f), new Vector2(870f, 132f), _0xb74e039a, _0x32a82134, TextAlignmentOptions.Center);
    }

    private _0x5c719e88 _0x8b3639f7;
    private void _0xbba18d87(RectTransform _0x27b57f55, Sprite _0x4f6e9bb3, Color _0x0611f84c)
    {
        if (_0x4f6e9bb3 == null)
            return;
        _0x07e13b60.Picture(_0x27b57f55, _0xe58eb730._0x94c70d52(new byte[7] { 234, 200, 219, 205, 232, 219, 221 }, 169), new Vector2(0.5f, 0.635f), new Vector2(330f, 330f), _0x4f6e9bb3, _0x0611f84c);
    }

    private TextMeshProUGUI _0xc3b31b55;
    private TextMeshProUGUI _0x30859e46;
    private TextMeshProUGUI _0x105a1d2f;
}

internal static class _0xe58eb730
{
    internal static string _0x94c70d52(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}