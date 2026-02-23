using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform target;
    private Vector3 dist;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        dist = target.position - transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = target.position - dist;
    }
}
