using UnityEngine;

/// <summary>
/// Every number the round is balanced on, plus the sorting orders of the board.
/// Orders are NAMED here and pushed through <see cref = "ClampOrder"/>; the legal band
/// is -19..-1, strictly between the background canvas (-30) and the pop canvases
/// (10 and above), so no piece of gameplay art can ever bury a result card.
/// Sizes are fractions of the camera half-width, never literals in world units, so
/// the board keeps its proportions on any portrait device.
/// </summary>
public static class _0x5f9ac917
{
    /// <summary>How much of a phase is made of hazards.</summary>
    public static float PhaseDangerShare(float _0xf1026abd)
    {
        if (_0xf1026abd < 20f)
            return 0.25f;
        if (_0xf1026abd < 48f)
            return 0.45f;
        return 0.62f;
    }

    public const int OrderBunting = -19;
    public const int StartEnergy = 3;
    public const int OrderMin = -19;
    public const float RingRadiusFraction = 0.46f;
    public const float PulseTravelSeconds = 2.6f;
    public const int OrderPulse = -11;
    public const float ReferenceHalfHeight = 5f;
    public const float TrailFraction = 0.11f;
    public static readonly float[] ModeSpeed =
    {
        1f,
        1.30f,
        1.65f
    };
    public static readonly string[] ModeNames =
    {
        _0xed3fe558._0xfb4364da(new byte[6] { 81, 86, 71, 67, 70, 91 }, 2),
        _0xed3fe558._0xfb4364da(new byte[5] { 124, 111, 126, 103, 106 }, 46),
        _0xed3fe558._0xfb4364da(new byte[5] { 15, 9, 14, 27, 25 }, 92)
    };
    /// <summary>m:ss for the clock, built without a culture-sensitive format call.</summary>
    public static string Clock(float _0xde3d080d)
    {
        int _0x727147c3 = Mathf.Max(0, Mathf.CeilToInt(_0xde3d080d));
        int _0x96f988bf = _0x727147c3 / 60;
        int _0x9db7a95b = _0x727147c3 % 60;
        return _0x96f988bf.ToString() + _0xed3fe558._0xfb4364da(new byte[1] { 218 }, 224) + (_0x9db7a95b < 10 ? _0xed3fe558._0xfb4364da(new byte[1] { 237 }, 221) : string.Empty) + _0x9db7a95b.ToString();
    }

    /// <summary>Wave spacing of the three phases, before the mode multiplier.</summary>
    public static float PhaseInterval(float _0x9f22b044)
    {
        if (_0x9f22b044 < 20f)
            return 2.40f;
        if (_0x9f22b044 < 48f)
            return Mathf.Lerp(2.40f, 1.70f, (_0x9f22b044 - 20f) / 28f);
        return Mathf.Lerp(1.70f, 1.25f, Mathf.Clamp01((_0x9f22b044 - 48f) / 27f));
    }

    public const float BoardCenterFraction = -0.08f;
    public const float MenuCenterFraction = -0.10f;
    public static readonly float[] ModeCadence =
    {
        1f,
        0.82f,
        0.68f
    };
    public const float RingSnapSeconds = 0.18f;
    public const float RoundSeconds = 75f;
    public const float HitGraceSeconds = 1.6f;
    public const int LaneCount = 4;
    public static int ClampOrder(int _0xc85ff00e)
    {
        return Mathf.Clamp(_0xc85ff00e, OrderMin, OrderMax);
    }

    public static int ClampMode(int _0x5491d021)
    {
        if (_0x5491d021 < 0)
            return 0;
        if (_0x5491d021 >= ModeCount)
            return ModeCount - 1;
        return _0x5491d021;
    }

    public const float DangerMinGapSeconds = 1.4f;
    public const int ModeCount = 3;
    public const float DangerFreeSeconds = 7f;
    public const float LastTenSeconds = 10f;
    public const float CrystalFraction = 0.40f;
    public const int OrderTrail = -12;
    public const int AbsorbScore = 10;
    public const int OrderShield = -8;
    public const float ShieldSpriteFactor = 0.86f;
    public const int BlockScore = 15;
    public const float PulseFraction = 0.16f;
    public const int MaxEnergy = 3;
    public const float RingSpriteFactor = 1.22f;
    public const float RailWidthFraction = 0.13f;
    /// <summary>A clean solve pays more the longer the chain holds, capped at x2.</summary>
    public static int WithChain(int _0x3af1841b, int _0x9d522ca1)
    {
        float _0xd6394b0f = 1f + Mathf.Min(_0x9d522ca1, ChainCap) * 0.1f;
        return Mathf.RoundToInt(_0x3af1841b * _0xd6394b0f);
    }

    public const float MenuDriftScale = 0.34f;
    public const float BurstFraction = 0.44f;
    public static string ModeName(int _0xc5f35298)
    {
        return ModeNames[ClampMode(_0xc5f35298)];
    }

    public static readonly float[] ModeSafetyWindow =
    {
        60f,
        42f,
        30f
    };
    public const float BuntingHeightFraction = 0.26f;
    public const int OrderRail = -17;
    public const float SpawnRadiusFraction = 1.25f;
    public const int OrderCrystal = -6;
    public const int ChainCap = 10;
    public const int OrderBurst = -4;
    public const float MenuBoardScale = 0.52f;
    /// <summary>Written out as text: a culture-sensitive ToString would print "1,00".</summary>
    public static readonly string[] ModeSpeedLabel =
    {
        _0xed3fe558._0xfb4364da(new byte[5] { 179, 250, 229, 251, 251 }, 203),
        _0xed3fe558._0xfb4364da(new byte[5] { 204, 133, 154, 135, 132 }, 180),
        _0xed3fe558._0xfb4364da(new byte[5] { 66, 11, 20, 12, 15 }, 58)
    };
    public const int OrderRingBase = -14;
    /// <summary>
    /// Two sector turns plus a quarter second of human reaction. No two hazards in
    /// DIFFERENT lanes may land closer than this, or the wave is physically unblockable.
    /// </summary>
    public const float SolveMarginSeconds = RingSnapSeconds * 2f + 0.25f;
    public const int OrderMax = -1;
}

internal static class _0xed3fe558
{
    internal static string _0xfb4364da(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}