using UnityEngine;
using UnityEngine.UI;

public class SettingsPanel : MonoBehaviour
{
    [SerializeField]
    private Button musicOnButton;
    [SerializeField]
    private Button musicOffButton;
    [SerializeField]
    private Button soundOnButton;
    [SerializeField]
    private Button soundOffButton;
    
    [Space(13)]
    
    [SerializeField]
    private Button backButton;
    [SerializeField]
    private GameObject mainPanel;

    [Space(13)]
    
    [SerializeField] 
    private Color activeColor;
    [SerializeField]
    private Color inactiveColor;

    private void OnEnable()
    {
        SetSoundButtonColor();
        SetMusicButtonColor();
    }

    private void Awake()
    {
        SettingsButtonClickAction();
    }

    private void SettingsButtonClickAction()
    {
        if (musicOnButton != null)
        {
            musicOnButton.onClick.RemoveAllListeners();
            musicOnButton.onClick.AddListener(() =>
            {
                AudioManager.Instance.Play("Click");
                AudioManager.Instance.SetMusicVolume(1f);
                SetMusicButtonColor();
            });
        }

        if (musicOffButton != null)
        {
            musicOffButton.onClick.RemoveAllListeners();
            musicOffButton.onClick.AddListener(() =>
            {
                AudioManager.Instance.Play("Click");
                AudioManager.Instance.SetMusicVolume(0f);
                SetMusicButtonColor();
            });
        }

        if (soundOnButton != null)
        {
            soundOnButton.onClick.RemoveAllListeners();
            soundOnButton.onClick.AddListener(() =>
            {
                AudioManager.Instance.Play("Click");
                AudioManager.Instance.SetSoundVolume(1f);
                SetSoundButtonColor();
            });
        }

        if (soundOffButton != null)
        {
            soundOffButton.onClick.RemoveAllListeners();
            soundOffButton.onClick.AddListener(() =>
            {
                AudioManager.Instance.Play("Click");
                AudioManager.Instance.SetSoundVolume(0f);
                SetSoundButtonColor();
            });
        }

        if (backButton != null)
        {
            backButton.onClick.RemoveAllListeners();
            backButton.onClick.AddListener(() =>
            {
                AudioManager.Instance.Play("Click");
                this.gameObject.SetActive(false);
                mainPanel.SetActive(true);
            });
        }
    }

    private void SetSoundButtonColor()
    {
        if (AudioManager.Instance.SoundOn())
        {
            soundOnButton.GetComponent<Image>().color = activeColor;
            soundOffButton.GetComponent<Image>().color = inactiveColor;
        }
        else
        {
            soundOnButton.GetComponent<Image>().color = inactiveColor;
            soundOffButton.GetComponent<Image>().color = activeColor;
        }
    }

    private void SetMusicButtonColor()
    {
        if (AudioManager.Instance.MusicOn())
        {
            musicOnButton.GetComponent<Image>().color = activeColor;
            musicOffButton.GetComponent<Image>().color = inactiveColor;
        }
        else
        {
            musicOnButton.GetComponent<Image>().color = inactiveColor;
            musicOffButton.GetComponent<Image>().color = activeColor;
        }
    }
}
