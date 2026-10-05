using System.Collections.Generic;
using TMPro;
using UnityEngine;

// TmpContrastGuard.cs — staged into every Unity app by approve-pipeline-unity.sh
// (stage 5c3, rule C.14 in CLAUDE-unity.md). Do not edit the copy inside a project;
// edit scripts/lib/unity/TmpContrastGuard.cs.
//
// WHY: every TMP label gets an outline (C.10), and by default that outline is dark.
// A dark face colour on a dark outline merges into a smudge — the label is not
// readable on any backing (ANDROID-3627: PLAY drawn Deep #12151E on the #12151E
// outline read as a black blob). enforce-text-contrast.sh fixes colours SERIALISED
// in scenes/prefabs, but labels built at runtime from C# (UiKit.Cta, VaultUi.Caption,
// label.color = Palette.X ...) never reach a scene file, so that pass cannot see them.
//
// WHAT: after any TMP text is regenerated, compare its face colour with the outline
// colour of the material it actually renders with. Below WCAG 4.5:1 the face is
// blended toward white (dark outline) or black (light outline) until it reaches 7:1.
// Hue is kept; alpha is kept. A label whose outline was deliberately switched to a
// light colour (TextReadability-style per-label material) is measured against THAT
// outline, so intentionally dark text on a light rim is left alone. Labels without
// an outline are left alone too.
public sealed class _0x8a7d6a21 : MonoBehaviour
{
    private const float MinRatio = 4.5f;
    private static _0x8a7d6a21 _0xa32a9a2d;
    private void LateUpdate()
    {
        if (this._0x08773208.Count == 0)
            return;
        this._0x9b0f12bd.Clear();
        this._0x9b0f12bd.AddRange(this._0x08773208);
        this._0x08773208.Clear();
        for (int _0xb47bfa7f = 0; _0xb47bfa7f < this._0x9b0f12bd.Count; _0xb47bfa7f++)
            Fix(this._0x9b0f12bd[_0xb47bfa7f]);
    }

    private void OnDisable()
    {
        if (this._0xbb6fba04 != null)
            TMPro_EventManager.TEXT_CHANGED_EVENT.Remove(this._0xbb6fba04);
    }

    private static float Linear(float _0x4386047b)
    {
        _0x4386047b = Mathf.Clamp01(_0x4386047b);
        return _0x4386047b <= 0.03928f ? _0x4386047b / 12.92f : Mathf.Pow((_0x4386047b + 0.055f) / 1.055f, 2.4f);
    }

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void Boot()
    {
        if (_0xa32a9a2d != null)
            return;
        GameObject _0x3f15dd69 = new GameObject(_0x7fb9eee9._0xb36cb559(new byte[16] { 192, 249, 228, 215, 251, 250, 224, 230, 245, 231, 224, 211, 225, 245, 230, 240 }, 148));
        _0x3f15dd69.hideFlags = HideFlags.HideInHierarchy;
        DontDestroyOnLoad(_0x3f15dd69);
        _0xa32a9a2d = _0x3f15dd69.AddComponent<_0x8a7d6a21>();
    }

    // A lambda held in a field, never the bare method group: Plana renames the method
    // declaration but not a method-group reference (verify-unity-buttons.sh, CS0103).
    // The field keeps Add and Remove on the same delegate instance.
    private System.Action<Object> _0xbb6fba04;
    private readonly HashSet<TMP_Text> _0x08773208 = new HashSet<TMP_Text>();
    private static void Fix(TMP_Text _0xcfaf11dc)
    {
        if (_0xcfaf11dc == null || !_0xcfaf11dc.isActiveAndEnabled)
            return;
        Material _0x5f7cc7a5 = _0xcfaf11dc.fontSharedMaterial;
        if (_0x5f7cc7a5 == null || !_0x5f7cc7a5.HasProperty(ShaderUtilities.ID_OutlineColor) || !_0x5f7cc7a5.HasProperty(ShaderUtilities.ID_OutlineWidth))
            return;
        if (_0x5f7cc7a5.GetFloat(ShaderUtilities.ID_OutlineWidth) < MinOutlineWidth)
            return;
        Color _0x522ed94b = _0xcfaf11dc.color;
        if (_0x522ed94b.a <= 0f)
            return;
        Color _0xd5a23157 = _0x5f7cc7a5.GetColor(ShaderUtilities.ID_OutlineColor);
        if (Ratio(_0x522ed94b, _0xd5a23157) >= MinRatio)
            return;
        Color _0xd663510e = Luminance(_0xd5a23157) < 0.5f ? Color.white : Color.black;
        Color _0x7be2d95d;
        if (Ratio(_0xd663510e, _0xd5a23157) < TargetRatio)
        {
            _0x7be2d95d = _0xd663510e;
        }
        else
        {
            // Smallest blend that reaches the target: contrast grows monotonically
            // with t, so a short bisection keeps as much of the hue as possible.
            float _0x3b0714be = 0f;
            float _0x58b5063e = 1f;
            for (int _0x4970a0ae = 0; _0x4970a0ae < 20; _0x4970a0ae++)
            {
                float _0xbffc6b7f = (_0x3b0714be + _0x58b5063e) * 0.5f;
                if (Ratio(Color.Lerp(_0x522ed94b, _0xd663510e, _0xbffc6b7f), _0xd5a23157) >= TargetRatio)
                    _0x58b5063e = _0xbffc6b7f;
                else
                    _0x3b0714be = _0xbffc6b7f;
            }

            _0x7be2d95d = Color.Lerp(_0x522ed94b, _0xd663510e, _0x58b5063e);
        }

        _0x7be2d95d.a = _0x522ed94b.a;
        _0xcfaf11dc.color = _0x7be2d95d;
    }

    private void OnEnable()
    {
        if (this._0xbb6fba04 == null)
            this._0xbb6fba04 = _0x13fe0272 => this._0xd03bc13b(_0x13fe0272);
        TMPro_EventManager.TEXT_CHANGED_EVENT.Add(this._0xbb6fba04);
    }

    private static float Ratio(Color _0x298fcfde, Color _0xbc5cf813)
    {
        float _0xb5647cb5 = Luminance(_0x298fcfde);
        float _0x2c602e61 = Luminance(_0xbc5cf813);
        return (Mathf.Max(_0xb5647cb5, _0x2c602e61) + 0.05f) / (Mathf.Min(_0xb5647cb5, _0x2c602e61) + 0.05f);
    }

    private readonly List<TMP_Text> _0x9b0f12bd = new List<TMP_Text>();
    private const float MinOutlineWidth = 0.01f;
    private const float TargetRatio = 7f;
    // The event fires from inside the canvas rebuild. Changing the colour right there
    // would re-dirty the graphic mid-rebuild, which Unity rejects — so queue it and
    // apply in LateUpdate, which runs before the next frame's rebuild.
    private void _0xd03bc13b(Object _0x8cb99577)
    {
        TMP_Text _0x4cd88cb8 = _0x8cb99577 as TMP_Text;
        if (_0x4cd88cb8 != null)
            this._0x08773208.Add(_0x4cd88cb8);
    }

    // WCAG relative luminance of an sRGB colour, and the contrast ratio of two.
    private static float Luminance(Color _0x9681b804)
    {
        return 0.2126f * Linear(_0x9681b804.r) + 0.7152f * Linear(_0x9681b804.g) + 0.0722f * Linear(_0x9681b804.b);
    }
}

internal static class _0x7fb9eee9
{
    internal static string _0xb36cb559(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}