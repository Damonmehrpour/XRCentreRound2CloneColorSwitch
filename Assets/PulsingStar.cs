using UnityEngine;

public class PulsingStar : MonoBehaviour
{
    public float pulseSpeed = 2f; // Speed of the pulsing
    public float minScale = 0.8f; // Minimum scale size
    public float maxScale = 1.2f; // Maximum scale size

    private Vector3 initialScale;

    void Start()
    {
        initialScale = transform.localScale; // Store the initial scale
    }

    void Update()
    {
        // Calculate the scale factor based on a sine wave
        float scale = Mathf.Lerp(minScale, maxScale, Mathf.PingPong(Time.time * pulseSpeed, 1));

        // Apply the scale to the object
        transform.localScale = initialScale * scale;
    }
}
