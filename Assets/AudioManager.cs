using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioClip jumpSound; 
    public AudioClip collisionSound; 
    public AudioClip colorChangeSound; 
    public AudioClip starPickupSound; 

    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayJumpSound()
    {
        audioSource.PlayOneShot(jumpSound);
    }

    public void PlayCollisionSound()
    {
        audioSource.PlayOneShot(collisionSound);
    }

    public void PlayColorChangeSound()
    {
        audioSource.PlayOneShot(colorChangeSound);
    }

    public void PlayStarPickupSound()
    {
        audioSource.PlayOneShot(starPickupSound);
    }
}
