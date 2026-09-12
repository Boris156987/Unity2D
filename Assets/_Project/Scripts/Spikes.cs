using UnityEngine;
using UnityEngine.SceneManagement;

public class Spikes : MonoBehaviour
{
    public AudioClip deathClip;
    public float delayBeforeReload = 0.5f;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            MusicManager.Instance.StopMusic();
            AudioManager.Instance.PlaySFX(deathClip, 1f);
            Invoke(nameof(ReloadScene), delayBeforeReload);
        }
    }

    private void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}