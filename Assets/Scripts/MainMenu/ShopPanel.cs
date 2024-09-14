using UnityEngine;
using UnityEngine.UI;

public class ShopPanel : MonoBehaviour
{
    [SerializeField] private Button backButton;
    [SerializeField] private GameObject mainPanel;

    [SerializeField] private GameObject[] shopPanels;

    private void OnEnable()
    {
        for (int i = 0; i < shopPanels.Length; i++)
        {
            if (i == 0)
            {
                shopPanels[i].SetActive(true);
            }
            else
            {
                shopPanels[i].SetActive(false);
            }
        }
    }

    private void Awake()
    {
        BackButtonClickAction();

        if (!PlayerPrefs.HasKey("SelectedBackground"))
        {
            PlayerPrefs.SetInt("SelectedBackground", 0);
        }

        if (!PlayerPrefs.HasKey("SelectedBasket"))
        {
            PlayerPrefs.SetInt("SelectedBasket", 0);
        }
    }

    private void BackButtonClickAction()
    {
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
}
