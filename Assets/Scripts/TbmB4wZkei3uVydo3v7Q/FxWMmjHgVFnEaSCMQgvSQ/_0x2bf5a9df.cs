using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Canvas))]
public class _0x2bf5a9df : MonoBehaviour
{
    private void OnDestroy()
    {
        if (_0x188b78b3 != null && _0x188b78b3.Contains(this))
            _0x188b78b3.Remove(this);
    }

    private RectTransform _0x211fa7c6;
    private static void SafeAreaChanged()
    {
        _0x001b8fe0 = Screen.safeArea;
        for (int _0xfb910db9 = 0; _0xfb910db9 < _0x188b78b3.Count; _0xfb910db9++)
            _0x188b78b3[_0xfb910db9]._0x7e7353ef();
    }

    private Canvas _0xbafa53de;
    private void _0x7e7353ef()
    {
        if (this._0x4b4d0dfd == null)
            return;
        Rect _0xb0ccc9f0 = Screen.safeArea;
        Vector2 _0xeeb50d64 = _0xb0ccc9f0.position;
        Vector2 _0xf3a2b044 = _0xb0ccc9f0.position + _0xb0ccc9f0.size;
        _0xeeb50d64.x /= this._0xbafa53de.pixelRect.width;
        _0xeeb50d64.y /= this._0xbafa53de.pixelRect.height;
        _0xf3a2b044.x /= this._0xbafa53de.pixelRect.width;
        _0xf3a2b044.y /= this._0xbafa53de.pixelRect.height;
        this._0x4b4d0dfd.anchorMin = _0xeeb50d64;
        this._0x4b4d0dfd.anchorMax = _0xf3a2b044;
    }

    private static Rect _0x001b8fe0 = Rect.zero;
    private static UnityEvent _0xe079c550 = new();
    private static bool _0x4939cdf1;
    private static readonly List<_0x2bf5a9df> _0x188b78b3 = new();
    private RectTransform _0x4b4d0dfd;
    private static ScreenOrientation _0x328e0056 = ScreenOrientation.LandscapeLeft;
    private static void ResolutionChanged()
    {
        _0xd7d1bf9f.x = Screen.width;
        _0xd7d1bf9f.y = Screen.height;
        _0xe079c550.Invoke();
    }

    private void Update()
    {
        if (_0x188b78b3[0] != this)
            return;
        if (Application.isMobilePlatform && Screen.orientation != _0x328e0056)
            OrientationChanged();
        if (Screen.safeArea != _0x001b8fe0)
            SafeAreaChanged();
        if (Screen.width != _0xd7d1bf9f.x || Screen.height != _0xd7d1bf9f.y)
            ResolutionChanged();
    }

    private void Awake()
    {
        if (!_0x188b78b3.Contains(this))
            _0x188b78b3.Add(this);
        this._0xbafa53de = this.GetComponent<Canvas>();
        this._0x211fa7c6 = this.GetComponent<RectTransform>();
        this._0x4b4d0dfd = this.transform.Find(_0x6dec8b79._0x3b43faa6(new byte[8] { 255, 205, 202, 201, 237, 222, 201, 205 }, 172)) as RectTransform;
        if (!_0x4939cdf1)
        {
            _0x328e0056 = Screen.orientation;
            _0xd7d1bf9f.x = Screen.width;
            _0xd7d1bf9f.y = Screen.height;
            _0x001b8fe0 = Screen.safeArea;
            _0x4939cdf1 = true;
        }

        this._0x7e7353ef();
    }

    private static Vector2 _0xd7d1bf9f = Vector2.zero;
    private static void OrientationChanged()
    {
        _0x328e0056 = Screen.orientation;
        _0xd7d1bf9f.x = Screen.width;
        _0xd7d1bf9f.y = Screen.height;
        _0xe079c550.Invoke();
    }
}

internal static class _0x6dec8b79
{
    internal static string _0x3b43faa6(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}