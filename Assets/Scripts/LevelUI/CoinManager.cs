using TMPro;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    public static CoinManager Instance { get; private set; }

    [SerializeField] 
    private TextMeshProUGUI coinText;

    private int coin;

    private void Awake()
    {
        Instance = this;
        coin = 0;
        UpdateCoinText();
    }

    public void AddCoin()
    {
        AudioManager.Instance.Play("Coin");
        coin++;
        UpdateCoinText();
    }

    public void UpdateCoinText()
    {
        coinText.text = coin.ToString();
    }

    public void AddCoinToData()
    {
        CoinData.Instance.AddCoin(coin);
    }

    public int GetCoinAmount()
    {
        return coin;
    }
}
