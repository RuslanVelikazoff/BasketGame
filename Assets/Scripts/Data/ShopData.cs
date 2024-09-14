using UnityEngine;

public class ShopData : MonoBehaviour
{
    public static ShopData Instance;

    private bool[] _buyBackground;
    private bool[] _buyBasket;

    private string SaveKey = "MainSaveShop";

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        Load();
    }

    private void OnDisable()
    {
        Save();
    }

    private void OnApplicationQuit()
    {
        Save();
    }

    private void OnApplicationPause(bool pauseStatus)
    {
        if (pauseStatus)
        {
            Save();
        }
    }

    private void Load()
    {
        var data = SaveManager.Load<GameData>(SaveKey);

        _buyBackground = data.buyBackground;
        _buyBasket = data.buyBasket;
        
        Debug.Log("Shop data loaded");
    }

    private void Save()
    {
        SaveManager.Save(SaveKey, GetSaveSnapshot());
        PlayerPrefs.Save();
        
        Debug.Log("Shop data saved");
    }

    private GameData GetSaveSnapshot()
    {
        var data = new GameData()
        {
            buyBackground = _buyBackground,
            buyBasket = _buyBasket
        };

        return data;
    }

    public bool IsBuyBackground(int index)
    {
        return _buyBackground[index];
    }

    public void BuyBackground(int index)
    {
        _buyBackground[index] = true;
    }

    public bool IsBuyBasket(int index)
    {
        return _buyBasket[index];
    }

    public void BuyBasket(int index)
    {
        _buyBasket[index] = true;
    }
}
