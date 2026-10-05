using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;
using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch;
using TouchPhase = UnityEngine.InputSystem.TouchPhase;

public class _0x3eefd19b : MonoBehaviour
{
    private static _0x3eefd19b _0x28b44b62;
    public BoxCollider2D CameraTouchBounds;
    private Touch? _0x8218d9a9(Bounds _0xc0da3f25)
    {
        if (!_0xfa2aadfc.Instance._0x83ddb21d)
            return null;
        foreach (Touch _0x6c58f865 in Touch.activeTouches)
            if (_0x6c58f865.ended)
            {
                Vector3 _0x89924183 = Camera.main.ScreenToWorldPoint(_0x6c58f865.screenPosition);
                Vector3 _0x05fa7eba = new(_0x89924183.x, _0x89924183.y, _0xc0da3f25.center.z);
                if (_0xc0da3f25.Contains(_0x05fa7eba) && this._0x677a3c2f(_0x6c58f865))
                    return _0x6c58f865;
            }

        return null;
    }

    private Touch? _0xd9acd626()
    {
        if (!_0xfa2aadfc.Instance._0x83ddb21d)
            return null;
        foreach (Touch _0x8c9c0ff2 in Touch.activeTouches)
            if (_0x8c9c0ff2.ended)
                if (this._0x677a3c2f(_0x8c9c0ff2))
                    return _0x8c9c0ff2;
        return null;
    }

    private Touch? _0x98820212()
    {
        if (!_0xfa2aadfc.Instance._0x83ddb21d)
            return null;
        foreach (Touch _0x5f5fdc35 in Touch.activeTouches)
            if (!_0x5f5fdc35.ended)
                if (this._0x677a3c2f(_0x5f5fdc35))
                    return _0x5f5fdc35;
        return null;
    }

    private bool _0x18ce8623(Touch? _0xbdece6a4, Bounds _0xf268a497, TouchPhase _0x3bb1b8fd)
    {
        if (!_0xfa2aadfc.Instance._0x83ddb21d)
        {
            _0xbdece6a4 = null;
            return false;
        }

        if (_0xbdece6a4 != null)
            if (_0xbdece6a4.Value.phase == _0x3bb1b8fd)
            {
                Vector3 _0x357bfc64 = Camera.main.ScreenToWorldPoint(_0xbdece6a4.Value.screenPosition);
                Vector3 _0xe965f5de = new(_0x357bfc64.x, _0x357bfc64.y, _0xf268a497.center.z);
                if (_0xf268a497.Contains(_0xe965f5de) && this._0x677a3c2f(_0xbdece6a4.Value))
                    return true;
            }

        return false;
    }

    private Touch? _0x5925cc3b(Bounds _0xa825b9e0, TouchPhase _0x42bf167c)
    {
        if (!_0xfa2aadfc.Instance._0x83ddb21d)
            return null;
        foreach (Touch _0x0b3e3fc0 in Touch.activeTouches)
            if (_0x0b3e3fc0.phase == _0x42bf167c)
            {
                Vector3 _0xae4f483b = Camera.main.ScreenToWorldPoint(_0x0b3e3fc0.screenPosition);
                Vector3 _0xf8cfd658 = new(_0xae4f483b.x, _0xae4f483b.y, _0xa825b9e0.center.z);
                if (_0xa825b9e0.Contains(_0xf8cfd658) && this._0x677a3c2f(_0x0b3e3fc0))
                    return _0x0b3e3fc0;
            }

        return null;
    }

    private bool _0x677a3c2f(Touch? _0x0bca289c)
    {
        if (!_0x0bca289c.HasValue)
            return false;
        Vector3 _0x136fc5d5 = Camera.main.ScreenToWorldPoint(_0x0bca289c.Value.screenPosition);
        Vector3 _0x6bf43d74 = _0x136fc5d5;
        _0x6bf43d74.z = this.CameraTouchBounds.transform.position.z;
        if (this.CameraTouchBounds.bounds.Contains(_0x6bf43d74))
            return true;
        _0x0bca289c = null;
        return false;
    }

    private void _0x4bdc6dd6(Touch? _0x8d375a1c)
    {
        if (!_0xfa2aadfc.Instance._0x83ddb21d)
        {
            _0x8d375a1c = null;
            return;
        }

        int _0x992288de = _0x8d375a1c.Value.touchId;
        _0x8d375a1c = Touch.activeTouches.FirstOrDefault(_0x6b5a8d28 => _0x6b5a8d28.touchId == _0x992288de);
        if (!this._0x677a3c2f(_0x8d375a1c.Value))
            _0x8d375a1c = null;
    }

    private void Awake()
    {
        EnhancedTouchSupport.Enable();
        _0x28b44b62 = this.gameObject.GetComponent<_0x3eefd19b>();
    }

    private Touch? _0xc4ee332a(Bounds _0x013bb73a)
    {
        if (!_0xfa2aadfc.Instance._0x83ddb21d)
            return null;
        foreach (Touch _0x659da2f4 in Touch.activeTouches)
            if (!_0x659da2f4.ended)
            {
                Vector3 _0x1537a272 = Camera.main.ScreenToWorldPoint(_0x659da2f4.screenPosition);
                Vector3 _0xa45452cd = new(_0x1537a272.x, _0x1537a272.y, _0x013bb73a.center.z);
                if (_0x013bb73a.Contains(_0xa45452cd) && this._0x677a3c2f(_0x659da2f4))
                    return _0x659da2f4;
            }

        return null;
    }
}