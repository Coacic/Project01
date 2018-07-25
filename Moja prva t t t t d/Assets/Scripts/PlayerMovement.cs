using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float forwardForce = 25f;
    private float sidewaysForce = 1f;

    public float SidewaysForce
    {
        get
        {
            return sidewaysForce;
        }

        set
        {
            sidewaysForce = value;
        }
    }

    public float SidewaysForce1
    {
        get
        {
            return sidewaysForce;
        }

        set
        {
            sidewaysForce = value;
        }
    }

    void FixedUpdate ()
    {
     rb.AddForce(0, 0, z: 25f);

        if (Input.GetKey("d"))
        {
            rb.AddForce(SidewaysForce, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-SidewaysForce, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}