using UnityEngine;

public class _0x1c64dd5c : MonoBehaviour
{
    public bool IsBestScoreEnabled;
    public bool IsTutorialEnabled;
    public bool IsTimerEnabled;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this.gameObject.GetComponent<_0x1c64dd5c>();
            DontDestroyOnLoad(this.gameObject);
            this._0x45d7bd05();
        }
        else
        {
            this._0xceda8b8f();
            Destroy(this.gameObject);
        }
    }

    public bool IsLevelIncrementOnWin;
    public static _0x1c64dd5c Instance;
    public bool IsCheckScoreEnabled;
    public bool IsOnlyWinGameEndEnabled;
    public bool IsStoryEnabled;
    private void _0x45d7bd05()
    {
        {
#if !B_LOGS
        {
            Debug.unityLogger.logEnabled = false;
            Application.SetStackTraceLogType(LogType.Assert, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Exception, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Warning, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Error, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.None);
        }
#endif
        }

        QualitySettings.vSyncCount = 1;
        Application.runInBackground = true;
    //Application.targetFrameRate = 60;
    // Time.fixedDeltaTime = 0.03f; // USE CUSTOM PHYSICS TIME FOR OPTIMIZATION IF NEEDED
    // Add this once at startup to silence the specific assertion
    }

    public bool IsSkipSplashEnabled;
    public bool IsLevelSelectorEnabled;
    private void _0xceda8b8f()
    {
    }
}