using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x9eff7c09 : MonoBehaviour
{
    public List<Button> PauseButtons = new();
    private void _0x361460dc()
    {
        this.TimerText.ForEach(_0x6e04f6b1 => _0x6e04f6b1.text = TimeSpan.FromSeconds(this.TimeLeft).ToString(_0xcc07d399._0xea19747b(new byte[6] { 30, 30, 47, 73, 0, 0 }, 115)));
    }

    public void _0x9e0afcc4()
    {
        _0xfa2aadfc.Instance._0xb6166d7b(true);
        _0xfa2aadfc.Instance.LoadSceneByIndex(_0x9cf3c3e3._0xf290fefa.SCENE_0);
    }

    private int _0xc6e44a71 => this.CustomTargetScore + _0xfa2aadfc._0xffac758c._0xadf97365 * 10;

    [HideInInspector]
    public int CurrentGameIndex;
    private void _0x420db6f2()
    {
        if (this.ScoreCurrent >= this._0xc6e44a71)
            this._0x3e52f453();
        else
            this._0xc185a04c();
    }

    private int _0x1c90c173 => this.CustomTimeInitial + _0xfa2aadfc._0xffac758c._0xadf97365 * 10;

    public void _0x3e52f453()
    {
        if (!this.IsGameEnd)
        {
            this._0x6a115ba7();
            _0xfa2aadfc.IsAfterLevelComplete = true;
            _0xfa2aadfc.IsAfterLevelFailed = false;
            _0xfe27f2a2 _0x94b13a59 = _0xc720b4f1.Instance._0x0ce78cc7(_0x9cf3c3e3._0xef00101c.WIN).GetComponent<_0xfe27f2a2>();
            if (_0x1c64dd5c.Instance.IsCheckScoreEnabled)
                _0x94b13a59.ContentMainText.text = $"{this.ScoreCurrent}/{this._0xc6e44a71}";
            else
                _0x94b13a59.ContentMainText.text = $"{this.ScoreCurrent}";
            if (_0x1c64dd5c.Instance.IsBestScoreEnabled)
            {
                if (this.ScoreCurrent > _0x9cf3c3e3._0x931bebe5._0x98ad77d8)
                    _0x9cf3c3e3._0x931bebe5._0x98ad77d8 = this.ScoreCurrent;
                _0x94b13a59.ContentAdditionalText.text = $"{_0x9cf3c3e3._0x931bebe5._0x98ad77d8}";
            }
            else
            {
                _0x94b13a59.ContentAdditionalText.text = $"{this._0x79006ed3}";
                _0x9cf3c3e3._0x931bebe5._0x98ad77d8 += this._0x79006ed3;
            }

            if (_0x1c64dd5c.Instance.IsLevelIncrementOnWin)
                ++_0xfa2aadfc._0xffac758c._0xadf97365;
            _0xc720b4f1.Instance._0x2568b066(_0x9cf3c3e3._0xef00101c.WIN);
        }
    }

    private void _0xa4f3591f()
    {
        if (this.ScoreCurrent > _0xfa2aadfc._0xffac758c._0x689cd9f9)
            _0xfa2aadfc._0xffac758c._0x689cd9f9 = this.ScoreCurrent;
        if (_0x1c64dd5c.Instance.IsCheckScoreEnabled)
            if (this.ScoreCurrent >= this._0xc6e44a71)
                this._0x3e52f453();
    }

    public List<TMP_Text> LevelNumberText = new();
    public void _0x3a34664a(int scoreToAdd)
    {
        if (!this.IsGameEnd)
        {
            this.ScoreCurrent += scoreToAdd;
            this._0xef08fbd6();
            this._0xa4f3591f();
        }
    }

    private void _0xef08fbd6()
    {
        if (_0x1c64dd5c.Instance.IsCheckScoreEnabled)
            this.ScoreText.ForEach(_0x6e04f6b1 => _0x6e04f6b1.text = $"{this.ScoreCurrent}/{this._0xc6e44a71}");
        else
            this.ScoreText.ForEach(_0x6e04f6b1 => _0x6e04f6b1.text = $"{this.ScoreCurrent}");
    }

    public int CustomTargetScore = 10;
    [HideInInspector]
    public int ScoreCurrent;
    [HideInInspector]
    public bool IsGameEnd;
    private void _0x6a115ba7()
    {
        this.IsGameEnd = true;
        _0xfa2aadfc.IsAfterLevelComplete = true;
    }

    private static _0x9eff7c09 _0xf31dba2f;
    private int _0x79006ed3 => this.ScoreCurrent;

    public List<TMP_Text> TimerText = new();
    private IEnumerator _0x5a6b2f56()
    {
        this._0x361460dc();
        while (!this.IsGameEnd && this.TimeLeft > 0 && _0xfa2aadfc.Instance._0xa00f8c5e == this.CurrentGameIndex)
        {
            yield return new WaitForSeconds(1f);
            if (_0xfa2aadfc.Instance._0x83ddb21d)
            {
                if (this.IsGameEnd)
                    break;
                this.TimeLeft--;
                this._0x361460dc();
            }
        }

        if (!this.IsGameEnd)
            this._0xc185a04c();
    }

    public List<TMP_Text> ScoreText = new();
    [HideInInspector]
    public int TimeLeft;
    public List<Button> HomeButtons = new();
    public List<TMP_Text> SubtitleText = new();
    private void Start()
    {
        this.IsGameEnd = false;
        this.TimeLeft = this._0x1c90c173;
        this.CurrentGameIndex = _0xfa2aadfc.Instance._0xa00f8c5e;
        foreach (Button _0x772b8dcb in this.HomeButtons)
            _0x772b8dcb.onClick.AddListener(() =>
            {
                this._0x9e0afcc4();
            });
        foreach (Button _0x66190e4d in this.PauseButtons)
            _0x66190e4d.onClick.AddListener(() =>
            {
                _0xfa2aadfc.Instance._0xb6166d7b(false);
                _0xc720b4f1.Instance._0x2568b066(_0x9cf3c3e3._0xef00101c.PAUSE);
            });
        this._0xef08fbd6();
        this.LevelNumberText.ForEach(_0x6e04f6b1 => _0x6e04f6b1.text = $"LVL {_0xfa2aadfc._0xffac758c._0xadf97365 + 1}");
        if (_0x1c64dd5c.Instance.IsTimerEnabled)
        {
            this._0x361460dc();
            this.StartCoroutine(this._0x5a6b2f56());
        }
    }

    private void Awake()
    {
        _0xf31dba2f = this.gameObject.GetComponent<_0x9eff7c09>();
    }

    public void _0xc185a04c()
    {
        if (_0x1c64dd5c.Instance.IsOnlyWinGameEndEnabled)
            this._0x3e52f453();
        if (!this.IsGameEnd)
        {
            this._0x6a115ba7();
            _0xfa2aadfc.IsAfterLevelComplete = false;
            _0xfa2aadfc.IsAfterLevelFailed = true;
            _0xfe27f2a2 _0x698454b3 = _0xc720b4f1.Instance._0x0ce78cc7(_0x9cf3c3e3._0xef00101c.LOSE).GetComponent<_0xfe27f2a2>();
            if (_0x1c64dd5c.Instance.IsCheckScoreEnabled)
                _0x698454b3.ContentMainText.text = $"{this.ScoreCurrent}/{this._0xc6e44a71}";
            else
                _0x698454b3.ContentMainText.text = $"{this.ScoreCurrent}";
            _0x698454b3.ContentAdditionalText.text = $"{0}";
            _0x9cf3c3e3._0x931bebe5._0x98ad77d8 += 0;
            _0xc720b4f1.Instance._0x2568b066(_0x9cf3c3e3._0xef00101c.LOSE);
        }
    }

    public int CustomTimeInitial = 30;
}

internal static class _0xcc07d399
{
    internal static string _0xea19747b(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}