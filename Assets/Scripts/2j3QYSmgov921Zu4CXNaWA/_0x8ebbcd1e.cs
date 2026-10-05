using DG.Tweening;
using UnityEngine;

/// <summary>
/// Owns which lane the single blind sector of the ring is covering. TURN L and
/// TURN R move it one lane at a time; while the 0.18 s snap plays one further turn
/// is remembered, so a quick double tap is honoured instead of swallowed. Two taps
/// reach the opposite lane in 0.36 s, well inside a pulse's 2.6 s flight - which is
/// what makes every wave physically answerable.
/// </summary>
public sealed class _0x8ebbcd1e : MonoBehaviour
{
    private bool _0x787b5b0e = true;
    private void _0xdf3e74f6(int _0x60ee1a1b)
    {
        this._0x6878e98c = true;
        this._0xe9e3d8cc = Wrap(this._0xe9e3d8cc + _0x60ee1a1b);
        float _0x8c66965d = this._0x46fcef0d.localEulerAngles.z + _0x60ee1a1b * 90f;
        DOTween.Kill(this._0x46fcef0d, true);
        this._0x46fcef0d.DOLocalRotate(new Vector3(0f, 0f, _0x8c66965d), _0x5f9ac917.RingSnapSeconds, RotateMode.FastBeyond360).SetEase(Ease.OutBack, 1.15f).OnComplete(() => this._0x6bfaa694());
    }

    private Transform _0x46fcef0d;
    public bool _0x354f30e7
    {
        get
        {
            return this._0x787b5b0e;
        }

        set
        {
            this._0x787b5b0e = value;
        }
    }

    private bool _0x6878e98c;
    private static int Wrap(int _0xe5630c2f)
    {
        return ((_0xe5630c2f % _0x5f9ac917.LaneCount) + _0x5f9ac917.LaneCount) % _0x5f9ac917.LaneCount;
    }

    public int _0xa12529c0
    {
        get
        {
            return this._0xe9e3d8cc;
        }
    }

    private int _0x541ef56d;
    private int _0xe9e3d8cc;
    public void PunchSector(Transform _0xe84d55ee)
    {
        if (_0xe84d55ee == null)
            return;
        DOTween.Kill(_0xe84d55ee, true);
        _0xe84d55ee.localScale = Vector3.one;
        _0xe84d55ee.DOPunchScale(Vector3.one * 0.12f, 0.2f, 6, 0.6f);
    }

    /// <summary>The lane directly across the crystal from the shield.</summary>
    public int _0xe569d735()
    {
        return Wrap(this._0xe9e3d8cc + 2);
    }

    public void _0xe16784e5(Transform _0x9f619e95, int _0x8177f4e0)
    {
        this._0x46fcef0d = _0x9f619e95;
        this._0xe9e3d8cc = Wrap(_0x8177f4e0);
        this._0x541ef56d = 0;
        this._0x6878e98c = false;
        if (this._0x46fcef0d != null)
            this._0x46fcef0d.localRotation = Quaternion.Euler(0f, 0f, this._0xe9e3d8cc * 90f);
    }

    public void _0xa2405884(int _0xefc50372)
    {
        if (this._0x787b5b0e || this._0x46fcef0d == null)
            return;
        if (this._0x6878e98c)
        {
            if (this._0x541ef56d == 0)
                this._0x541ef56d = _0xefc50372 >= 0 ? 1 : -1;
            return;
        }

        this._0xdf3e74f6(_0xefc50372 >= 0 ? 1 : -1);
    }

    private void _0x6bfaa694()
    {
        this._0x6878e98c = false;
        if (this._0x541ef56d == 0)
            return;
        int _0x8e48ef70 = this._0x541ef56d;
        this._0x541ef56d = 0;
        this._0xdf3e74f6(_0x8e48ef70);
    }
}