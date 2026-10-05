using UnityEngine;
using UnityEngine.UI;

public class _0x50d7ccb1 : MonoBehaviour
{
    public int NextTutorialPanelIndex;
    private void Start()
    {
        if (this.NextTutorialButton != null)
        {
            if (this.IsTutorialEndPanel)
            {
                this.NextTutorialButton.onClick.AddListener(() => _0x64a8e136.Instance._0x193e969a(this.EndTutorialPanelIndex));
                this.NextTutorialButton.onClick.AddListener(() => _0xfa2aadfc.Instance._0xccf6e6c9());
            }
            else
            {
                this.NextTutorialButton.onClick.AddListener(() => _0x64a8e136.Instance._0x193e969a(this.NextTutorialPanelIndex));
            }
        }

        if (this.TutorialEndButton != null)
        {
            this.TutorialEndButton.onClick.AddListener(() => _0x64a8e136.Instance._0x193e969a(this.EndTutorialPanelIndex));
            this.TutorialEndButton.onClick.AddListener(() => _0xfa2aadfc.Instance._0xccf6e6c9());
        }
    }

    public Button TutorialEndButton;
    public bool IsTutorialEndPanel;
    public Button NextTutorialButton;
    public int EndTutorialPanelIndex = 1;
}