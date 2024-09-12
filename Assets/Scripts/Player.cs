using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float jumpforce = 10f;
    public Rigidbody2D rb;
    public float fallThreshold = -2f; 
    private Camera mainCamera;
    public GameObject destroyEffectPrefab; // Particle system prefab
    public AudioManager soundManager;
    private bool clicker;
    public GameObject panel;

    void Start()
    {
        mainCamera = Camera.main; // Get the main camera
        


    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Player jump
        {
            clicker = true;
            rb.velocity = Vector2.up * jumpforce;
            soundManager.PlayJumpSound();
        }

        if (IsOutOfCamera())
        // Fall out of bounds
        {
            RestartGame();
        }
    }
    bool IsOutOfCamera()
    {
        float cameraBottomEdge = mainCamera.transform.position.y - mainCamera.orthographicSize;

        return transform.position.y < cameraBottomEdge + fallThreshold;

    }
    public void RestartGame()
    {
        // Hide the Game Over Panel
        panel.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
}
