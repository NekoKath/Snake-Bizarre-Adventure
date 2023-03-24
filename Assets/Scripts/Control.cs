using UnityEngine;

public class Control : MonoBehaviour
{
    private Vector3 _previousMousePosition;
    public float Sensitivity;

    void Update()
    {
        Vector3 curPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z);

        if (Input.GetMouseButton(0))
        {
            Vector3 delta = Input.mousePosition - _previousMousePosition;
            if ((curPosition.x + delta.x * Sensitivity) >= 4.5f || (curPosition.x + delta.x * Sensitivity) <= -4.5f)
            {
                delta.x = 0f;
            }
            transform.position = new Vector3(curPosition.x + delta.x * Sensitivity, 0.5f, transform.position.z);
            curPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        }
        _previousMousePosition = Input.mousePosition;
    }
}
