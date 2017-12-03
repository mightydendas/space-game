using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class ShipEngine : MonoBehaviour {

    [SerializeField]
    int acceleration;
    [SerializeField]
    int maxSpeed;
    [SerializeField]
    int torque;

    Rigidbody2D rb;

    void Start () {
        rb = GetComponent<Rigidbody2D>();
    }

    // Clamping max speed
    void Update () {
        if (rb.velocity.magnitude > maxSpeed) {
            rb.velocity = rb.velocity.normalized * maxSpeed;
        }
    }

    // Movement
    void FixedUpdate() {
        if (Input.GetKey(KeyCode.Q))
            rb.AddRelativeForce(Vector2.left * acceleration * Time.fixedDeltaTime);

        if (Input.GetKey(KeyCode.E))
            rb.AddRelativeForce(Vector2.right * acceleration * Time.fixedDeltaTime);

        if (Input.GetKey(KeyCode.W))
            rb.AddRelativeForce(Vector2.up * acceleration * Time.fixedDeltaTime);

        if (Input.GetKey(KeyCode.S))
            rb.AddRelativeForce(Vector2.down * acceleration * Time.fixedDeltaTime);

        if (Input.GetKey(KeyCode.A))
            rb.AddTorque(torque * Time.fixedDeltaTime);

        if (Input.GetKey(KeyCode.D))
            rb.AddTorque(-torque * Time.fixedDeltaTime);
    }
}

