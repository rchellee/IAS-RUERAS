using UnityEngine;

public class Rotator : MonoBehaviour
{
    // The speed at which the GameObject rotates.
    public float speed = 10.0f;

    // Update is called once per frame.
    void Update()
    {
        // Rotate the GameObject around the Y-axis.
        transform.Rotate(0.0f, speed * Time.deltaTime, 0.0f);
    }
}
