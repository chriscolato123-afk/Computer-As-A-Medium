using UnityEngine;

public class PowerUpSounds : MonoBehaviour
{
    public AudioClip powerUpSound;
    public AudioClip powerDownSound;

    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayPowerUp()
    {
        audioSource.PlayOneShot(powerUpSound);
    }

    public void PlayPowerDown()
    {
        audioSource.PlayOneShot(powerDownSound);
    }
}