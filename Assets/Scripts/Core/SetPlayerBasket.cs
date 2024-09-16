using UnityEngine;

public class SetPlayerBasket : MonoBehaviour
{
    [SerializeField] 
    private GameObject[] basket;

    private void Awake()
    {
        for (int i = 0; i < basket.Length; i++)
        {
            if (i == PlayerPrefs.GetInt("SelectedBasket"))
            {
                basket[i].SetActive(true);
            }
            else
            {
                basket[i].SetActive(false);
            }
        }
    }
}
