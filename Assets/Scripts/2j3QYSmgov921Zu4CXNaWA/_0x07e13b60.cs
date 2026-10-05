using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The small factory both scenes build their own UI with. Every helper adds its
/// children in the order background -> icon -> text, so a plate can never cover its
/// own label, and every label is authored with word wrap OFF and autosize ON against
/// the 24 px readability floor - line breaks are the caller's business, never the
/// engine's.
/// </summary>
public static class _0x07e13b60
{
    /// <summary>
    /// A themed button: frame, fill, then the caption LAST so it draws on top.
    /// The face image carries the raycast, and the caller always subscribes with a
    /// lambda - never a method group, which an obfuscated build would not survive.
    /// </summary>
    public static Button Cta(Transform _0xd29ea2a2, string _0x07e18aca, string _0xc1bd43a9, Vector2 _0xdeb54f0b, Vector2 _0x710970d4, Color _0x55595460, Color _0xb17b0f44, Color _0x2a861f8b, float _0x0c413cc6)
    {
        RectTransform _0xe0398ae4 = Node(_0xd29ea2a2, _0x07e18aca, _0xdeb54f0b, _0x710970d4);
        Image _0x153e1f51 = _0xe0398ae4.gameObject.AddComponent<Image>();
        _0x153e1f51.color = _0xb17b0f44;
        _0x153e1f51.raycastTarget = true;
        RectTransform _0x661711e0 = Stretch(_0xe0398ae4, _0x07e18aca + _0xa8273948._0x4800c3ae(new byte[4] { 115, 92, 89, 89 }, 53));
        _0x661711e0.offsetMin = new Vector2(5f, 5f);
        _0x661711e0.offsetMax = new Vector2(-5f, -5f);
        Image _0x73339d68 = _0x661711e0.gameObject.AddComponent<Image>();
        _0x73339d68.color = _0x55595460;
        _0x73339d68.raycastTarget = false;
        TextMeshProUGUI _0xdb796561 = StretchLabel(_0xe0398ae4, _0x07e18aca + _0xa8273948._0x4800c3ae(new byte[5] { 189, 144, 147, 148, 157 }, 241), _0xc1bd43a9, _0x0c413cc6, _0x2a861f8b, TextAlignmentOptions.Center);
        _0xdb796561.rectTransform.offsetMin = new Vector2(20f, 12f);
        _0xdb796561.rectTransform.offsetMax = new Vector2(-20f, -12f);
        Button _0x6df5554a = _0xe0398ae4.gameObject.AddComponent<Button>();
        Paint(_0x6df5554a, _0x153e1f51);
        return _0x6df5554a;
    }

    /// <summary>
    /// The press state lives in the ColorBlock on a VISIBLE graphic. Pointing the
    /// target at a transparent hit layer would multiply an alpha-0 colour and the
    /// button would look dead on every tap.
    /// </summary>
    private static void Paint(Button _0x2620c32c, Image _0x6babf4c3)
    {
        _0x2620c32c.targetGraphic = _0x6babf4c3;
        ColorBlock _0x58db5e51 = _0x2620c32c.colors;
        _0x58db5e51.normalColor = Color.white;
        _0x58db5e51.highlightedColor = Color.white;
        _0x58db5e51.pressedColor = new Color(0.72f, 0.62f, 0.42f, 1f);
        _0x58db5e51.selectedColor = Color.white;
        _0x58db5e51.disabledColor = new Color(0.5f, 0.5f, 0.5f, 0.6f);
        _0x58db5e51.fadeDuration = 0.09f;
        _0x2620c32c.colors = _0x58db5e51;
    }

    public static TextMeshProUGUI Label(Transform _0x694ea15a, string _0x2c75bbed, string _0x7d9f4d30, Vector2 _0xc41704c7, Vector2 _0xa7c0c3a7, float _0x2930d090, Color _0x902dc211, TextAlignmentOptions _0x0daf9737)
    {
        RectTransform _0x9a5e97cd = Node(_0x694ea15a, _0x2c75bbed, _0xc41704c7, _0xa7c0c3a7);
        TextMeshProUGUI _0xeb645cb6 = _0x9a5e97cd.gameObject.AddComponent<TextMeshProUGUI>();
        Dress(_0xeb645cb6, _0x7d9f4d30, _0x2930d090, _0x902dc211, _0x0daf9737);
        return _0xeb645cb6;
    }

    public static TextMeshProUGUI StretchLabel(Transform _0x5b8ab852, string _0x04a72475, string _0xf51e560c, float _0xedaa566d, Color _0xcd48936a, TextAlignmentOptions _0xfe7d6d53)
    {
        RectTransform _0xdad948b9 = Stretch(_0x5b8ab852, _0x04a72475);
        TextMeshProUGUI _0x46668463 = _0xdad948b9.gameObject.AddComponent<TextMeshProUGUI>();
        Dress(_0x46668463, _0xf51e560c, _0xedaa566d, _0xcd48936a, _0xfe7d6d53);
        return _0x46668463;
    }

    /// <summary>
    /// A full-stretch child. Always used for hosts created from code: a bare
    /// new GameObject(..., typeof(RectTransform)) starts at 100x100, and every child
    /// anchor would then resolve against 100x100 instead of the 1242x2688 panel.
    /// </summary>
    public static RectTransform Stretch(Transform _0x81608e28, string _0xf83227ac)
    {
        GameObject _0x74f598b0 = new GameObject(_0xf83227ac, typeof(RectTransform));
        RectTransform _0x725dc36d = _0x74f598b0.GetComponent<RectTransform>();
        _0x725dc36d.SetParent(_0x81608e28, false);
        _0x725dc36d.anchorMin = Vector2.zero;
        _0x725dc36d.anchorMax = Vector2.one;
        _0x725dc36d.pivot = new Vector2(0.5f, 0.5f);
        _0x725dc36d.anchoredPosition = Vector2.zero;
        _0x725dc36d.sizeDelta = Vector2.zero;
        _0x725dc36d.localScale = Vector3.one;
        return _0x725dc36d;
    }

    public const float FontFloor = 24f;
    public static Image Plate(Transform _0x8d34ae7a, string _0xbf5646b9, Vector2 _0x3d5602e9, Vector2 _0x0f202e55, Color _0xbf4dd0c4, Sprite _0x6d33cd5b)
    {
        RectTransform _0x15587a7f = Node(_0x8d34ae7a, _0xbf5646b9, _0x3d5602e9, _0x0f202e55);
        Image _0xa3d44128 = _0x15587a7f.gameObject.AddComponent<Image>();
        _0xa3d44128.color = _0xbf4dd0c4;
        _0xa3d44128.raycastTarget = false;
        if (_0x6d33cd5b != null)
        {
            _0xa3d44128.sprite = _0x6d33cd5b;
            _0xa3d44128.type = Image.Type.Sliced;
        }

        return _0xa3d44128;
    }

    public static Image FullPlate(Transform _0x3a4fc65c, string _0xbb9b937b, Color _0x3196177b)
    {
        RectTransform _0x1fd5c19f = Stretch(_0x3a4fc65c, _0xbb9b937b);
        Image _0x65ac4094 = _0x1fd5c19f.gameObject.AddComponent<Image>();
        _0x65ac4094.color = _0x3196177b;
        _0x65ac4094.raycastTarget = false;
        return _0x65ac4094;
    }

    /// <summary>Word wrap OFF, autosize ON, floor 24 - the house style for every label.</summary>
    public static void Dress(TMP_Text _0x765d9866, string _0x90828bf9, float _0x2065173d, Color _0xe5dc69c4, TextAlignmentOptions _0x0e1a213f)
    {
        _0x765d9866.text = _0x90828bf9;
        _0x765d9866.color = _0xe5dc69c4;
        _0x765d9866.alignment = _0x0e1a213f;
        _0x765d9866.enableWordWrapping = false;
        _0x765d9866.overflowMode = TextOverflowModes.Overflow;
        _0x765d9866.enableAutoSizing = true;
        _0x765d9866.fontSizeMin = FontFloor;
        _0x765d9866.fontSizeMax = Mathf.Max(FontFloor, _0x2065173d);
        _0x765d9866.fontSize = Mathf.Max(FontFloor, _0x2065173d);
        _0x765d9866.raycastTarget = false;
    }

    /// <summary>
    /// A wide button with a square icon at a fixed 24-by-24 ratio of its height and
    /// the caption beside it, both on one baseline - icons in a row never float.
    /// </summary>
    public static Button IconCta(Transform _0x1c575df5, string _0xeebd144c, string _0x858f155a, Sprite _0xa9bcb14c, Vector2 _0x82b639ca, Vector2 _0x5c63319b, Color _0x4e796f25, Color _0x1475ec45, Color _0x29f82729, float _0x373f9c12)
    {
        RectTransform _0xaa2845f3 = Node(_0x1c575df5, _0xeebd144c, _0x82b639ca, _0x5c63319b);
        Image _0xa0f9c073 = _0xaa2845f3.gameObject.AddComponent<Image>();
        _0xa0f9c073.color = _0x1475ec45;
        _0xa0f9c073.raycastTarget = true;
        RectTransform _0x2bb4cb26 = Stretch(_0xaa2845f3, _0xeebd144c + _0xa8273948._0x4800c3ae(new byte[4] { 101, 74, 79, 79 }, 35));
        _0x2bb4cb26.offsetMin = new Vector2(5f, 5f);
        _0x2bb4cb26.offsetMax = new Vector2(-5f, -5f);
        Image _0x47085c6d = _0x2bb4cb26.gameObject.AddComponent<Image>();
        _0x47085c6d.color = _0x4e796f25;
        _0x47085c6d.raycastTarget = false;
        float _0xed5e45a6 = 96f;
        if (_0xa9bcb14c != null)
        {
            Image _0x458c127c = Picture(_0xaa2845f3, _0xeebd144c + _0xa8273948._0x4800c3ae(new byte[4] { 23, 61, 49, 48 }, 94), new Vector2(0.21f, 0.5f), new Vector2(_0xed5e45a6, _0xed5e45a6), _0xa9bcb14c, _0x29f82729);
            _0x458c127c.raycastTarget = false;
        }

        TextMeshProUGUI _0xaa78b7f9 = Label(_0xaa2845f3, _0xeebd144c + _0xa8273948._0x4800c3ae(new byte[5] { 197, 232, 235, 236, 229 }, 137), _0x858f155a, new Vector2(0.63f, 0.5f), new Vector2(_0x5c63319b.x * 0.52f, _0xed5e45a6), _0x373f9c12, _0x29f82729, TextAlignmentOptions.Center);
        _0xaa78b7f9.rectTransform.localScale = Vector3.one;
        Button _0x16e7d087 = _0xaa2845f3.gameObject.AddComponent<Button>();
        Paint(_0x16e7d087, _0xa0f9c073);
        return _0x16e7d087;
    }

    public static RectTransform Node(Transform _0x22c349fb, string _0x8102fe96, Vector2 _0x5cc283ee, Vector2 _0x9b01b646)
    {
        GameObject _0xe4ea5dd3 = new GameObject(_0x8102fe96, typeof(RectTransform));
        RectTransform _0x730305ec = _0xe4ea5dd3.GetComponent<RectTransform>();
        _0x730305ec.SetParent(_0x22c349fb, false);
        _0x730305ec.anchorMin = _0x5cc283ee;
        _0x730305ec.anchorMax = _0x5cc283ee;
        _0x730305ec.pivot = new Vector2(0.5f, 0.5f);
        _0x730305ec.anchoredPosition = Vector2.zero;
        _0x730305ec.sizeDelta = _0x9b01b646;
        _0x730305ec.localScale = Vector3.one;
        return _0x730305ec;
    }

    /// <summary>A sprite drawn at its own proportions - preserveAspect is never off here.</summary>
    public static Image Picture(Transform _0xa266a6f0, string _0x6ebc2606, Vector2 _0xc27729a3, Vector2 _0xb4dd340c, Sprite _0x2d59aba5, Color _0x9788066a)
    {
        RectTransform _0xddab3cba = Node(_0xa266a6f0, _0x6ebc2606, _0xc27729a3, _0xb4dd340c);
        Image _0x1c402b7b = _0xddab3cba.gameObject.AddComponent<Image>();
        _0x1c402b7b.sprite = _0x2d59aba5;
        _0x1c402b7b.color = _0x9788066a;
        _0x1c402b7b.preserveAspect = true;
        _0x1c402b7b.raycastTarget = false;
        return _0x1c402b7b;
    }

    /// <summary>
    /// A full-screen shade for an overlay. Never fully transparent and never culled:
    /// the raycaster skips a culled mesh, and the overlay would stop blocking taps.
    /// </summary>
    public static Image Shade(Transform _0x788e380f, string _0xaa2cd97c, Color _0x8019f13f)
    {
        RectTransform _0x1641b37f = Stretch(_0x788e380f, _0xaa2cd97c);
        Image _0xaa2e5d28 = _0x1641b37f.gameObject.AddComponent<Image>();
        _0xaa2e5d28.color = _0x8019f13f;
        _0xaa2e5d28.raycastTarget = true;
        if (_0xaa2e5d28.canvasRenderer != null)
            _0xaa2e5d28.canvasRenderer.cullTransparentMesh = false;
        return _0xaa2e5d28;
    }

    /// <summary>A square icon button - sprite face, no caption. Back, pause, close.</summary>
    public static Button SquareCta(Transform _0x4b674486, string _0xad90c0dc, Sprite _0x9e74f8e0, Vector2 _0x86581e1e, Vector2 _0x7b206a10, Color _0xcb77796b, Color _0x1b7b2e26)
    {
        RectTransform _0x70888ad6 = Node(_0x4b674486, _0xad90c0dc, _0x86581e1e, _0x7b206a10);
        Image _0x653b87f9 = _0x70888ad6.gameObject.AddComponent<Image>();
        _0x653b87f9.color = _0xcb77796b;
        _0x653b87f9.raycastTarget = true;
        Image _0x612da029 = Picture(_0x70888ad6, _0xad90c0dc + _0xa8273948._0x4800c3ae(new byte[4] { 34, 8, 4, 5 }, 107), new Vector2(0.5f, 0.5f), _0x7b206a10 * 0.6f, _0x9e74f8e0, _0x1b7b2e26);
        _0x612da029.raycastTarget = false;
        Button _0xa400f053 = _0x70888ad6.gameObject.AddComponent<Button>();
        Paint(_0xa400f053, _0x653b87f9);
        return _0xa400f053;
    }
}

internal static class _0xa8273948
{
    internal static string _0x4800c3ae(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}