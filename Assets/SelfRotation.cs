using UnityEngine;

public class SelfRotation : MonoBehaviour
{
    public float rotationSpeed; 

    void Update()
    {
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
}
