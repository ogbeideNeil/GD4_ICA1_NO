using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 0.12f;

    public Vector3 offset;

    void LateUpdate()
    {
        transform.position = target.position + offset;   
    }
}
