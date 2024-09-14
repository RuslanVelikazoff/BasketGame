using UnityEngine;
using UnityEngine.UI;

public class QuestPanel : MonoBehaviour
{
    [SerializeField] 
    private Button backButton;
    [SerializeField]
    private GameObject mainPanel;

    private void Awake()
    {
        QuestButtonClickAction();
    }

    private void QuestButtonClickAction()
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
