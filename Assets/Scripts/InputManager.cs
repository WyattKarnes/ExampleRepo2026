using UnityEngine;

public class InputManager : MonoBehaviour
{
    public static InputManager instance;

    public Vector2 Move;
    private Controls controls;

    private void Awake()
    {
        if (instance != null)
            Destroy(this);
        else
            instance = this;

        controls = new Controls();
        controls.Enable();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        controls.Locomotion.Move.performed += context => Move = context.ReadValue<Vector2>();
        Debug.Log(Move);
    }

    // Update is called once per frame
    private void Update()
    {
    }
}