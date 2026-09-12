using UnityEngine;
using TMPro;

public class Collectible : MonoBehaviour
{
    private static int coins;
    public TMP_Text textCoins;
    public AudioClip coinClip;

    private void Awake()
    {
        coins = 0;
        if (textCoins != null)
            textCoins.text = coins.ToString();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            AudioManager.Instance.PlaySFX(coinClip, 0.5f);

            coins++;
            textCoins.text = coins.ToString();
            Destroy(gameObject);
        }
    }
}