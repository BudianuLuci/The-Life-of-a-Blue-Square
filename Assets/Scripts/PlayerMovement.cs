
using System.Diagnostics;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float movementForce = 40f; //40f

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("d"))
        {
            rb.AddForce(0, 0, -movementForce * Time.deltaTime, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(0, 0, movementForce * Time.deltaTime, ForceMode.VelocityChange);
        }
        if (Input.GetKey("w"))
        {
            rb.AddForce(movementForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(-movementForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKeyDown("space"))
        {
            if (transform.position.y >= 0.99 && transform.position.y <=1.01)
            {
                rb.AddForce(0, 5200 * movementForce * Time.deltaTime, 0);
            }
           
        }

    }
}
