using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class HintManager : MonoBehaviour
{
    [SerializeField] 
    private Image hintImage;
    [SerializeField] 
    private Sprite[] hintSprite;

    private void Awake()
    {
        int randomIndex = Random.Range(0, hintSprite.Length);
        hintImage.sprite = hintSprite[randomIndex];
    }
}
