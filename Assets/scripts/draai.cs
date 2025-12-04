using UnityEngine;

public class draai : MonoBehaviour
{
    public float rotationSpeed = 100f; // Snelheid van rotatie in graden per seconde

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Draai het object rond de Z-as
        transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
    }
}
