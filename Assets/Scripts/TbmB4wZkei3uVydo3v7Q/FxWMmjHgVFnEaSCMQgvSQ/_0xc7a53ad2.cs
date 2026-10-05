using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Canvas))]
public class _0xc7a53ad2 : MonoBehaviour
{
    private static Vector2 _0xd50748a7 = Vector2.zero;
    private static ScreenOrientation _0xad366d3e = ScreenOrientation.LandscapeLeft;
    private static readonly List<_0xc7a53ad2> _0x5ba0910d = new();
    private static UnityEvent _0x7da26659 = new();
    private void OnDestroy()
    {
        if (_0x5ba0910d != null && _0x5ba0910d.Contains(this))
            _0x5ba0910d.Remove(this);
    }

    private Vector2 _0x9164c52a;
    private static void ApplySafeAreaToAll()
    {
        for (int _0x4883747e = 0; _0x4883747e < _0x5ba0910d.Count; _0x4883747e++)
            _0x5ba0910d[_0x4883747e]._0x69168292();
    }

    private Canvas _0xa96df400;
    private RectTransform _0x1e49445a;
    private void Awake()
    {
        if (!_0x5ba0910d.Contains(this))
            _0x5ba0910d.Add(this);
        this._0xa96df400 = this.GetComponent<Canvas>();
        this._0x9b2b763f = this.GetComponent<CanvasScaler>();
        if (this._0x9b2b763f != null)
            this._0x9164c52a = this._0x9b2b763f.referenceResolution;
        this._0x1e49445a = this.GetComponent<RectTransform>();
        this._0x54632651 = this.transform.Find(_0xec04f077._0xde26350e(new byte[8] { 76, 126, 121, 122, 94, 109, 122, 126 }, 31)) as RectTransform;
        if (!_0xd1b0a5b5)
        {
            _0xad366d3e = Screen.orientation;
            _0xd50748a7.x = Screen.width;
            _0xd50748a7.y = Screen.height;
            _0x2b8473f2 = Screen.safeArea;
            _0xd1b0a5b5 = true;
        }

        this._0x69168292();
    }

    private void Start()
    {
    }

    private static void SafeAreaChanged()
    {
        _0x2b8473f2 = Screen.safeArea;
        ApplySafeAreaToAll();
    }

    private static void OrientationChanged()
    {
        _0xad366d3e = Screen.orientation;
        _0xd50748a7.x = Screen.width;
        _0xd50748a7.y = Screen.height;
        _0x2b8473f2 = Screen.safeArea;
        ApplySafeAreaToAll();
        _0x7da26659.Invoke();
    }

    private static void ResolutionChanged()
    {
        _0xd50748a7.x = Screen.width;
        _0xd50748a7.y = Screen.height;
        _0x2b8473f2 = Screen.safeArea;
        ApplySafeAreaToAll();
        _0x7da26659.Invoke();
    }

    private static bool _0xd1b0a5b5;
    private CanvasScaler _0x9b2b763f;
    private RectTransform _0x54632651;
    private static Rect _0x2b8473f2 = Rect.zero;
    private void Update()
    {
        if (_0x5ba0910d.Count == 0 || _0x5ba0910d[0] != this)
            return;
        if (Application.isMobilePlatform && Screen.orientation != _0xad366d3e)
            OrientationChanged();
        if (Screen.safeArea != _0x2b8473f2)
            SafeAreaChanged();
        if (Screen.width != _0xd50748a7.x || Screen.height != _0xd50748a7.y)
            ResolutionChanged();
    }

    private void _0x69168292()
    {
        if (this._0x54632651 == null)
            return;
        float screenWidth = Screen.width;
        float screenHeight = Screen.height;
        if (screenWidth <= 0f || screenHeight <= 0f)
            return;
        Rect _0xcb32eabf = Screen.safeArea;
        Vector2 _0xf16b8867 = _0xcb32eabf.position;
        Vector2 _0xc0adb801 = _0xcb32eabf.position + _0xcb32eabf.size;
        _0xf16b8867.x /= screenWidth;
        _0xf16b8867.y /= screenHeight;
        _0xc0adb801.x /= screenWidth;
        _0xc0adb801.y /= screenHeight;
        this._0x54632651.anchorMin = _0xf16b8867;
        this._0x54632651.anchorMax = _0xc0adb801;
        this._0x54632651.offsetMin = Vector2.zero;
        this._0x54632651.offsetMax = Vector2.zero;
        if (this._0x9b2b763f == null)
            return;
        Vector2 _0x2fabee28 = _0xc0adb801 - _0xf16b8867;
        float _0xa33680f0 = 2f - _0x2fabee28.x;
        float _0xa77b9e66 = 2f - _0x2fabee28.y;
        this._0x9b2b763f.referenceResolution = this._0x9164c52a * new Vector2(_0xa33680f0, _0xa77b9e66);
    }
}

internal static class _0xec04f077
{
    internal static string _0xde26350e(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}