using TMPro;
using UnityEngine;

public class CoinMenuPanel : MonoBehaviour
{
    public CoinMenuPanel Instance { get; private set; }

    [SerializeField] 
    private TextMeshProUGUI coinText;

    private void Awake()
    {
        Instance = this;
    }

    private void OnEnable()
    {
        UpdateCoinText();
    }

    public void UpdateCoinText()
    {
        coinText.text = CoinData.Instance.GetCoinAmount().ToString();
    }
}
