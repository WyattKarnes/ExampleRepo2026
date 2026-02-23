using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private float xRot = 15;

    [SerializeField] private float yRot = 15;

    [SerializeField] private float zRot = 15;

    private float rotSpeed = 5;

    // Update is called once per frame
    private void Update()
    {
        transform.Rotate(new Vector3(xRot, yRot, zRot) * Time.deltaTime);
    }
}