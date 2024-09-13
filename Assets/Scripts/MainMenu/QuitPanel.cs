using UnityEngine;
using UnityEngine.UI;

public class QuitPanel : MonoBehaviour
{
    [SerializeField] 
    private Button exitGameButton;
    [SerializeField]
    private Button backMenuButton;
    [SerializeField]
    private GameObject mainPanel;

    private void Awake()
    {
        QuitButtonClickAction();
    }

    private void QuitButtonClickAction()
    {
        if (exitGameButton != null)
        {
            exitGameButton.onClick.RemoveAllListeners();
            exitGameButton.onClick.AddListener(() =>
            {
                Application.Quit();
            });
        }

        if (backMenuButton != null)
        {
            backMenuButton.onClick.RemoveAllListeners();
            backMenuButton.onClick.AddListener(() =>
            {
                AudioManager.Instance.Play("Click");
                this.gameObject.SetActive(false);
                mainPanel.SetActive(true);
            });
        }
    }
}
