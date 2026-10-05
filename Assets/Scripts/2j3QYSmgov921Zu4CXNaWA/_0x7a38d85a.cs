using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Builds the wave schedule of one round from a seed and then CHECKS its own output
/// before handing it over, so no round is ever shipped that the ring cannot answer.
/// Nothing about a round is fixed except the last-resort fallback: release moments,
/// lanes, colours, the double waves and the opening sector all come from the seeded
/// generator, which is why two runs never look the same.
///
/// The rules a schedule has to satisfy:
///   1. no crimson shard before DangerFreeSeconds - the opening is readable;
///   2. two shards in DIFFERENT lanes never land closer than SolveMarginSeconds
///      (two ring snaps plus a quarter second), which is the physical limit of the
///      shield - any closer and the wave is unanswerable, not hard;
///   3. two shards in the SAME lane keep DangerMinGapSeconds apart;
///   4. at least twelve teal charges, and at least two in every lane, so the energy
///      bar is refillable by playing rather than by luck;
///   5. at least six pulses land between 12 s and 34 s, so the board is busy while
///      the review screenshots are taken.
/// </summary>
public sealed class _0x7a38d85a
{
    private const int MinChargesPerLane = 2;
    private const float BusyTo = 34f;
    private const int MaxAttempts = 20;
    private void _0x3ed5f861(int[] _0xff7704e6, System.Random _0x764632bd)
    {
        for (int _0x57540338 = _0xff7704e6.Length - 1; _0x57540338 > 0; _0x57540338--)
        {
            int _0xfa6ded66 = _0x764632bd.Next(_0x57540338 + 1);
            int _0x68db12c8 = _0xff7704e6[_0x57540338];
            _0xff7704e6[_0x57540338] = _0xff7704e6[_0xfa6ded66];
            _0xff7704e6[_0xfa6ded66] = _0x68db12c8;
        }
    }

    private const float BusyFrom = 12f;
    /// <summary>The only fixed round in the whole generator - insurance, not a game.</summary>
    public List<PulseTicket> _0xdcb956e3()
    {
        List<PulseTicket> _0xd1f1ec3a = new List<PulseTicket>();
        float _0x364ddf65 = FirstRelease;
        int _0x161415ab = 0;
        int _0x9c10cee9 = 0;
        while (_0x364ddf65 <= LastRelease)
        {
            bool _0x6f490cb4 = _0x364ddf65 >= _0x5f9ac917.DangerFreeSeconds && (_0x9c10cee9 % 3) != 0;
            _0xd1f1ec3a.Add(new PulseTicket(_0x364ddf65, _0x161415ab, _0x6f490cb4));
            _0x161415ab = (_0x161415ab + 1) % _0x5f9ac917.LaneCount;
            _0x9c10cee9++;
            _0x364ddf65 += Mathf.Max(_0x5f9ac917.SolveMarginSeconds + 0.4f, _0x5f9ac917.PhaseInterval(_0x364ddf65));
        }

        return _0xd1f1ec3a;
    }

    public bool _0x4bf063b0 { get; private set; }

    private const float FirstRelease = 1.8f;
    private const float LastRelease = 70f;
    /// <summary>
    /// Demotes a shard to a charge whenever keeping it would make the wave
    /// unanswerable. Doing it HERE rather than only in Validate means the generator
    /// almost always succeeds on its first seed instead of rerolling twenty times.
    /// </summary>
    private bool _0x0463761a(bool _0xf55766e2, float _0xc96977a5, int _0xd78ff9c2, float[] _0x3b0f5541, ref float _0xba00229b, ref int _0x42f41ff2)
    {
        if (!_0xf55766e2)
            return false;
        float _0x3afa7c5f = _0xc96977a5 + this._0xb1beae6c;
        if (_0x3afa7c5f - _0x3b0f5541[_0xd78ff9c2] < _0x5f9ac917.DangerMinGapSeconds)
            return false;
        if (_0x42f41ff2 >= 0 && _0x42f41ff2 != _0xd78ff9c2 && _0x3afa7c5f - _0xba00229b < _0x5f9ac917.SolveMarginSeconds)
            return false;
        _0x3b0f5541[_0xd78ff9c2] = _0x3afa7c5f;
        _0xba00229b = _0x3afa7c5f;
        _0x42f41ff2 = _0xd78ff9c2;
        return true;
    }

    private List<PulseTicket> _0x3e5f6801(System.Random _0x321f1889, int _0x1b7ccb07)
    {
        float _0x41c3da45 = _0x5f9ac917.ModeCadence[_0x1b7ccb07];
        List<PulseTicket> _0xa8fdd0f0 = new List<PulseTicket>();
        int[] _0xacbd470c =
        {
            0,
            1,
            2,
            3
        };
        this._0x3ed5f861(_0xacbd470c, _0x321f1889);
        int _0x636def12 = 0;
        float[] _0x774f67c3 = new float[_0x5f9ac917.LaneCount];
        for (int _0x75f2334b = 0; _0x75f2334b < _0x5f9ac917.LaneCount; _0x75f2334b++)
            _0x774f67c3[_0x75f2334b] = -99f;
        float _0x61baabc7 = -99f;
        int _0xb975df25 = -1;
        float _0x17105a3e = FirstRelease + (float)_0x321f1889.NextDouble() * 0.5f;
        while (_0x17105a3e <= LastRelease)
        {
            if (_0x636def12 >= _0xacbd470c.Length)
            {
                this._0x3ed5f861(_0xacbd470c, _0x321f1889);
                _0x636def12 = 0;
            }

            int _0x9119283c = _0xacbd470c[_0x636def12];
            _0x636def12++;
            bool _0x9426e015 = _0x17105a3e >= _0x5f9ac917.DangerFreeSeconds && _0x321f1889.NextDouble() < _0x5f9ac917.PhaseDangerShare(_0x17105a3e);
            _0x9426e015 = this._0x0463761a(_0x9426e015, _0x17105a3e, _0x9119283c, _0x774f67c3, ref _0x61baabc7, ref _0xb975df25);
            _0xa8fdd0f0.Add(new PulseTicket(_0x17105a3e, _0x9119283c, _0x9426e015));
            // A double wave adds a second pulse in another lane on the same beat. It
            // is always a charge: two shards on one beat would break rule 2 by design.
            if (_0x321f1889.NextDouble() < DoubleWaveChance)
            {
                int _0x57d791f1 = (_0x9119283c + 1 + _0x321f1889.Next(_0x5f9ac917.LaneCount - 1)) % _0x5f9ac917.LaneCount;
                _0xa8fdd0f0.Add(new PulseTicket(_0x17105a3e + 0.05f, _0x57d791f1, false));
            }

            float _0xe3a5be05 = _0x5f9ac917.PhaseInterval(_0x17105a3e) * _0x41c3da45;
            float _0x78a23edc = 1f + ((float)_0x321f1889.NextDouble() * 2f - 1f) * JitterShare;
            _0x17105a3e += Mathf.Max(0.5f, _0xe3a5be05 * _0x78a23edc);
        }

        return _0xa8fdd0f0;
    }

    public bool _0x72cb285b(List<PulseTicket> _0xba91cba5)
    {
        if (_0xba91cba5 == null || _0xba91cba5.Count < 16)
            return false;
        int _0x581f8833 = 0;
        int _0x97a5e96e = 0;
        int[] _0x56771201 = new int[_0x5f9ac917.LaneCount];
        float[] _0xd4ecdf34 = new float[_0x5f9ac917.LaneCount];
        for (int _0x7203a6a8 = 0; _0x7203a6a8 < _0x5f9ac917.LaneCount; _0x7203a6a8++)
            _0xd4ecdf34[_0x7203a6a8] = -99f;
        float _0x92b47a7c = -99f;
        int _0xd650ecde = -1;
        for (int _0x1abe50d4 = 0; _0x1abe50d4 < _0xba91cba5.Count; _0x1abe50d4++)
        {
            PulseTicket _0xd0753ec9 = _0xba91cba5[_0x1abe50d4];
            if (_0xd0753ec9.Lane < 0 || _0xd0753ec9.Lane >= _0x5f9ac917.LaneCount)
                return false;
            float _0x6988163d = _0xd0753ec9.ReleaseTime + this._0xb1beae6c;
            if (_0xd0753ec9.IsDanger)
            {
                if (_0xd0753ec9.ReleaseTime < _0x5f9ac917.DangerFreeSeconds)
                    return false;
                if (_0x6988163d - _0xd4ecdf34[_0xd0753ec9.Lane] < _0x5f9ac917.DangerMinGapSeconds)
                    return false;
                if (_0xd650ecde >= 0 && _0xd650ecde != _0xd0753ec9.Lane && _0x6988163d - _0x92b47a7c < _0x5f9ac917.SolveMarginSeconds)
                    return false;
                _0xd4ecdf34[_0xd0753ec9.Lane] = _0x6988163d;
                _0x92b47a7c = _0x6988163d;
                _0xd650ecde = _0xd0753ec9.Lane;
            }
            else
            {
                _0x581f8833++;
                _0x56771201[_0xd0753ec9.Lane]++;
            }

            if (_0x6988163d >= BusyFrom && _0x6988163d <= BusyTo)
                _0x97a5e96e++;
        }

        if (_0x581f8833 < MinCharges)
            return false;
        for (int _0x6a824e05 = 0; _0x6a824e05 < _0x5f9ac917.LaneCount; _0x6a824e05++)
            if (_0x56771201[_0x6a824e05] < MinChargesPerLane)
                return false;
        return _0x97a5e96e >= MinBusyPulses;
    }

    private const int MinCharges = 12;
    private const float DoubleWaveChance = 0.18f;
    private const float JitterShare = 0.12f;
    public List<PulseTicket> _0xd0c7301c(int _0x78b115ea, int _0x0f05dcb5, int _0xd83d8970)
    {
        int _0x9edc366e = _0x5f9ac917.ClampMode(_0x78b115ea);
        this._0xb1beae6c = _0x5f9ac917.PulseTravelSeconds / _0x5f9ac917.ModeSpeed[_0x9edc366e];
        this._0x4bf063b0 = false;
        for (int _0xa8fcd7db = 0; _0xa8fcd7db < MaxAttempts; _0xa8fcd7db++)
        {
            int _0x62282a5c = (_0x9edc366e * 7919) ^ ((_0x0f05dcb5 + _0xa8fcd7db * 31) * 104729);
            System.Random _0xf1357ce7 = new System.Random(_0x62282a5c);
            List<PulseTicket> _0xa42e0a13 = this._0x3e5f6801(_0xf1357ce7, _0x9edc366e);
            if (this._0x72cb285b(_0xa42e0a13))
            {
                {
#if B_LOGS
                    {
                        Debug.Log(_0xe42b887a._0x0bf4ce52(new byte[13] { 95, 118, 107, 113, 106, 96, 89, 36, 119, 97, 97, 96, 57 }, 4) + _0x62282a5c.ToString() + _0xe42b887a._0x0bf4ce52(new byte[6] { 66, 15, 13, 6, 7, 95 }, 98) + _0x9edc366e.ToString() + _0xe42b887a._0x0bf4ce52(new byte[9] { 167, 244, 239, 238, 226, 235, 227, 183, 186 }, 135) + _0xd83d8970.ToString() + _0xe42b887a._0x0bf4ce52(new byte[7] { 195, 148, 130, 149, 134, 144, 222 }, 227) + _0xa42e0a13.Count.ToString());
                    }
#endif
                }

                return _0xa42e0a13;
            }
        }

        {
#if B_LOGS
            {
                Debug.Log(_0xe42b887a._0x0bf4ce52(new byte[33] { 202, 227, 254, 228, 255, 245, 204, 177, 226, 242, 249, 244, 245, 228, 253, 244, 177, 247, 244, 253, 253, 177, 243, 240, 242, 250, 177, 240, 247, 229, 244, 227, 177 }, 145) + MaxAttempts.ToString() + _0xe42b887a._0x0bf4ce52(new byte[9] { 189, 252, 233, 233, 248, 240, 237, 233, 238 }, 157));
            }
#endif
        }

        this._0x4bf063b0 = true;
        return this._0xdcb956e3();
    }

    private const int MinBusyPulses = 6;
    public float _0xb1beae6c { get; private set; }
}

internal static class _0xe42b887a
{
    internal static string _0x0bf4ce52(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}