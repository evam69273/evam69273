using UnityEngine;

/// <summary>
/// Builds the carnival stage out of world sprites and derives EVERY radius and size
/// from the camera, never from a world-space literal: four diagonal rails, the ring
/// track, the single blind shield sector that rides it, and the crystal in the middle.
/// The same component drives the live board in the round and the small diorama behind
/// the menu - only <c>_boardScale</c> and <c>_centerFraction</c> differ.
/// </summary>
public sealed class _0xaf3d63d9 : MonoBehaviour
{
    public Vector2 _0x80c9e1c9 { get; private set; }

    [SerializeField]
    private GameObject _ringBasePrefab;
    [SerializeField]
    private GameObject _crystalPrefab;
    private SpriteRenderer _0xc551bf0f;
    [SerializeField]
    private bool _withBunting = true;
    public float _0xd37889d7 { get; private set; }

    [SerializeField]
    private GameObject _shieldArcPrefab;
    [SerializeField]
    private Camera _camera;
    [SerializeField]
    private float _boardScale = 1f;
    public SpriteRenderer _0x649d47e5
    {
        get
        {
            return this._0xc551bf0f;
        }
    }

    public float _0xcdf18321 { get; private set; }

    public static Vector2 LaneDirection(int _0x880af04b)
    {
        float _0xbba94816 = LaneAngle(_0x880af04b) * Mathf.Deg2Rad;
        return new Vector2(Mathf.Cos(_0xbba94816), Mathf.Sin(_0xbba94816));
    }

    public float _0x946072b6 { get; private set; }

    private void _0xdfae8b07()
    {
        if (this._crystalPrefab == null)
            return;
        GameObject _0x46d21101 = Instantiate(this._crystalPrefab, this._0x9acd206b);
        _0x46d21101.transform.localPosition = Vector3.zero;
        _0x46d21101.transform.localScale = Vector3.one;
        this._0xa2ef39b2 = _0x46d21101.GetComponent<SpriteRenderer>();
        if (this._0xa2ef39b2 == null)
            return;
        float _0x540f80f5 = this._0x946072b6 * _0x5f9ac917.CrystalFraction * Mathf.Max(0.1f, this._boardScale);
        this._0xa2ef39b2.size = new Vector2(_0x540f80f5, _0x540f80f5);
        this._0xa2ef39b2.sortingOrder = _0x5f9ac917.ClampOrder(_0x5f9ac917.OrderCrystal);
    }

    public Transform _0xb759e073
    {
        get
        {
            return this._0x6e7e9877;
        }
    }

    private void _0xed904d56()
    {
        if (this._railPrefab == null)
            return;
        float _0x6c4d2a6c = Mathf.Max(0.2f, this._0x32c3d67b - this._0x038e2c28 + this._0x038e2c28 * 0.2f);
        float _0xc2c2b6c4 = (this._0x32c3d67b + this._0x038e2c28) * 0.5f;
        for (int _0x5481929f = 0; _0x5481929f < _0x5f9ac917.LaneCount; _0x5481929f++)
        {
            GameObject _0xfeb2ccf0 = Instantiate(this._railPrefab, this._0x9acd206b);
            Vector2 _0x96d8e462 = LaneDirection(_0x5481929f) * _0xc2c2b6c4;
            _0xfeb2ccf0.transform.localPosition = new Vector3(_0x96d8e462.x, _0x96d8e462.y, 0f);
            _0xfeb2ccf0.transform.localRotation = Quaternion.Euler(0f, 0f, LaneAngle(_0x5481929f) - 90f);
            _0xfeb2ccf0.transform.localScale = Vector3.one;
            SpriteRenderer _0x2ea3f581 = _0xfeb2ccf0.GetComponent<SpriteRenderer>();
            if (_0x2ea3f581 == null)
                continue;
            _0x2ea3f581.size = new Vector2(this._0x946072b6 * _0x5f9ac917.RailWidthFraction, _0x6c4d2a6c);
            _0x2ea3f581.sortingOrder = _0x5f9ac917.ClampOrder(_0x5f9ac917.OrderRail);
            _0x2ea3f581.color = new Color(1f, 1f, 1f, 0.55f);
        }
    }

    public Transform _0xc33103d7
    {
        get
        {
            return this._0x9acd206b;
        }
    }

    private SpriteRenderer _0xa2ef39b2;
    [SerializeField]
    private float _centerFraction = _0x5f9ac917.BoardCenterFraction;
    /// <summary>Lane 0 runs up-right; lanes 1..3 follow counter-clockwise, 90 apart.</summary>
    public static float LaneAngle(int _0x41473c85)
    {
        return 45f + 90f * (((_0x41473c85 % _0x5f9ac917.LaneCount) + _0x5f9ac917.LaneCount) % _0x5f9ac917.LaneCount);
    }

    public float _0x038e2c28 { get; private set; }

    private void _0xcd4a0d7d()
    {
        GameObject _0xed9f8e99 = new GameObject(_0x17390347._0x80892142(new byte[10] { 12, 55, 54, 58, 51, 59, 13, 54, 49, 56 }, 95));
        this._0x6e7e9877 = _0xed9f8e99.transform;
        this._0x6e7e9877.SetParent(this._0x9acd206b, false);
        this._0x6e7e9877.localPosition = Vector3.zero;
        this._0x6e7e9877.localScale = Vector3.one;
        if (this._ringBasePrefab != null)
        {
            // The track itself does NOT turn with the sector, so it hangs off the
            // board root and only the blind sector rides the rotating ring.
            GameObject _0xc52d2e0b = Instantiate(this._ringBasePrefab, this._0x9acd206b);
            _0xc52d2e0b.transform.localPosition = Vector3.zero;
            _0xc52d2e0b.transform.localScale = Vector3.one;
            SpriteRenderer _0x7f951fa3 = _0xc52d2e0b.GetComponent<SpriteRenderer>();
            if (_0x7f951fa3 != null)
            {
                float _0xd4f82fa5 = this._0x038e2c28 * 2f * _0x5f9ac917.RingSpriteFactor;
                _0x7f951fa3.size = new Vector2(_0xd4f82fa5, _0xd4f82fa5);
                _0x7f951fa3.sortingOrder = _0x5f9ac917.ClampOrder(_0x5f9ac917.OrderRingBase);
            }
        }

        if (this._shieldArcPrefab == null)
            return;
        GameObject _0x9959504d = Instantiate(this._shieldArcPrefab, this._0x6e7e9877);
        Vector2 _0xdb14e399 = LaneDirection(0) * this._0x038e2c28;
        _0x9959504d.transform.localPosition = new Vector3(_0xdb14e399.x, _0xdb14e399.y, 0f);
        _0x9959504d.transform.localRotation = Quaternion.Euler(0f, 0f, LaneAngle(0) - 90f);
        _0x9959504d.transform.localScale = Vector3.one;
        this._0xc551bf0f = _0x9959504d.GetComponent<SpriteRenderer>();
        if (this._0xc551bf0f == null)
            return;
        float _0x82cadb77 = this._0x038e2c28 * 2f * _0x5f9ac917.ShieldSpriteFactor;
        this._0xc551bf0f.size = new Vector2(_0x82cadb77, _0x82cadb77);
        this._0xc551bf0f.sortingOrder = _0x5f9ac917.ClampOrder(_0x5f9ac917.OrderShield);
    }

    public Vector2 _0x98def0ff(int _0x270af3a3, float _0x5ca50f43)
    {
        return this._0x80c9e1c9 + LaneDirection(_0x270af3a3) * _0x5ca50f43;
    }

    public void _0x41e42ff6()
    {
        Camera _0xa87484f1 = this._0x8d7f5c6e;
        this._0xd37889d7 = _0xa87484f1 != null ? _0xa87484f1.orthographicSize : _0x5f9ac917.ReferenceHalfHeight;
        this._0x946072b6 = _0xa87484f1 != null ? this._0xd37889d7 * _0xa87484f1.aspect : this._0xd37889d7 * 0.45f;
        this._0xcdf18321 = (this._0x946072b6 / (_0x5f9ac917.ReferenceHalfHeight * 0.45f)) * Mathf.Max(0.1f, this._boardScale);
        this._0x80c9e1c9 = new Vector2(0f, this._0xd37889d7 * this._centerFraction);
        this._0x038e2c28 = this._0x946072b6 * _0x5f9ac917.RingRadiusFraction * Mathf.Max(0.1f, this._boardScale);
        // A diagonal spawn point sits at radius/sqrt(2) on both axes, so the furthest
        // the board may reach sideways is bounded by the camera, not by the wish.
        float _0x3a21a461 = this._0x946072b6 * _0x5f9ac917.PulseFraction * 0.5f * Mathf.Max(0.1f, this._boardScale);
        float _0xb1e175f3 = (this._0x946072b6 * 0.97f - _0x3a21a461) / Mathf.Sqrt(0.5f);
        float _0xd527e47e = this._0x946072b6 * _0x5f9ac917.SpawnRadiusFraction * Mathf.Max(0.1f, this._boardScale);
        this._0x32c3d67b = Mathf.Min(_0xd527e47e, _0xb1e175f3);
        GameObject _0x24916f5b = new GameObject(_0x17390347._0x80892142(new byte[13] { 164, 134, 149, 137, 142, 145, 134, 139, 180, 147, 134, 128, 130 }, 231));
        this._0x9acd206b = _0x24916f5b.transform;
        this._0x9acd206b.SetParent(this.transform, false);
        this._0x9acd206b.position = new Vector3(this._0x80c9e1c9.x, this._0x80c9e1c9.y, 0f);
        this._0x73cf7c2a();
        this._0xed904d56();
        this._0xcd4a0d7d();
        this._0xdfae8b07();
    }

    [SerializeField]
    private GameObject _buntingPrefab;
    public SpriteRenderer _0x18ff643c
    {
        get
        {
            return this._0xa2ef39b2;
        }
    }

    [SerializeField]
    private GameObject _railPrefab;
    private Transform _0x9acd206b;
    private void _0x73cf7c2a()
    {
        if (!this._withBunting || this._buntingPrefab == null)
            return;
        GameObject _0x553ab78f = Instantiate(this._buntingPrefab, this._0x9acd206b);
        _0x553ab78f.transform.localPosition = new Vector3(0f, this._0xd37889d7 * 0.74f - this._0x80c9e1c9.y, 0f);
        _0x553ab78f.transform.localScale = Vector3.one;
        SpriteRenderer _0x2d0eb1e9 = _0x553ab78f.GetComponent<SpriteRenderer>();
        if (_0x2d0eb1e9 == null)
            return;
        _0x2d0eb1e9.size = new Vector2(this._0x946072b6 * 2.1f, this._0x946072b6 * _0x5f9ac917.BuntingHeightFraction);
        _0x2d0eb1e9.sortingOrder = _0x5f9ac917.ClampOrder(_0x5f9ac917.OrderBunting);
        _0x2d0eb1e9.color = new Color(1f, 1f, 1f, 0.9f);
    }

    private Transform _0x6e7e9877;
    public Camera _0x8d7f5c6e
    {
        get
        {
            return this._camera != null ? this._camera : Camera.main;
        }
    }

    public float _0x32c3d67b { get; private set; }
}

internal static class _0x17390347
{
    internal static string _0x80892142(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}