using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioClip PauseSound;
    public AudioClip UnpauseSound;
    public AudioClip StartGameSound;
    public AudioClip StartScreenReturnSound;
    public AudioClip GameOverSound;
    public AudioClip RoundStartSound;
    public AudioClip PurchaseSound;
    public AudioClip CursorHoverSound;
    
    private AudioSource audioSource;
    
    public void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayPauseSound()
    {
        audioSource.PlayOneShot(PauseSound);
    }
    
    public void PlayUnpauseSound()
    {
        audioSource.PlayOneShot(UnpauseSound);
    }

    public void PlayStartGameSound()
    {
        audioSource.PlayOneShot(StartGameSound);
    }

    public void PlayStartScreenReturnSound()
    {
        audioSource.PlayOneShot(StartScreenReturnSound);
    }
    
    public void PlayGameOverSound()
    {
        audioSource.PlayOneShot(GameOverSound);
    }

    public void PlayRoundStartSound()
    {
        audioSource.PlayOneShot(RoundStartSound);
    }

    public void PlayPurchaseSound()
    {
        audioSource.PlayOneShot(PurchaseSound);
    }

    public void PlayCursorHoverSound()
    {
        audioSource.PlayOneShot(CursorHoverSound);
    }
}