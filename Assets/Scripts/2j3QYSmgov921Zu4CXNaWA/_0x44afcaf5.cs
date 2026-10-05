using DG.Tweening;
using UnityEngine;

/// <summary>
/// One pulse riding its lane inward. It carries a short fading trail, freezes while
/// the round is paused, and reports back to the director the moment it reaches the
/// ring radius - the director alone decides what that arrival means.
/// </summary>
public sealed class _0x44afcaf5 : MonoBehaviour
{
    private float _0x734a9005;
    private float _0xb28ac3f7;
    public bool _0xf73c58bd { get; private set; }

    public void _0xbccf66c0(_0x5c719e88 _0xf266e9d0, int _0xcece1414, bool _0x73f40ee0, Vector2 _0x1909122e, float _0x8c7c2644, float _0x04e88bd0, float _0x421c119b, Sprite _0xffdd2d93, Color _0x48ff6dcb, GameObject _0x84d69f20, float _0x49d9b050)
    {
        this._0x321d2724 = _0xf266e9d0;
        this._0xd2c2039f = _0xcece1414;
        this._0xf73c58bd = _0x73f40ee0;
        this._0xf249d142 = _0x1909122e;
        this._0x64c8a69e = _0xaf3d63d9.LaneDirection(_0xcece1414);
        this._0x734a9005 = _0x8c7c2644;
        this._0x9cf10b92 = _0x04e88bd0;
        this._0xb28ac3f7 = _0x421c119b;
        this._0x287e4b62 = false;
        this._0xfe1386a6 = this.GetComponent<SpriteRenderer>();
        if (this._0xfe1386a6 != null)
        {
            this._0xfe1386a6.sprite = _0xffdd2d93;
            this._0xfe1386a6.color = _0x48ff6dcb;
            this._0xfe1386a6.size = new Vector2(_0x49d9b050, _0x49d9b050);
            this._0xfe1386a6.sortingOrder = _0x5f9ac917.ClampOrder(_0x5f9ac917.OrderPulse);
            // The crimson shard art points along its flight direction; the teal orb is
            // symmetrical, so turning it costs nothing and keeps one code path.
            this.transform.localRotation = Quaternion.Euler(0f, 0f, _0xaf3d63d9.LaneAngle(_0xcece1414) + 180f);
        }

        if (_0x84d69f20 != null)
        {
            float[] _0xc67c10cb =
            {
                0.45f,
                0.26f,
                0.13f
            };
            for (int _0x44ea5940 = 0; _0x44ea5940 < this._0xf9267a08.Length; _0x44ea5940++)
            {
                GameObject _0xf0d7eeba = Instantiate(_0x84d69f20, this.transform);
                float _0x78339a2d = _0x49d9b050 * (0.55f + 0.42f * _0x44ea5940);
                // The host is rotated to face its lane, so stepping along local -x puts
                // the trail behind the pulse without any per-frame maths.
                _0xf0d7eeba.transform.localPosition = new Vector3(-_0x78339a2d, 0f, 0f);
                _0xf0d7eeba.transform.localRotation = Quaternion.identity;
                _0xf0d7eeba.transform.localScale = Vector3.one;
                SpriteRenderer _0xc8ca0931 = _0xf0d7eeba.GetComponent<SpriteRenderer>();
                if (_0xc8ca0931 == null)
                    continue;
                _0xc8ca0931.sprite = _0xffdd2d93;
                float _0x2cbfb145 = _0x49d9b050 * (0.68f - 0.14f * _0x44ea5940);
                _0xc8ca0931.size = new Vector2(_0x2cbfb145, _0x2cbfb145);
                _0xc8ca0931.sortingOrder = _0x5f9ac917.ClampOrder(_0x5f9ac917.OrderTrail);
                _0xc8ca0931.color = new Color(_0x48ff6dcb.r, _0x48ff6dcb.g, _0x48ff6dcb.b, _0xc67c10cb[_0x44ea5940]);
                this._0xf9267a08[_0x44ea5940] = _0xc8ca0931;
            }
        }

        this._0xf834c8e9();
        this.transform.localScale = Vector3.one;
        this.transform.DOScale(1.08f, 0.5f).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo);
    }

    private bool _0x287e4b62;
    private void _0xf834c8e9()
    {
        Vector2 _0x47f373b4 = this._0x8b93b285;
        this.transform.position = new Vector3(_0x47f373b4.x, _0x47f373b4.y, 0f);
    }

    public Vector2 _0x8b93b285
    {
        get
        {
            return this._0xf249d142 + this._0x64c8a69e * this._0x734a9005;
        }
    }

    private _0x5c719e88 _0x321d2724;
    private float _0x9cf10b92;
    private Vector2 _0xf249d142;
    public float _0xbc4ce891
    {
        get
        {
            return this._0x734a9005;
        }
    }

    private Vector2 _0x64c8a69e;
    /// <summary>Taken off the board without any effect on the round.</summary>
    public void _0xc8777490()
    {
        this._0x287e4b62 = true;
        DOTween.Kill(this.transform, true);
        Destroy(this.gameObject);
    }

    private void Update()
    {
        if (this._0x287e4b62 || this._0x321d2724 == null)
            return;
        if (!this._0x321d2724._0x59ac70b0)
            return;
        this._0x734a9005 -= this._0xb28ac3f7 * Time.deltaTime;
        if (this._0x734a9005 <= this._0x9cf10b92)
        {
            this._0x734a9005 = this._0x9cf10b92;
            this._0x287e4b62 = true;
            this._0xf834c8e9();
            this._0x321d2724._0xc80b45a3(this);
            return;
        }

        this._0xf834c8e9();
    }

    public int _0xd2c2039f { get; private set; }

    private readonly SpriteRenderer[] _0xf9267a08 = new SpriteRenderer[3];
    private SpriteRenderer _0xfe1386a6;
}