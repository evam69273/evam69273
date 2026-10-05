using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static _0x9cf3c3e3;

public class _0xfa2aadfc : MonoBehaviour
{
    [HideInInspector]
    public List<_0xd08c4c3c> MoneyCountContainers = new();
    public void _0xccf6e6c9()
    {
        _0xffac758c._0x9debb77c = true;
    }

    public Button DeleteProgressDataButton;
    private static void MakeGrid(List<RectTransform> _0x71f92eb0, AspectRatioFitter _0x563674b1, float _0x91d09e2c, int _0x4e08a596, int _0xe656d842)
    {
        _0x563674b1.aspectMode = AspectRatioFitter.AspectMode.WidthControlsHeight;
        _0x563674b1.aspectRatio = _0x91d09e2c;
        foreach (RectTransform _0x9a6d1f1e in _0x71f92eb0)
        {
            int _0x1f0e46a4 = _0x9a6d1f1e.transform.GetSiblingIndex();
            _0x9a6d1f1e.anchorMin = new Vector3(Mathf.FloorToInt((float)_0x1f0e46a4 % _0x4e08a596) * (1f / _0x4e08a596), (_0xe656d842 - (Mathf.FloorToInt((float)_0x1f0e46a4 / _0x4e08a596) % _0xe656d842 + 1f)) * (1f / _0xe656d842));
            _0x9a6d1f1e.anchorMax = new Vector3(Mathf.FloorToInt((float)_0x1f0e46a4 % _0x4e08a596 + 1f) * (1f / _0x4e08a596), (_0xe656d842 - Mathf.FloorToInt((float)_0x1f0e46a4 / _0x4e08a596) % _0xe656d842) * (1f / _0xe656d842));
            _0x9a6d1f1e.offsetMin = Vector2.zero;
            _0x9a6d1f1e.offsetMax = Vector2.zero;
        }
    }

    private void Start()
    {
        if (this._0xa00f8c5e != _0xf290fefa.SCENE_0)
            Screen.orientation = ScreenOrientation.Portrait;
        this.DeleteProgressDataButton?.onClick.AddListener(() =>
        {
            PlayerPrefs.DeleteAll();
            //AudioController.Instance.UpdateMusics();
            //AudioController.Instance.UpdateSfxes();
            Instance.LoadSceneByIndex(_0xf290fefa.SCENE_0);
        });
        this.ShowResetTutorialButton?.onClick.AddListener(() =>
        {
            _0xffac758c._0x9debb77c = false;
            _0xc720b4f1.Instance._0xd1a75cd7();
            _0x64a8e136.Instance._0x193e969a(_0xea9b069c.TUTORIAL0);
        });
    }

    public int _0xa00f8c5e => SceneManager.GetActiveScene().buildIndex;

    private void _0x6063e48e()
    {
        IsAfterLevelComplete = true;
        Instance.LoadSceneByIndex(_0xf290fefa.SCENE_0);
    }

    public Button ShowResetTutorialButton;
    public static _0x48e02344 _0xffac758c => _0x48e02344.ALL_SCENES_SETTING_SINGLETONS[Instance._0xa00f8c5e];

    public static _0xfa2aadfc Instance;
    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0xfa2aadfc>();
        this.RootGameObject = GameObject.FindWithTag(_0x1b26318f._0xdbb8cd72(new byte[4] { 97, 92, 92, 71 }, 51));
        if (this._0xa00f8c5e == _0xf290fefa.SCENE_0)
            this._0xb6166d7b(true);
        else
            this._0xb6166d7b(false);
        this.MoneyCountContainers = this.RootGameObject.GetComponentsInChildren<_0xd08c4c3c>(true).ToList();
    }

    [HideInInspector]
    public GameObject RootGameObject; // tag - "Root"
    private IEnumerator _0xd71fe3ed(int _0xb75b1053)
    {
        _0x64a8e136.Instance._0x193e969a(_0xea9b069c.SPLASH);
        AsyncOperation _0xe61e17c4 = SceneManager.LoadSceneAsync(_0xb75b1053);
        while (!_0xe61e17c4.isDone)
            yield return null;
    }

    public void LoadSceneByIndex(int _0xe4b0ff60)
    {
        //if (SceneManager.GetActiveScene().buildIndex == sceneIndex)
        //    AdsInitializer.Instance?.ShowAd();
        this.StartCoroutine(this._0xd71fe3ed(_0xe4b0ff60));
    }

    public Transform EnvironmentWithTweensToToggle;
    private static _0x48e02344 GAME_INDEX_SETTINGS(int _0xa7becfd4)
    {
        return _0x48e02344.ALL_SCENES_SETTING_SINGLETONS[_0xa7becfd4];
    }

    public void _0xb6166d7b(bool _0x7e012343)
    {
        this._0x83ddb21d = _0x7e012343;
        this._0x25b154a4(!this._0x83ddb21d);
        Physics2D.simulationMode = this._0x83ddb21d ? SimulationMode2D.FixedUpdate : SimulationMode2D.Script;
        if (this.EnvironmentWithTweensToToggle != null)
            this._0x55b180b5(this.EnvironmentWithTweensToToggle);
    }

    public static bool IsAfterLevelFailed = false;
    private void _0x25b154a4(bool _0x4622f600)
    {
        Rigidbody2D[] _0x534dd817 = this.RootGameObject.GetComponentsInChildren<Rigidbody2D>(true);
        foreach (Rigidbody2D _0x8ad1ed70 in _0x534dd817)
            if (_0x4622f600)
                _0x8ad1ed70.constraints = RigidbodyConstraints2D.FreezeAll;
            else
                _0x8ad1ed70.constraints = RigidbodyConstraints2D.None;
    }

    public bool _0x83ddb21d { get; private set; }

    public Canvas MainCanvas;
    private IEnumerator _0xdd35031f(string _0x8b78dfb4)
    {
        _0x64a8e136.Instance._0x193e969a(_0xea9b069c.SPLASH);
        //AudioController.Instance.SaveLastMusicTimes();
        AsyncOperation _0x13b36a12 = SceneManager.LoadSceneAsync(_0x8b78dfb4);
        while (!_0x13b36a12.isDone)
            yield return null;
    }

    public Transform Environment;
    public void _0x6a12bbcd()
    {
        foreach (_0xd08c4c3c _0x736049ea in this.MoneyCountContainers)
            _0x736049ea._0x9857e34e();
    }

    private void _0x55b180b5(Transform _0xdd8a5027)
    {
        Transform[] _0x6df6c77b = _0xdd8a5027.GetComponentsInChildren<Transform>();
        foreach (Transform _0xe0e77742 in _0x6df6c77b)
            if (_0xe0e77742 != null && DOTween.IsTweening(_0xe0e77742))
            {
                if (this._0x83ddb21d)
                    DOTween.Play(_0xe0e77742);
                else
                    DOTween.Pause(_0xe0e77742);
            }
    }

    public static bool IsAfterLevelComplete;
    private static _0x48e02344 _0x55b3707e => _0x48e02344.ALL_SCENES_SETTING_SINGLETONS[0];

    public void _0x402afacb()
    {
        this.LoadSceneByIndex(SceneManager.GetActiveScene().buildIndex);
    }

    private static void ExitGame()
    {
        Application.Quit();
    }
}

internal static class _0x1b26318f
{
    internal static string _0xdbb8cd72(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}