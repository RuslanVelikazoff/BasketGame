using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UsernameManager : MonoBehaviour
{
    [SerializeField]
    private TMP_InputField usernameInputField;
    [SerializeField] 
    private Button saveButton;
    
    private void Awake()
    {
        if (!PlayerPrefs.HasKey("Username"))
        {
            PlayerPrefs.SetString("Username", "Player");
        }
        else
        {
            usernameInputField.text = PlayerPrefs.GetString("Username");
        }
        
        SetUsername();
    }

    private void SetUsername()
    {
        if (saveButton != null)
        {
            saveButton.onClick.RemoveAllListeners();
            saveButton.onClick.AddListener(() =>
            {
                if (usernameInputField.text != string.Empty)
                {
                    PlayerPrefs.SetString("Username", usernameInputField.text);
                }
            });
        }
    }
}
