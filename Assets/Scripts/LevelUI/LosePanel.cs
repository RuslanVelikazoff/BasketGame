using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LosePanel : MonoBehaviour
{
    [SerializeField] 
    private Button restartButton;
    [SerializeField] 
    private Button menuButton;
    
    [SerializeField] 
    private TextMeshProUGUI timerText;
    [SerializeField] 
    private TextMeshProUGUI coinText;
    
    private void OnEnable()
    {
        CoinManager.Instance.AddCoinToData();
        timerText.text = TimerManager.Instance.GetTimerString();
        coinText.text = CoinManager.Instance.GetCoinAmount().ToString();
    }

    private void Awake()
    {
        LoseButtonClickAction();
    }

    private void LoseButtonClickAction()
    {
        if (restartButton != null)
        {
            restartButton.onClick.RemoveAllListeners();
            restartButton.onClick.AddListener(() =>
            { 
                AudioManager.Instance.Play("Click");
                Loader.Load("Game");
            });
        }

        if (menuButton != null)
        {
            menuButton.onClick.RemoveAllListeners();
            menuButton.onClick.AddListener(() =>
            {
                AudioManager.Instance.Play("Click");
                Loader.Load("MainMenu");
            });
        }
    }
}
