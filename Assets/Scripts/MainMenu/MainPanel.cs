using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainPanel : MonoBehaviour
{
    [SerializeField] 
    private Button startGameButton;
    [SerializeField] 
    private Button shopButton;
    [SerializeField]
    private Button settingsButton;
    [SerializeField] 
    private Button quitButton;
    [SerializeField] 
    private Button leaderboardButton;
    [SerializeField] 
    private Button questButton;

    [Space(13)]
    
    [SerializeField]
    private GameObject shopPanel;
    [SerializeField] 
    private GameObject settingsPanel;
    [SerializeField] 
    private GameObject quitPanel;
    [SerializeField] 
    private GameObject leaderboardPanel;
    [SerializeField] 
    private GameObject questPanel;

    private void Awake()
    {
        MainMenuButtonClickAction();
    }

    private void MainMenuButtonClickAction()
    {
        if (startGameButton != null)
        {
            startGameButton.onClick.RemoveAllListeners();
            startGameButton.onClick.AddListener(() =>
            {
                AudioManager.Instance.Play("Click");
                SceneManager.LoadScene("Game");
            });
        }

        if (shopButton != null)
        {
            shopButton.onClick.RemoveAllListeners();
            shopButton.onClick.AddListener(() =>
            {
                AudioManager.Instance.Play("Click");
                this.gameObject.SetActive(false);
                shopPanel.SetActive(true);
            });
        }

        if (settingsButton != null)
        {
            settingsButton.onClick.RemoveAllListeners();
            settingsButton.onClick.AddListener(() =>
            {
                AudioManager.Instance.Play("Click");
                this.gameObject.SetActive(false);
                settingsPanel.SetActive(true);
            });
        }

        if (quitButton != null)
        {
            quitButton.onClick.RemoveAllListeners();
            quitButton.onClick.AddListener(() =>
            {
                AudioManager.Instance.Play("Click");
                this.gameObject.SetActive(false);
                quitPanel.SetActive(true);
            });
        }

        if (leaderboardButton != null)
        {
            leaderboardButton.onClick.RemoveAllListeners();
            leaderboardButton.onClick.AddListener(() =>
            {
                AudioManager.Instance.Play("Click");
                this.gameObject.SetActive(false);
                leaderboardPanel.SetActive(true);
            });
        }

        if (questButton != null)
        {
            questButton.onClick.RemoveAllListeners();
            questButton.onClick.AddListener(() =>
            {
                AudioManager.Instance.Play("Click");
                this.gameObject.SetActive(false);
                questPanel.SetActive(true);
            });
        }
    }
}
