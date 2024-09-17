using UnityEngine;
using Dan.Main;

public class UpdateLeaderboard : MonoBehaviour
{
    private string publicLeaderboardKey = "96a2b57dd6af1c5bb2d36f6db28817553af29f9eb94d3f4cbcbb82713d57025b";
    
    public void SetLeaderboardEntry(int score)
    {
        LeaderboardCreator.UploadNewEntry(publicLeaderboardKey, PlayerPrefs.GetString("Username"), score);
    }
}
