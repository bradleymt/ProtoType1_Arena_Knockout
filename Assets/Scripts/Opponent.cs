using UnityEngine;

public class Opponent : MonoBehaviour
{
    public float moveForce = 10f;
    public float maxSpeed = 4f;
    public float fallLimit = -5f;

    public Transform player;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        if (player == null)
        {
            GameObject p = GameObject.FindGameObjectWithTag("Player");
            if (p != null)
            {
                player = p.transform;
            }
        }
    }

    void FixedUpdate()
    {
        if (player == null)
        {
            return;
        }

        Vector3 direction = player.position - transform.position;
        direction.y = 0f;
        direction.Normalize();

        Vector3 flatVelocity = new Vector3(rb.linearVelocity.x, 0f, rb.linearVelocity.z);
        if (flatVelocity.magnitude < maxSpeed)
        {
            rb.AddForce(direction * moveForce);
        }
    }

    void Update()
    {
        if (transform.position.y < fallLimit)
        {
            Debug.Log("Opponent died");
            Destroy(gameObject);
        }
    }
}