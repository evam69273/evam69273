using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static _0x9cf3c3e3;

public class _0x64a8e136 : MonoBehaviour
{
    public void _0x8d048634()
    {
        this.LastPanelIndexes.RemoveAll(_0x32fde3f9 => _0x32fde3f9 == this.CurrentPanelIndex);
        int _0x3fb48606 = this.LastPanelIndexes.Last();
        this._0xb2450c15(_0x3fb48606);
        this._0xb22f1c6a(_0x3fb48606);
        this.CurrentPanelIndex = _0x3fb48606;
        this.Panels[_0x3fb48606].Show();
    }

    private void _0xb22f1c6a(int _0x2be2675c)
    {
        this.LastPanelIndexes.Add(_0x2be2675c);
        this.CurrentPanelIndex = _0x2be2675c;
        for (int _0xe2d88b8a = 0; _0xe2d88b8a < this.Panels.Count; _0xe2d88b8a++)
            if (_0xe2d88b8a != _0x2be2675c && this.Panels[_0xe2d88b8a] != null)
                this.Panels[_0xe2d88b8a]._0x60305c4c();
    }

    public static _0x64a8e136 Instance;
    public float StaticBlurMaterialInitialValue;
    private _0xe645a9ed _0x387d6af8(int _0x6f3916cd)
    {
        return this.Panels[_0x6f3916cd];
    }

    public float ScaleDuration = 0.4f;
    public void _0x84b99d82(int _0xc017a017)
    {
        if (_0xc017a017 == _0xea9b069c.SPLASH && _0xfa2aadfc.Instance._0xa00f8c5e != _0xf290fefa.SCENE_0)
            _0xd50eca76.Instance._0x867cee0d();
        if (_0xfa2aadfc.Instance._0xa00f8c5e != _0xf290fefa.SCENE_0)
        {
            if (_0xc017a017 == _0xea9b069c.SPLASH || _0xc017a017 == _0xea9b069c.TUTORIAL0)
                _0xfa2aadfc.Instance._0xb6166d7b(false);
            else if (_0xc017a017 == _0xea9b069c.DEFAULT)
                _0xfa2aadfc.Instance._0xb6166d7b(true);
        }
    }

    public int CurrentPanelIndex;
    private void _0xa4cde505(int _0xf4a84559)
    {
        this._0xa98841a2(_0xf4a84559);
        this._0xb2450c15(_0xf4a84559);
        this.CurrentPanelIndex = _0xf4a84559;
        this.Panels[_0xf4a84559]._0xe739e643();
    }

    private void SwitchSplash()
    {
        if (_0x1c64dd5c.Instance.IsTutorialEnabled && !_0xfa2aadfc._0xffac758c._0x9debb77c)
            this._0x193e969a(_0xea9b069c.TUTORIAL0);
        else
            this._0x193e969a(_0xea9b069c.DEFAULT);
    }

    private void _0xb2450c15(int _0xfaff4bbc)
    {
        if (_0xfaff4bbc == _0xea9b069c.SPLASH)
            _0xd50eca76.Instance._0xf88b8831();
        if (_0xfa2aadfc.Instance._0xa00f8c5e == _0xf290fefa.SCENE_0)
        {
        }
    }

    public bool IsShowSplashOnStart = true;
    private void _0x1eb75e47()
    {
        this._0xa4cde505(_0xea9b069c.SPLASH);
        if (_0xfa2aadfc.Instance._0xa00f8c5e == _0xf290fefa.SCENE_0)
        {
        }
        else
        {
            this.Invoke(nameof(this.SwitchSplash), _0xd50eca76.Instance.DefaultAnimationTime);
        }
    }

    private void Start()
    {
        this._0x1eb75e47();
    }

    public void _0x193e969a(int _0x42f2d80a)
    {
        this._0xa98841a2(_0x42f2d80a);
        this._0xb2450c15(_0x42f2d80a);
        this.CurrentPanelIndex = _0x42f2d80a;
        this.Panels[_0x42f2d80a].Show();
    }

    public List<_0xe645a9ed> Panels;
    private void _0xa98841a2(int _0x023a62c3)
    {
        this.LastPanelIndexes.Add(_0x023a62c3);
        this.CurrentPanelIndex = _0x023a62c3;
        for (int _0x790cdaa4 = 0; _0x790cdaa4 < this.Panels.Count; _0x790cdaa4++)
            if (_0x790cdaa4 != _0x023a62c3 && this.Panels[_0x790cdaa4] != null)
                this.Panels[_0x790cdaa4]._0x60305c4c();
    }

    [HideInInspector]
    public List<int> LastPanelIndexes = new()
    {
        1
    };
    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x64a8e136>();
    }
}