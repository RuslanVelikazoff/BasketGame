using UnityEngine;
using UnityEngine.UI;

public class BackgroundManager : MonoBehaviour
{
    public static BackgroundManager Instance { get; private set; }

    [SerializeField] private Sprite[] backgroundSprite;
    [SerializeField] private Image backgroundImage;

    private void Awake()
    {
        Instance = this;
        
        if (!PlayerPrefs.HasKey("SelectedBackground"))
        {
            PlayerPrefs.SetInt("SelectedBackground", 0);
        }

        if (!PlayerPrefs.HasKey("SelectedBasket"))
        {
            PlayerPrefs.SetInt("SelectedBasket", 0);
        }
        
        SetBackgroundImage();
    }

    public void SetBackgroundImage()
    {
        for (int i = 0; i < backgroundSprite.Length; i++)
        {
            if (i == PlayerPrefs.GetInt("SelectedBackground"))
            {
                backgroundImage.sprite = backgroundSprite[i];
            }
        }
    }
}
