using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float forwardForce = 25f;
    public float sidewaysForce = 0f;

    void FixedUpdate ()
    {

        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, forwardForce);
        }

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}