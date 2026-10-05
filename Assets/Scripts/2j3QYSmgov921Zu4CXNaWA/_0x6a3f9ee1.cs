using UnityEngine;

/// <summary>
/// The chosen speed mode and its records, carried between the menu and the round
/// through PlayerPrefs. The key strings are fixed literals on purpose: an obfuscated
/// build still has to find yesterday's save.
/// </summary>
public static class _0x6a3f9ee1
{
    private static readonly string AttemptKey = _0x0073fb47._0x223f2c90(new byte[11] { 236, 236, 224, 217, 231, 242, 242, 227, 235, 246, 242 }, 134);
    private static readonly string ModeKey = _0x0073fb47._0x223f2c90(new byte[8] { 92, 92, 80, 105, 91, 89, 82, 83 }, 54);
    private static readonly string BestHeldKey = _0x0073fb47._0x223f2c90(new byte[9] { 15, 15, 3, 58, 13, 0, 9, 1, 58 }, 101);
    public static int BestChain(int _0x64d0b162)
    {
        return PlayerPrefs.GetInt(BestChainKey + _0x5f9ac917.ClampMode(_0x64d0b162).ToString(), 0);
    }

    private static readonly string BestFlowKey = _0x0073fb47._0x223f2c90(new byte[9] { 124, 124, 112, 73, 116, 115, 101, 98, 73 }, 22);
    /// <summary>Bumped once per round so the seed moves even inside one mode.</summary>
    public static int TakeAttempt()
    {
        int _0x621b20b9 = PlayerPrefs.GetInt(AttemptKey, 0) + 1;
        PlayerPrefs.SetInt(AttemptKey, _0x621b20b9);
        return _0x621b20b9;
    }

    public static void Record(int _0x841cefa4, int _0xd06c26c6, int _0x9fd7b571, float _0xa16e6f63)
    {
        int _0x0c5d2091 = _0x5f9ac917.ClampMode(_0x841cefa4);
        string _0x33b5549d = _0x0c5d2091.ToString();
        if (_0xd06c26c6 > PlayerPrefs.GetInt(BestFlowKey + _0x33b5549d, 0))
            PlayerPrefs.SetInt(BestFlowKey + _0x33b5549d, _0xd06c26c6);
        if (_0x9fd7b571 > PlayerPrefs.GetInt(BestChainKey + _0x33b5549d, 0))
            PlayerPrefs.SetInt(BestChainKey + _0x33b5549d, _0x9fd7b571);
        if (_0xa16e6f63 > PlayerPrefs.GetFloat(BestHeldKey + _0x33b5549d, 0f))
            PlayerPrefs.SetFloat(BestHeldKey + _0x33b5549d, _0xa16e6f63);
        PlayerPrefs.Save();
    }

    public static int BestFlow(int _0xe324992c)
    {
        return PlayerPrefs.GetInt(BestFlowKey + _0x5f9ac917.ClampMode(_0xe324992c).ToString(), 0);
    }

    public static int NextMode(int _0x1dd95b1b)
    {
        return (_0x5f9ac917.ClampMode(_0x1dd95b1b) + 1) % _0x5f9ac917.ModeCount;
    }

    private static readonly string BestChainKey = _0x0073fb47._0x223f2c90(new byte[10] { 157, 157, 145, 168, 148, 159, 150, 158, 153, 168 }, 247);
    public static bool HasRecord(int _0x879706a8)
    {
        return PlayerPrefs.HasKey(BestFlowKey + _0x5f9ac917.ClampMode(_0x879706a8).ToString());
    }

    public static float BestHeld(int _0xbea5c3cf)
    {
        return PlayerPrefs.GetFloat(BestHeldKey + _0x5f9ac917.ClampMode(_0xbea5c3cf).ToString(), 0f);
    }

    public static int _0xdb647cc0
    {
        get
        {
            return _0x5f9ac917.ClampMode(PlayerPrefs.GetInt(ModeKey, 0));
        }

        set
        {
            PlayerPrefs.SetInt(ModeKey, _0x5f9ac917.ClampMode(value));
        }
    }
}

internal static class _0x0073fb47
{
    internal static string _0x223f2c90(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}