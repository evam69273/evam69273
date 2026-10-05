using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class _0x3dc7a696 : MonoBehaviour
{
    private void OnDrawGizmos()
    {
        Gizmos.color = this._0xe88ab816;
        Matrix4x4 _0xb7f96518 = Gizmos.matrix;
        Gizmos.matrix = Matrix4x4.TRS(this.transform.position, this.transform.rotation, Vector3.one);
        if (this._0xc71aaf31.orthographic)
        {
            float _0x6da0b718 = this._0xc71aaf31.farClipPlane - this._0xc71aaf31.nearClipPlane;
            float _0x24dafe17 = (this._0xc71aaf31.farClipPlane + this._0xc71aaf31.nearClipPlane) * 0.5f;
            Gizmos.DrawWireCube(new Vector3(0, 0, _0x24dafe17), new Vector3(this._0xc71aaf31.orthographicSize * 2 * this._0xc71aaf31.aspect, this._0xc71aaf31.orthographicSize * 2, _0x6da0b718));
        }
        else
        {
            Gizmos.DrawFrustum(Vector3.zero, this._0xc71aaf31.fieldOfView, this._0xc71aaf31.farClipPlane, this._0xc71aaf31.nearClipPlane, this._0xc71aaf31.aspect);
        }

        Gizmos.matrix = _0xb7f96518;
    }

    private float _0xb8d60a06 = 1;
    private Vector3 _0x52ac8c14 { get; set; }
    private Vector3 _0x45c2d27c { get; set; }
    private float _0x13f7f10d { get; set; }

    private static _0x3dc7a696 _0x0a671c97;
    private _0x8ba3f057 _0xd19516ff = _0x8ba3f057.Portrait;
    private Vector3 _0x81d6baf8 { get; set; }

    private void _0x9eba6b40()
    {
        float _0xadcea5b7, _0x6eb6525a, _0x4ba4c418, _0xf1a231b4;
        if (this._0xd19516ff == _0x8ba3f057.Landscape)
            this._0xc71aaf31.orthographicSize = 1f / this._0xc71aaf31.aspect * this._0xb8d60a06 / 2f;
        else
            this._0xc71aaf31.orthographicSize = this._0xb8d60a06 / 2f;
        this._0x13f7f10d = 2f * this._0xc71aaf31.orthographicSize;
        this._0x710bec2f = this._0x13f7f10d * this._0xc71aaf31.aspect;
        float _0x43065d76 = this._0xc71aaf31.transform.position.x;
        float _0x30ecb5c0 = this._0xc71aaf31.transform.position.y;
        _0xadcea5b7 = _0x43065d76 - this._0x710bec2f / 2;
        _0x6eb6525a = _0x43065d76 + this._0x710bec2f / 2;
        _0x4ba4c418 = _0x30ecb5c0 + this._0x13f7f10d / 2;
        _0xf1a231b4 = _0x30ecb5c0 - this._0x13f7f10d / 2;
        this._0x8f791e23 = new Vector3(_0xadcea5b7, _0xf1a231b4, 0);
        this._0x0aa2e876 = new Vector3(_0x43065d76, _0xf1a231b4, 0);
        this._0x7c3d6e0f = new Vector3(_0x6eb6525a, _0xf1a231b4, 0);
        this._0x45c2d27c = new Vector3(_0xadcea5b7, _0x30ecb5c0, 0);
        this._0x52aeec63 = new Vector3(_0x43065d76, _0x30ecb5c0, 0);
        this._0x974cc9b2 = new Vector3(_0x6eb6525a, _0x30ecb5c0, 0);
        this._0x52ac8c14 = new Vector3(_0xadcea5b7, _0x4ba4c418, 0);
        this._0x81d6baf8 = new Vector3(_0x43065d76, _0x4ba4c418, 0);
        this._0xc7748325 = new Vector3(_0x6eb6525a, _0x4ba4c418, 0);
    }

    private Color _0xe88ab816 = Color.white;
    private Vector3 _0x8f791e23 { get; set; }
    //public bool executeInUpdate;
    private float _0x710bec2f { get; set; }
    private Vector3 _0x974cc9b2 { get; set; }
    private Vector3 _0xc7748325 { get; set; }

    private new Camera _0xc71aaf31;
    private Vector3 _0x7c3d6e0f { get; set; }
    private Vector3 _0x52aeec63 { get; set; }

    private void Awake()
    {
        this._0xc71aaf31 = this.GetComponent<Camera>();
        _0x0a671c97 = this;
        this._0x9eba6b40();
    }

    public enum _0x8ba3f057
    {
        Landscape,
        Portrait
    }

    private Vector3 _0x0aa2e876 { get; set; }
}