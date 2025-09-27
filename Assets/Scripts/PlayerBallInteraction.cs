using UnityEngine;

public class PlayerBallInteraction : MonoBehaviour
{
    public GameObject ball;
    public GameObject player;
    private Rigidbody ballRigidbody;
    public float launchAccelaration = 10f;
    public float initialVelocity = 5f;

    void Start()
    {
        ballRigidbody = ball.GetComponent<Rigidbody>();
    }

    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == ball)
        {
            float time = 1f;
            Vector3 launchForce = (0.5f * launchAccelaration * time * time + initialVelocity * time) * transform.right;
            ballRigidbody.AddForce(launchForce, ForceMode.Force);
        }
    }
}
