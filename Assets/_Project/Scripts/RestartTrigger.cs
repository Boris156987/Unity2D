using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartTrigger : MonoBehaviour
{
    public AudioClip sfxClip;
    public float delayBeforeReload = 0.5f;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            MusicManager.Instance.StopMusic();
            AudioManager.Instance.PlaySFX(sfxClip, 1f);
            Invoke(nameof(ReloadScene), delayBeforeReload);
        }
    }

    private void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}