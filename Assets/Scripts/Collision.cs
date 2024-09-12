using UnityEngine;
using UnityEngine.UI;
using TMPro; 


public class Collision : MonoBehaviour
{
    public ColorSwitch colorSwitch; // Reference to the color switcher script
    public Player player; // Reference to the player script
    public TextMeshProUGUI scoreText; // UI element for score display
    public ParticleSystem collectParticles; // Particle system prefab
    private int score = 0;
    public GameObject destroyEffectPrefab; // Particle system prefab
    public AudioManager soundManager;
    public GameObject panel;

    void Start()
    {
        UpdateScoreText(); // Initialize the score display
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "ColorSwitcher") // Handle color switch
        {
            soundManager.PlayColorChangeSound();
            colorSwitch.SetColor(); // Change the player's color
            Destroy(col.gameObject); // Destroy the color switcher object
        }
        else if (col.tag == "Star") // Handle star collection
        {
            CollectStar(col.gameObject); 
        }
        else if (col.tag != colorSwitch.CurrentColor) // Wrong color collision
        {
            gameObject.SetActive(false);
            Instantiate(destroyEffectPrefab, transform.position, Quaternion.identity);
            soundManager.PlayCollisionSound();
            panel.SetActive(true);
        }
    }

    void CollectStar(GameObject star)
    {
        score++; // Increase the score
        UpdateScoreText(); // Update the score on the UI
        soundManager.PlayStarPickupSound();
        // Instantiate a particle effect on collection
        Instantiate(collectParticles, star.transform.position, Quaternion.identity);

        Destroy(star); // Destroy the star object
    }

    void UpdateScoreText()
    {
        scoreText.text = "Score: " + score.ToString(); // Update the score UI
    }
}
