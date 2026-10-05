using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static _0x9cf3c3e3;

public class _0xc720b4f1 : MonoBehaviour
{
    public List<_0xfe27f2a2> Pops;
    public void _0xf178ac39()
    {
        this.LastPopIndexes.RemoveAll(_0x32fde3f9 => _0x32fde3f9 == this.CurrentPopIndex);
        if (this.LastPopIndexes.Count <= 0)
            this._0xd1a75cd7();
        else
            this._0x2568b066(this.LastPopIndexes.Last());
    }

    private void _0x4ae2aa0a()
    {
        this.BlurBackground.gameObject.SetActive(true);
    }

    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0xc720b4f1>();
    }

    private void _0x32c624be(bool _0xd336dc7c = false)
    {
        for (int _0xc633f4b9 = 0; _0xc633f4b9 < this.Pops.Count; ++_0xc633f4b9)
            if (this.Pops[_0xc633f4b9] != null && !(_0xc633f4b9 == this.CurrentPopIndex && _0xd336dc7c))
                this.Pops[_0xc633f4b9]._0x39aac649();
    }

    public float ScaleDuration = 0.4f;
    public void _0xd1a75cd7()
    {
        this.LastPopIndexes.Clear();
        this._0x32c624be();
        foreach (GameObject _0x4c394358 in this.GameObjectsToHide)
            if (_0x4c394358 != null)
                _0x4c394358.SetActive(true);
        this._0xcf34386d();
    }

    private void BackgroundHidden()
    {
        this.BlurBackground.gameObject.SetActive(false);
    }

    public List<int> LastPopIndexes = new();
    private void Start()
    {
        this.BackgroundHidden();
        foreach (_0xfe27f2a2 _0x0c955ad5 in this.Pops)
            if (_0x0c955ad5 != null)
                _0x0c955ad5.gameObject.SetActive(true);
    }

    public static _0xc720b4f1 Instance;
    public GameObject BlurBackground;
    public int CurrentPopIndex;
    private void _0xcf34386d()
    {
        this.Invoke(nameof(this.BackgroundHidden), this.ScaleDuration);
    }

    public List<GameObject> GameObjectsToHide;
    public void _0x2568b066(int _0x0ace72c3)
    {
        this.CurrentPopIndex = _0x0ace72c3;
        this.LastPopIndexes.Add(this.CurrentPopIndex);
        this._0x32c624be(true);
        this._0x4ae2aa0a();
        this.Pops[_0x0ace72c3].Show();
        foreach (GameObject _0xf63b3121 in this.GameObjectsToHide)
            _0xf63b3121.SetActive(false);
    }

    public _0xfe27f2a2 _0x0ce78cc7(int _0x660ea3d3)
    {
        return this.Pops[_0x660ea3d3];
    }
}