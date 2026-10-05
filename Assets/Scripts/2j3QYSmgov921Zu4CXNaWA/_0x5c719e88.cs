using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

/// <summary>
/// The round itself. A seeded schedule of pulses rides four diagonal lanes toward the
/// crystal; the player turns a ring carrying ONE blind sector so it meets the crimson
/// shards and leaves the teal charges a way in. Seventy-five seconds with at least one
/// spark left is a hold; an empty crystal ends the round at once.
///
/// RELIEF RULE (the reason a run can be photographed). While the round is younger than
/// the mode's safety window AND the crystal is down to its last spark, three things
/// happen: scheduled shards are dropped instead of released, a shard already in flight
/// is deflected at the ring instead of landing, and one charge is sent down the lane
/// opposite the shield - which a player who never touches a button absorbs for free.
/// That makes survival to the safety window a guarantee rather than a statistic. Past
/// it the rule switches off and the storm phase decides the round honestly.
/// </summary>
public sealed class _0x5c719e88 : MonoBehaviour
{
    public void _0x171586f4()
    {
        if (!this._0xf9d19540 || this._ring == null)
            return;
        this._ring._0xa2405884(-1);
    }

    private bool _0x77c8a86c;
    [SerializeField]
    private _0xbddc72e7 _hud;
    [SerializeField]
    private _0x17982c08 _pops;
    private void Start()
    {
        this._0xa80e9178 = _0x6a3f9ee1._0xdb647cc0;
        int _0x210304a3 = _0x6a3f9ee1.TakeAttempt();
        this._0xd81cbaf9 = new System.Random((this._0xa80e9178 * 7919) ^ (_0x210304a3 * 104729));
        this._0x93021e1f = _0x5f9ac917.ModeSafetyWindow[_0x5f9ac917.ClampMode(this._0xa80e9178)];
        int _0xcc364954 = this._0xd81cbaf9.Next(_0x5f9ac917.LaneCount);
        if (this._layout != null)
        {
            this._layout._0x41e42ff6();
            if (this._layout._0x18ff643c != null)
                this._0xc26150ec = this._layout._0x18ff643c.color;
        }

        if (this._ring != null && this._layout != null)
            this._ring._0xe16784e5(this._layout._0xb759e073, _0xcc364954);
        Transform _0xfcfa49e9 = this._0xa62d7e2a();
        if (_0xfcfa49e9 != null && this._hud != null)
            this._hud._0x7574155d(_0xfcfa49e9, this);
        if (this._pops != null)
            this._pops._0x0f28f2b2(this);
        if (this._tutorial != null)
            this._tutorial._0x2508cdf5();
        this._0x4a1a651e = this._0x705b59c9._0xd0c7301c(this._0xa80e9178, _0x210304a3, _0xcc364954);
        this._0x34125e08 = 0;
        this._0x5a64b7f5 = _0x5f9ac917.StartEnergy;
        this._0xd6a6a067 = 0;
        this._0xb5a638ae = 0;
        this._0xe30be91b = 0;
        this._0x131be58c = _0x5f9ac917.RoundSeconds;
        this._0x348c0a7e = IntroSeconds;
        this._0x8319c4f6 = 0f;
        this._0xf9d19540 = false;
        this._0x77c8a86c = false;
        this._0x5ee32186 = false;
        if (this._hud != null)
        {
            this._hud._0x8d3372a2(this._0x5a64b7f5);
            this._hud._0xb5573b62(0);
            this._hud._0x7c307dff(0);
            this._hud._0xf9895f63(_0x5f9ac917.ModeName(this._0xa80e9178));
            this._hud.SetClock(this._0x131be58c);
        }

        this._0xe123b658();
    }

    private void _0xe1c895a0(int _0x644b7b53)
    {
        if (_0x644b7b53 != this._0xe4b4df50 || this._0x77c8a86c || this._0xf9d19540)
            return;
        this._0x4d5d2bd4();
    }

    private void _0xe123b658()
    {
        if (this._layout == null || this._layout._0x18ff643c == null)
            return;
        Transform _0x32448530 = this._layout._0x18ff643c.transform;
        _0x32448530.localScale = Vector3.one;
        _0x32448530.DOScale(1.04f, 1.6f).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo);
    }

    private int _0xa80e9178;
    [SerializeField]
    private GameObject _burstPrefab;
    public void _0x8425ea1f()
    {
        if (!this._0xf9d19540 || this._ring == null)
            return;
        this._ring._0xa2405884(1);
    }

    private void _0x41066c8e()
    {
        if (this._layout == null)
            return;
        if (this._layout._0xc33103d7 != null)
            this._layout._0xc33103d7.DOShakePosition(0.3f, 0.12f, 14, 90f, false, true);
        SpriteRenderer _0x04445009 = this._layout._0x18ff643c;
        if (_0x04445009 == null)
            return;
        _0x04445009.color = _0xbe57dfde.Danger;
        _0x04445009.DOColor(this._0xc26150ec, 0.5f);
    }

    private readonly List<_0x44afcaf5> _0x06ad4238 = new List<_0x44afcaf5>();
    public void _0x317f874d()
    {
        if (this._0x77c8a86c || !this._0xf9d19540)
            return;
        this._0xf9d19540 = false;
        if (this._ring != null)
            this._ring._0x354f30e7 = true;
        if (this._hud != null)
            this._hud._0x939e212c(false);
        if (_0xfa2aadfc.Instance != null)
            _0xfa2aadfc.Instance._0xb6166d7b(false);
        if (this._pops != null)
            this._pops._0x89940594(this._0x5a64b7f5, this._0x131be58c);
        // A pause nobody closes would freeze the session, so it releases itself.
        this._0xe4b4df50++;
        int _0x30e4331a = this._0xe4b4df50;
        DOVirtual.DelayedCall(PauseReleaseSeconds, () => this._0xe1c895a0(_0x30e4331a), false);
    }

    private const float PauseReleaseSeconds = 9f;
    private Color _0xc26150ec = Color.white;
    [SerializeField]
    private _0xaf3d63d9 _layout;
    private int _0x34125e08;
    /// <summary>One guaranteed charge, aimed at the lane the shield is NOT covering.</summary>
    private void _0x345d9a40()
    {
        if (this._ring == null)
            return;
        this._0xa20f9b67(this._ring._0xe569d735(), false);
    }

    private readonly _0x7a38d85a _0x705b59c9 = new _0x7a38d85a();
    public void _0x113ee211()
    {
        if (_0xfa2aadfc.Instance == null)
            return;
        _0xfa2aadfc.Instance._0xb6166d7b(true);
        _0xfa2aadfc.Instance.LoadSceneByIndex(_0x9cf3c3e3._0xf290fefa.SCENE_0);
    }

    /// <summary>
    /// The body of the template's DEFAULT panel - reached through the public Panels
    /// list, because PanelController.GetPanel is private in this template.
    /// </summary>
    private Transform _0xa62d7e2a()
    {
        _0x64a8e136 _0xcaa9b8a6 = _0x64a8e136.Instance;
        if (_0xcaa9b8a6 == null || _0xcaa9b8a6.Panels == null)
            return null;
        int _0xc1a02a35 = _0x9cf3c3e3._0xea9b069c.DEFAULT;
        if (_0xc1a02a35 < 0 || _0xc1a02a35 >= _0xcaa9b8a6.Panels.Count)
            return null;
        _0xe645a9ed _0x1cb777e3 = _0xcaa9b8a6.Panels[_0xc1a02a35];
        if (_0x1cb777e3 == null || _0x1cb777e3.Content == null)
            return null;
        return _0x1cb777e3.Content.transform;
    }

    private float _0x8319c4f6;
    private void OnDestroy()
    {
        DOTween.Kill(this.transform, false);
    }

    private int _0xd6a6a067;
    [SerializeField]
    private GameObject _trailPrefab;
    private int _0xe4b4df50;
    [SerializeField]
    private Sprite _burstSprite;
    [SerializeField]
    private _0x2e46c1e3 _tutorial;
    private int _0xb5a638ae;
    private void _0xccf26f79()
    {
        if (this._layout == null || this._layout._0x18ff643c == null)
            return;
        Transform _0x3b3d600c = this._layout._0x18ff643c.transform;
        _0x3b3d600c.DOPunchScale(Vector3.one * 0.1f, 0.28f, 6, 0.6f);
    }

    private float _0x348c0a7e;
    public bool _0x59ac70b0
    {
        get
        {
            return this._0xf9d19540;
        }
    }

    private void _0x43ad8c1c(bool _0xc256317b)
    {
        if (this._0x77c8a86c)
            return;
        this._0x77c8a86c = true;
        this._0xf9d19540 = false;
        if (this._ring != null)
            this._ring._0x354f30e7 = true;
        for (int _0x2f8d395b = this._0x06ad4238.Count - 1; _0x2f8d395b >= 0; _0x2f8d395b--)
            if (this._0x06ad4238[_0x2f8d395b] != null)
                this._0x06ad4238[_0x2f8d395b]._0xc8777490();
        this._0x06ad4238.Clear();
        float _0x877a1a14 = Mathf.Clamp(_0x5f9ac917.RoundSeconds - this._0x131be58c, 0f, _0x5f9ac917.RoundSeconds);
        int _0x54794609 = Mathf.Max(0, this._0x5a64b7f5);
        _0x6a3f9ee1.Record(this._0xa80e9178, this._0xe30be91b, this._0xb5a638ae, _0x877a1a14);
        _0x9cf3c3e3._0x931bebe5._0x98ad77d8 = _0x9cf3c3e3._0x931bebe5._0x98ad77d8 + this._0xe30be91b;
        if (this._hud != null)
            this._hud._0x939e212c(false);
        if (this._pops == null)
            return;
        if (_0xc256317b)
            this._pops._0x13e91af6(_0x54794609, this._0xe30be91b, this._0xb5a638ae);
        else
            this._pops._0xade619e4(_0x877a1a14, this._0xe30be91b, this._0xb5a638ae);
    }

    private System.Random _0xd81cbaf9;
    public void _0xc22672f8()
    {
        _0x6a3f9ee1._0xdb647cc0 = _0x6a3f9ee1.NextMode(this._0xa80e9178);
        this._0xccb224bd();
    }

    [SerializeField]
    private Sprite _boonSprite;
    private int _0x5a64b7f5;
    public void _0xc80b45a3(_0x44afcaf5 _0xf16929f8)
    {
        if (_0xf16929f8 == null)
            return;
        this._0x06ad4238.Remove(_0xf16929f8);
        bool _0xaab7924a = this._ring != null && _0xf16929f8._0xd2c2039f == this._ring._0xa12529c0;
        if (_0xf16929f8._0xf73c58bd && _0xaab7924a)
        {
            this._0xd6a6a067++;
            if (this._0xd6a6a067 > this._0xb5a638ae)
                this._0xb5a638ae = this._0xd6a6a067;
            this._0xe30be91b += _0x5f9ac917.WithChain(_0x5f9ac917.BlockScore, this._0xd6a6a067);
            this._0xee354605(_0xf16929f8._0x8b93b285, _0xbe57dfde.Violet, 1.3f);
            if (this._ring != null && this._layout != null && this._layout._0x649d47e5 != null)
                this._ring.PunchSector(this._layout._0x649d47e5.transform);
            if (this._hud != null)
                this._hud._0x5ba7c4c7(_0x91a87d00._0xb41f9b80(new byte[5] { 134, 136, 139, 135, 143 }, 196), _0xbe57dfde.Violet);
        }
        else if (_0xf16929f8._0xf73c58bd && (this._0x8319c4f6 > 0f || this._0x7f543965))
        {
            // Shielded by the crystal's own flare: the cascade guard and the relief
            // rule both resolve a shard harmlessly, so neither can cost a spark.
            this._0xee354605(_0xf16929f8._0x8b93b285, _0xbe57dfde.Boon, 0.7f);
            if (this._hud != null)
                this._hud._0x5ba7c4c7(_0x91a87d00._0xb41f9b80(new byte[6] { 117, 99, 103, 106, 99, 98 }, 38), _0xbe57dfde.Boon);
        }
        else if (_0xf16929f8._0xf73c58bd)
        {
            this._0x5a64b7f5--;
            this._0xd6a6a067 = 0;
            this._0x8319c4f6 = _0x5f9ac917.HitGraceSeconds;
            this._0xee354605(_0xf16929f8._0x8b93b285, _0xbe57dfde.Danger, 1.4f);
            this._0x41066c8e();
            this._0x07d32d9b();
            if (this._hud != null)
                this._hud._0x5ba7c4c7(_0x91a87d00._0xb41f9b80(new byte[2] { 49, 45 }, 28), _0xbe57dfde.Danger);
        }
        else if (_0xaab7924a)
        {
            // Blocking your own supply is not damage, but it does break the chain.
            this._0xd6a6a067 = 0;
            this._0xee354605(_0xf16929f8._0x8b93b285, _0xbe57dfde.Spent, 0.6f);
            if (this._hud != null)
                this._hud._0x5ba7c4c7(_0x91a87d00._0xb41f9b80(new byte[14] { 197, 203, 200, 196, 204, 194, 195, 167, 212, 210, 215, 215, 203, 222 }, 135), _0xbe57dfde.Muted);
        }
        else
        {
            this._0xd6a6a067++;
            if (this._0xd6a6a067 > this._0xb5a638ae)
                this._0xb5a638ae = this._0xd6a6a067;
            int gain = _0x5f9ac917.WithChain(_0x5f9ac917.AbsorbScore, this._0xd6a6a067);
            if (this._0x5a64b7f5 < _0x5f9ac917.MaxEnergy)
            {
                this._0x5a64b7f5++;
                if (this._hud != null)
                {
                    this._hud._0x5ba7c4c7(_0x91a87d00._0xb41f9b80(new byte[2] { 92, 70 }, 119), _0xbe57dfde.Gold);
                    this._hud._0x309950c0(this._0x5a64b7f5 - 1);
                }
            }
            else
            {
                // A full crystal cannot be repaired, so the charge pays out instead.
                gain += _0x5f9ac917.WithChain(_0x5f9ac917.AbsorbScore, this._0xd6a6a067);
                if (this._hud != null)
                    this._hud._0x5ba7c4c7(_0x91a87d00._0xb41f9b80(new byte[8] { 186, 163, 176, 167, 179, 185, 186, 162 }, 245), _0xbe57dfde.Boon);
            }

            this._0xe30be91b += gain;
            this._0xccf26f79();
        }

        if (this._hud != null)
        {
            this._hud._0x8d3372a2(this._0x5a64b7f5);
            this._hud._0xb5573b62(this._0xe30be91b);
            this._hud._0x7c307dff(this._0xd6a6a067);
        }

        _0xf16929f8._0xc8777490();
        if (this._0x5a64b7f5 <= 0)
            this._0x43ad8c1c(false);
    }

    private void _0xee354605(Vector2 _0xa94dab1e, Color _0x17292922, float _0xd4dcf4fe)
    {
        if (this._burstPrefab == null || this._layout == null)
            return;
        GameObject _0x7dfffe08 = Instantiate(this._burstPrefab, this.transform);
        _0x7dfffe08.transform.position = new Vector3(_0xa94dab1e.x, _0xa94dab1e.y, 0f);
        _0x7dfffe08.transform.localScale = Vector3.one;
        SpriteRenderer _0xf8ebcd2c = _0x7dfffe08.GetComponent<SpriteRenderer>();
        if (_0xf8ebcd2c != null)
        {
            if (this._burstSprite != null)
                _0xf8ebcd2c.sprite = this._burstSprite;
            float _0x7689084e = this._layout._0x946072b6 * _0x5f9ac917.BurstFraction * _0xd4dcf4fe;
            _0xf8ebcd2c.size = new Vector2(_0x7689084e * 0.3f, _0x7689084e * 0.3f);
            _0xf8ebcd2c.sortingOrder = _0x5f9ac917.ClampOrder(_0x5f9ac917.OrderBurst);
            _0xf8ebcd2c.color = _0x17292922;
            DOTween.To(() => _0xf8ebcd2c.size, _0x5a0a1e00 => _0xf8ebcd2c.size = _0x5a0a1e00, new Vector2(_0x7689084e, _0x7689084e), 0.22f);
            _0xf8ebcd2c.DOFade(0f, 0.22f);
        }

        Destroy(_0x7dfffe08, 0.4f);
    }

    [SerializeField]
    private _0x8ebbcd1e _ring;
    private bool _0x5ee32186;
    private void _0xa20f9b67(int _0xd07199a4, bool _0x8226a04e)
    {
        GameObject _0x9bb1a8f7 = _0x8226a04e ? this._dangerPrefab : this._boonPrefab;
        if (_0x9bb1a8f7 == null || this._layout == null)
            return;
        GameObject _0x6f48af03 = Instantiate(_0x9bb1a8f7, this.transform);
        _0x44afcaf5 _0xf959cf53 = _0x6f48af03.GetComponent<_0x44afcaf5>();
        if (_0xf959cf53 == null)
            _0xf959cf53 = _0x6f48af03.AddComponent<_0x44afcaf5>();
        float _0x4a0018f3 = this._layout._0x32c3d67b - this._layout._0x038e2c28;
        float _0x7ef79f70 = _0x4a0018f3 / Mathf.Max(0.2f, this._0x705b59c9._0xb1beae6c);
        float _0xa943fb43 = this._layout._0x946072b6 * _0x5f9ac917.PulseFraction;
        _0xf959cf53._0xbccf66c0(this, _0xd07199a4, _0x8226a04e, this._layout._0x80c9e1c9, this._layout._0x32c3d67b, this._layout._0x038e2c28, _0x7ef79f70, _0x8226a04e ? this._dangerSprite : this._boonSprite, _0x8226a04e ? _0xbe57dfde.Danger : _0xbe57dfde.Boon, this._trailPrefab, _0xa943fb43);
        this._0x06ad4238.Add(_0xf959cf53);
    }

    /// <summary>Everything already close to the crystal fizzles out after a breach.</summary>
    private void _0x07d32d9b()
    {
        if (this._layout == null)
            return;
        float _0xc512288b = this._layout._0x038e2c28 * GraceSweepFactor;
        for (int _0x453da733 = this._0x06ad4238.Count - 1; _0x453da733 >= 0; _0x453da733--)
        {
            _0x44afcaf5 _0xdf9f687e = this._0x06ad4238[_0x453da733];
            if (_0xdf9f687e == null)
            {
                this._0x06ad4238.RemoveAt(_0x453da733);
                continue;
            }

            if (_0xdf9f687e._0xbc4ce891 > _0xc512288b)
                continue;
            this._0x06ad4238.RemoveAt(_0x453da733);
            this._0xee354605(_0xdf9f687e._0x8b93b285, _0xbe57dfde.WithAlpha(_0xbe57dfde.Muted, 0.8f), 0.5f);
            _0xdf9f687e._0xc8777490();
        }
    }

    private bool _0x7f543965
    {
        get
        {
            float _0xb38e870a = _0x5f9ac917.RoundSeconds - this._0x131be58c;
            return _0xb38e870a < this._0x93021e1f && this._0x5a64b7f5 <= 1;
        }
    }

    [SerializeField]
    private GameObject _dangerPrefab;
    private const float IntroSeconds = 1.2f;
    [SerializeField]
    private Sprite _dangerSprite;
    private float _0x93021e1f;
    private int _0xe30be91b;
    public void _0xccb224bd()
    {
        if (_0xfa2aadfc.Instance == null)
            return;
        _0xfa2aadfc.Instance._0xb6166d7b(true);
        _0xfa2aadfc.Instance._0x402afacb();
    }

    private List<PulseTicket> _0x4a1a651e;
    private void Update()
    {
        if (this._0x77c8a86c)
            return;
        if (!this._0xf9d19540)
        {
            if (this._0x348c0a7e <= 0f)
                return;
            this._0x348c0a7e -= Time.deltaTime;
            if (this._0x348c0a7e > 0f)
                return;
            this._0xf9d19540 = true;
            if (this._ring != null)
                this._ring._0x354f30e7 = false;
            return;
        }

        if (this._0x8319c4f6 > 0f)
            this._0x8319c4f6 -= Time.deltaTime;
        this._0x131be58c -= Time.deltaTime;
        if (this._hud != null)
            this._hud.SetClock(Mathf.Max(0f, this._0x131be58c));
        bool _0xe674c5ed = this._0x7f543965;
        if (_0xe674c5ed && !this._0x5ee32186)
        {
            this._0x5ee32186 = true;
            this._0x345d9a40();
        }
        else if (!_0xe674c5ed)
        {
            this._0x5ee32186 = false;
        }

        float _0x7164004f = _0x5f9ac917.RoundSeconds - this._0x131be58c;
        while (this._0x4a1a651e != null && this._0x34125e08 < this._0x4a1a651e.Count && this._0x4a1a651e[this._0x34125e08].ReleaseTime <= _0x7164004f)
        {
            PulseTicket _0x5c6af975 = this._0x4a1a651e[this._0x34125e08];
            this._0x34125e08++;
            if (_0x5c6af975.IsDanger && _0xe674c5ed)
                continue;
            this._0xa20f9b67(_0x5c6af975.Lane, _0x5c6af975.IsDanger);
        }

        if (this._0x131be58c <= 0f)
            this._0x43ad8c1c(true);
    }

    [SerializeField]
    private GameObject _boonPrefab;
    public void _0x4d5d2bd4()
    {
        if (_0xc720b4f1.Instance != null)
            _0xc720b4f1.Instance._0xd1a75cd7();
        if (_0xfa2aadfc.Instance != null)
            _0xfa2aadfc.Instance._0xb6166d7b(true);
        if (this._0x77c8a86c)
            return;
        if (this._hud != null)
            this._hud._0x939e212c(true);
        this._0xf9d19540 = true;
        if (this._ring != null)
            this._ring._0x354f30e7 = false;
    }

    private bool _0xf9d19540;
    private const float GraceSweepFactor = 1.4f;
    private float _0x131be58c;
}

internal static class _0x91a87d00
{
    internal static string _0xb41f9b80(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}