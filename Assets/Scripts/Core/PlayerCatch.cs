using UnityEngine;

public class PlayerCatch : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            CoinManager.Instance.AddCoin();
        }

        if (other.CompareTag("Bomb"))
        {
            Destroy(other.gameObject);
            LivesManager.Instance.Kill();
        }

        if (other.CompareTag("Pill"))
        {
            Destroy(other.gameObject);
            LivesManager.Instance.Health();
        }

        if (other.CompareTag("Poison"))
        {
            Destroy(other.gameObject);
            LivesManager.Instance.Damage();
        }

        if (other.CompareTag("Potion"))
        {
            Destroy(other.gameObject);
            LivesManager.Instance.AddLives();
        }
    }
}
