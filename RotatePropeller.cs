using UnityEngine;

public class RotatePropeller : MonoBehaviour
{
    private float rotationSpeed = 1500.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,0,rotationSpeed*Time.deltaTime);
    }
}
