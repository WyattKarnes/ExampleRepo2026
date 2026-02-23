using TMPro;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(AudioSource))]
public class PlayerController : MonoBehaviour
{
    public float speed = 10;

    [SerializeField] private int score;
    [SerializeField] private TextMeshProUGUI scoreText;
    private InputManager input;

    private Rigidbody rb;

    [SerializeField] private AudioClip coinNoise;
    private AudioSource audioSource;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
        input = InputManager.instance;
    }

    // Update is called once per frame
    private void Update()
    {
    }

    private void FixedUpdate()
    {
        var move = new Vector3(input.Move.x, 0, input.Move.y);
        rb.AddForce(move * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("pickup"))
        {
            audioSource.clip = coinNoise;
            audioSource.Play();
            score++;
            scoreText.SetText("Score: " + score);
            Destroy(other.gameObject);
        }
    }
}