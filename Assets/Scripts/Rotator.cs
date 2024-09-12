
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float RotationSpeed = 100f;//speed rotation (changeable)
    void Update()
    {
        transform.Rotate(0f, 0f, RotationSpeed * Time.deltaTime);
    }
}
