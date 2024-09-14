using UnityEngine;
using UnityEngine.UI;

public class BackgroundShop : MonoBehaviour
{
    [SerializeField] 
    private int backgroundIndex;
    
    [Space(13)]
    
    [SerializeField]
    private Button buyButton;
    [SerializeField] 
    private Button selectButton;

    [Space(13)]
    
    [SerializeField] 
    private int price;

    [Space(13)]
    
    [SerializeField]
    private CoinMenuPanel coinManager;

    private void OnEnable()
    {
        SetButtonActive();
    }

    private void Awake()
    {
        BackgroundButtonClickAction();
    }

    private void BackgroundButtonClickAction()
    {
        if (buyButton != null)
        {
            buyButton.onClick.RemoveAllListeners();
            buyButton.onClick.AddListener(() =>
            {
                if (CoinData.Instance.GetCoinAmount() >= price)
                {
                    CoinData.Instance.MinusCoin(price);
                    ShopData.Instance.BuyBackground(backgroundIndex);
                    coinManager.UpdateCoinText();
                    PlayerPrefs.SetInt("SelectedBackground", backgroundIndex);
                    SetButtonActive();
                }
            });
        }

        if (selectButton != null)
        {
            selectButton.onClick.RemoveAllListeners();
            selectButton.onClick.AddListener(() =>
            {
                PlayerPrefs.SetInt("SelectedBackground", backgroundIndex);
                SetButtonActive();
            });
        }
    }

    private void SetButtonActive()
    {
        if (PlayerPrefs.GetInt("SelectedBackground") == backgroundIndex)
        {
            buyButton.gameObject.SetActive(false);
            selectButton.gameObject.SetActive(false);
        }
        else
        {
            if (ShopData.Instance.IsBuyBackground(backgroundIndex))
            {
                buyButton.gameObject.SetActive(false);
                selectButton.gameObject.SetActive(true);
            }
            else
            {
                buyButton.gameObject.SetActive(true);
                selectButton.gameObject.SetActive(false);
            }
        }
    }
}
