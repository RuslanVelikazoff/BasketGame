using UnityEngine;
using UnityEngine.UI;

public class BasketShop : MonoBehaviour
{
    [SerializeField] 
    private int basketIndex;
    
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
        BasketButtonClickAction();
    }

    private void BasketButtonClickAction()
    {
        if (buyButton != null)
        {
            buyButton.onClick.RemoveAllListeners();
            buyButton.onClick.AddListener(() =>
            {
                if (CoinData.Instance.GetCoinAmount() >= price)
                {
                    CoinData.Instance.MinusCoin(price);
                    ShopData.Instance.BuyBasket(basketIndex);
                    coinManager.UpdateCoinText();
                    PlayerPrefs.SetInt("SelectedBasket", basketIndex);
                    SetButtonActive();
                }
            });
        }

        if (selectButton != null)
        {
            selectButton.onClick.RemoveAllListeners();
            selectButton.onClick.AddListener(() =>
            {
                PlayerPrefs.SetInt("SelectedBasket", basketIndex);
                SetButtonActive();
            });
        }
    }

    private void SetButtonActive()
    {
        if (PlayerPrefs.GetInt("SelectedBasket") == basketIndex)
        {
            buyButton.gameObject.SetActive(false);
            selectButton.gameObject.SetActive(false);
        }
        else
        {
            if (ShopData.Instance.IsBuyBasket(basketIndex))
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
