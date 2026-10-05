using UnityEngine;

/// <summary>
/// The one source of colour for this app. Both scenes read from here, so the menu
/// and the round can never drift apart, and the shared TMP material outlines every
/// glyph with <see cref = "Ink"/> - which is why every text colour below is a light one.
/// </summary>
public static class _0xbe57dfde
{
    public static readonly Color Muted = new Color(0.7804f, 0.7176f, 0.8314f, 1f);
    public static readonly Color Surface = new Color(0.1216f, 0.0941f, 0.1608f, 1f);
    public static readonly Color Danger = new Color(0.8706f, 0.2314f, 0.3882f, 1f);
    public static readonly Color Gold = new Color(0.9412f, 0.7529f, 0.2980f, 1f);
    public static readonly Color Spent = new Color(0.2275f, 0.1843f, 0.2784f, 1f);
    public static readonly Color Violet = new Color(0.5059f, 0.2431f, 0.7137f, 1f);
    /// <summary>Same hue, different opacity - for glows, tracks and dimmed chips.</summary>
    public static Color WithAlpha(Color _0x79b52789, float _0x3c5fb7d3)
    {
        _0x79b52789.a = _0x3c5fb7d3;
        return _0x79b52789;
    }

    public static readonly Color SurfaceEdge = new Color(0.1647f, 0.1294f, 0.2078f, 1f);
    public static readonly Color Ink = new Color(0.0902f, 0.0745f, 0.1176f, 1f);
    public static readonly Color Cream = new Color(0.9608f, 0.9176f, 0.8627f, 1f);
    public static readonly Color Boon = new Color(0.1961f, 0.7333f, 0.6667f, 1f);
}