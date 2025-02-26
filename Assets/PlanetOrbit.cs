using UnityEngine;

public class PlanetOrbit : MonoBehaviour
{
    public Transform sun;
    public float orbitSpeed;
    public float orbitRadius;

    private float currentAngle = 0f;
    void Start()
    {
        Vector3 localStartPosition = new Vector3(orbitRadius, 0, 0);
        transform.position = sun.position + transform.parent.rotation * localStartPosition;
    }

    void Update()
    {
        currentAngle += orbitSpeed * Time.deltaTime;
        Vector3 localOffset = new Vector3(Mathf.Cos(currentAngle * Mathf.Deg2Rad) * orbitRadius, 0, Mathf.Sin(currentAngle * Mathf.Deg2Rad) * orbitRadius);
        transform.position = sun.position + transform.parent.rotation * localOffset;
    }
}


