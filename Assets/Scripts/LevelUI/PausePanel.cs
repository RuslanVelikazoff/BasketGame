using UnityEngine;
using UnityEngine.UI;

public class PausePanel : MonoBehaviour
{
    [SerializeField] 
    private Button pauseButton;
    [SerializeField] 
    private Button continueButton;
    [SerializeField] 
    private Button restartButton;
    [SerializeField] 
    private Button menuButton;

    [Space(13)]
    
    [SerializeField] 
    private Image basketImage;
    [SerializeField] 
    private Sprite[] basketSprite;

    private void Awake()
    {
        PauseButtonClickAction();
        basketImage.sprite = basketSprite[PlayerPrefs.GetInt("SelectedBasket")];
        this.gameObject.SetActive(false);
    }

    private void PauseButtonClickAction()
    {
        if (pauseButton != null)
        {
            pauseButton.onClick.RemoveAllListeners();
            pauseButton.onClick.AddListener(() =>
            {
                AudioManager.Instance.Play("Click");
                this.gameObject.SetActive(true);
                Time.timeScale = 0f;
            });
        }

        if (continueButton != null)
        {
            continueButton.onClick.RemoveAllListeners();
            continueButton.onClick.AddListener(() =>
            {
                AudioManager.Instance.Play("Click");
                this.gameObject.SetActive(false);
                Time.timeScale = 1f;
            });
        }

        if (restartButton != null)
        {
            restartButton.onClick.RemoveAllListeners();
            restartButton.onClick.AddListener(() =>
            {
                AudioManager.Instance.Play("Click");
                CoinManager.Instance.AddCoinToData();
                Loader.Load("Game");
            });
        }

        if (menuButton != null)
        {
            menuButton.onClick.RemoveAllListeners();
            menuButton.onClick.AddListener(() =>
            {
                AudioManager.Instance.Play("Click");
                CoinManager.Instance.AddCoinToData();
                Loader.Load("MainMenu");
            });
        }
    }
}
