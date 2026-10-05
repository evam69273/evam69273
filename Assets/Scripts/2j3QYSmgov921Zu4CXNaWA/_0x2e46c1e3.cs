using System.Collections.Generic;
using TMPro;
using UnityEngine;

/// <summary>
/// The scene template ships seven tutorial slots and this game teaches its rules on
/// its own HOW TO PLAY sheet in the menu. The three slots that describe the same
/// three rules get this game's copy, and the remaining four are emptied, so the
/// template's filler wording can never reach a screen. The panels themselves stay in
/// the pool untouched - they are addressed by index, never removed.
/// </summary>
public sealed class _0x2e46c1e3 : MonoBehaviour
{
    private void _0x2ccc5e2d(int _0x6ade1b3f, string _0xad895ea4, string _0xa3284d11)
    {
        _0xe645a9ed _0x7cc4ab44 = this._0xcd557ce0(_0x6ade1b3f);
        if (_0x7cc4ab44 == null)
            return;
        if (_0x7cc4ab44.HeaderText != null)
            _0x07e13b60.Dress(_0x7cc4ab44.HeaderText, _0xad895ea4, 56f, _0xbe57dfde.Gold, TextAlignmentOptions.Center);
        if (_0x7cc4ab44.MainText != null)
            _0x07e13b60.Dress(_0x7cc4ab44.MainText, _0xa3284d11, 40f, _0xbe57dfde.Cream, TextAlignmentOptions.Center);
    }

    public void _0x2508cdf5()
    {
        this._0x2ccc5e2d(_0x9cf3c3e3._0xea9b069c.TUTORIAL0, _0x69ed7036._0x5054e6fb(new byte[10] { 214, 223, 197, 194, 176, 220, 209, 222, 213, 195 }, 144), _0x69ed7036._0x5054e6fb(new byte[42] { 172, 169, 176, 175, 185, 175, 220, 174, 169, 178, 220, 168, 179, 220, 168, 180, 185, 220, 191, 174, 165, 175, 168, 189, 176, 220, 189, 176, 179, 178, 187, 220, 186, 179, 169, 174, 220, 176, 189, 178, 185, 175 }, 252));
        this._0x2ccc5e2d(_0x9cf3c3e3._0xea9b069c.TUTORIAL1, _0x69ed7036._0x5054e6fb(new byte[13] { 75, 74, 77, 81, 63, 75, 87, 90, 63, 77, 86, 81, 88 }, 31), _0x69ed7036._0x5054e6fb(new byte[45] { 215, 194, 211, 163, 215, 214, 209, 205, 163, 207, 163, 204, 209, 163, 215, 214, 209, 205, 163, 209, 163, 215, 204, 163, 206, 204, 213, 198, 163, 215, 203, 198, 163, 193, 207, 202, 205, 199, 163, 208, 198, 192, 215, 204, 209 }, 131));
        this._0x2ccc5e2d(_0x9cf3c3e3._0xea9b069c.TUTORIAL2, _0x69ed7036._0x5054e6fb(new byte[22] { 240, 254, 253, 241, 249, 146, 224, 247, 246, 158, 146, 254, 247, 230, 146, 230, 247, 243, 254, 146, 251, 252 }, 178), _0x69ed7036._0x5054e6fb(new byte[48] { 33, 58, 59, 55, 62, 54, 82, 38, 58, 55, 82, 33, 58, 51, 32, 54, 33, 82, 51, 60, 54, 82, 62, 55, 51, 36, 55, 82, 38, 58, 55, 82, 49, 58, 51, 32, 53, 55, 33, 82, 51, 82, 37, 51, 43, 82, 59, 60 }, 114));
        this._0x41c221fd(_0x9cf3c3e3._0xea9b069c.TUTORIAL3);
        this._0x41c221fd(_0x9cf3c3e3._0xea9b069c.TUTORIAL4);
        this._0x41c221fd(_0x9cf3c3e3._0xea9b069c.TUTORIAL5);
        this._0x41c221fd(_0x9cf3c3e3._0xea9b069c.TUTORIAL6);
    }

    private void _0x41c221fd(int _0x4db9617d)
    {
        _0xe645a9ed _0xb1bc4432 = this._0xcd557ce0(_0x4db9617d);
        if (_0xb1bc4432 == null)
            return;
        List<TMP_Text> _0x270d99f9 = this._0xedd0e24f(_0xb1bc4432);
        for (int _0x4efeb2b3 = 0; _0x4efeb2b3 < _0x270d99f9.Count; _0x4efeb2b3++)
            _0x270d99f9[_0x4efeb2b3].text = string.Empty;
    }

    private _0xe645a9ed _0xcd557ce0(int _0x7c693747)
    {
        _0x64a8e136 _0x0d3bd513 = _0x64a8e136.Instance;
        if (_0x0d3bd513 == null || _0x0d3bd513.Panels == null)
            return null;
        if (_0x7c693747 < 0 || _0x7c693747 >= _0x0d3bd513.Panels.Count)
            return null;
        return _0x0d3bd513.Panels[_0x7c693747];
    }

    private List<TMP_Text> _0xedd0e24f(_0xe645a9ed _0xf72291a9)
    {
        List<TMP_Text> _0x74a5baf5 = new List<TMP_Text>();
        if (_0xf72291a9.Content != null)
            _0x74a5baf5.AddRange(_0xf72291a9.Content.GetComponentsInChildren<TMP_Text>(true));
        if (_0xf72291a9.HeaderText != null && !_0x74a5baf5.Contains(_0xf72291a9.HeaderText))
            _0x74a5baf5.Add(_0xf72291a9.HeaderText);
        if (_0xf72291a9.MainText != null && !_0x74a5baf5.Contains(_0xf72291a9.MainText))
            _0x74a5baf5.Add(_0xf72291a9.MainText);
        return _0x74a5baf5;
    }
}

internal static class _0x69ed7036
{
    internal static string _0x5054e6fb(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}