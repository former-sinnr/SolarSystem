using UnityEngine;

public class OrbitPath : MonoBehaviour
{
    public LineRenderer lineRenderer;
    public int segments = 100;
    public float radius;

    public float rotationController = 65f;

    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.positionCount = segments + 1;
        lineRenderer.useWorldSpace = false;

        DrawOrbit();
    }

    void DrawOrbit()
    {
        float angle = 0f;
        for (int i = 0; i <= segments; i++)
        {
            float x = Mathf.Cos(angle) * radius;
            float z = Mathf.Sin(angle) * radius;
            lineRenderer.SetPosition(i, new Vector3(x, 0, z));
            angle += (2 * Mathf.PI) / segments;
        }
    }
}
