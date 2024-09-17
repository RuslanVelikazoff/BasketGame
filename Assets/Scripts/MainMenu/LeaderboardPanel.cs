using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Dan.Main;
using UnityEngine.UI;

public class LeaderboardPanel : MonoBehaviour
{
    [SerializeField] 
    private Button backButton;
    [SerializeField]
    private GameObject mainPanel;
    
    [Space(13)]
    
    [SerializeField] 
    private List<TextMeshProUGUI> names;
    [SerializeField] 
    private List<TextMeshProUGUI> scores;

    private string publicLeaderboardKey = 
        "96a2b57dd6af1c5bb2d36f6db28817553af29f9eb94d3f4cbcbb82713d57025b";

    private void Start()
    {
        GetLeaderboard();
        LeaderboardButtonClickAction();
    }

    private void LeaderboardButtonClickAction()
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

    private void GetLeaderboard()
    {
        LeaderboardCreator.GetLeaderboard(publicLeaderboardKey, ((msg) =>
        {
            int loopLenght = (msg.Length < names.Count) ? msg.Length : names.Count;
            for (int i = 0; i < loopLenght; i++)
            {
                names[i].text = msg[i].Username;
                scores[i].text = msg[i].Score.ToString();
            }
        }));
    }
}
