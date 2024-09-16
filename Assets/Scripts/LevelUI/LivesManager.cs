using UnityEngine;
using UnityEngine.UI;

public class LivesManager : MonoBehaviour
{
    public static LivesManager Instance { get; private set; }

    [SerializeField] 
    private Image[] livesImage;
    [SerializeField]
    private Sprite activeLiveSprite;
    [SerializeField]
    private Sprite inactiveLiveSprite;

    [SerializeField] 
    private GameObject losePanel;
    
    private int currentLives = 3;

    private void Awake()
    {
        Instance = this;
    }

    public void AddLives()
    {
        currentLives++;
        if (currentLives > 3)
        {
            currentLives = 3;
        }
        SetLiveSprites();
    }

    public void Damage()
    {
        currentLives--;
        if (currentLives <= 0)
        {
            losePanel.SetActive(true);
        }
        SetLiveSprites();
    }

    private void SetLiveSprites()
    {
        switch (currentLives)
        {
            case 0:
                for (int i = 0; i < livesImage.Length; i++)
                {
                    livesImage[i].sprite = inactiveLiveSprite;
                }
                break;
            case 1:
                livesImage[0].sprite = activeLiveSprite;
                livesImage[1].sprite = inactiveLiveSprite;
                livesImage[2].sprite = inactiveLiveSprite;
                break;
            case 2:
                livesImage[0].sprite = activeLiveSprite;
                livesImage[1].sprite = activeLiveSprite;
                livesImage[2].sprite = inactiveLiveSprite;
                break;
            case 3:
                for (int i = 0; i < livesImage.Length; i++)
                {
                    livesImage[i].sprite = activeLiveSprite;
                }
                break;
        }
    }
}
