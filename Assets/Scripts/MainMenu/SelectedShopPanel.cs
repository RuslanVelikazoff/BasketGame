using UnityEngine;
using UnityEngine.UI;

public class SelectedShopPanel : MonoBehaviour
{
    [SerializeField]
    private Button backgroundsButton;
    [SerializeField]
    private GameObject backgroundsPanel;

    [Space(13)]
    
    [SerializeField]
    private Button basketsButton;
    [SerializeField]
    private GameObject basketsPanel;

    private void Awake()
    {
        SelectedShopButtonClickAction();
    }

    private void SelectedShopButtonClickAction()
    {
        if (backgroundsButton != null)
        {
            backgroundsButton.onClick.RemoveAllListeners();
            backgroundsButton.onClick.AddListener(() =>
            {
                AudioManager.Instance.Play("Click");
                this.gameObject.SetActive(false);
                backgroundsPanel.SetActive(true);
            });
        }

        if (basketsButton != null)
        {
            basketsButton.onClick.RemoveAllListeners();
            basketsButton.onClick.AddListener(() =>
            {
                AudioManager.Instance.Play("Click");
                this.gameObject.SetActive(false);
                basketsPanel.SetActive(true);
            });
        }
    }
}
