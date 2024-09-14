using UnityEngine;
using UnityEngine.UI;

public class ShopPanelManager : MonoBehaviour
{
    [SerializeField] 
    private GameObject[] shopItems;

    [SerializeField] 
    private Button nextButton;
    [SerializeField] 
    private Button previousButton;
    
    private int currentIndex;
    private int maxIndex;

    private void OnEnable()
    {
        currentIndex = 0;
        maxIndex = shopItems.Length - 1;
        SetActiveShopItems();
    }

    private void Awake()
    {
        ShopButtonClickAction();
    }

    private void ShopButtonClickAction()
    {
        if (nextButton != null)
        {
            nextButton.onClick.RemoveAllListeners();
            nextButton.onClick.AddListener(() =>
            {
                currentIndex++;
                if (currentIndex > maxIndex)
                {
                    currentIndex = 0;
                }
                SetActiveShopItems();
            });
        }

        if (previousButton != null)
        {
            previousButton.onClick.RemoveAllListeners();
            previousButton.onClick.AddListener(() =>
            {
                currentIndex--;
                if (currentIndex < 0)
                {
                    currentIndex = maxIndex;
                }
                SetActiveShopItems();
            });
        }
    }

    private void SetActiveShopItems()
    {
        for (int i = 0; i < shopItems.Length; i++)
        {
            if (i == currentIndex)
            {
                shopItems[i].SetActive(true);
            }
            else
            {
                shopItems[i].SetActive(false);
            }
        }
    }
}
