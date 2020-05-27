
using UnityEngine;

public class HorziontalMovingObstacle : MonoBehaviour
{
    public Rigidbody rb;
    public Vector3 initial;
    public Transform posinitial;
    void Start()
    {
        rb.AddForce(0, 0, 500000 * Time.deltaTime);
    }

    void OnCollisionEnter(Collision collisionInfo)
    {

        if (collisionInfo.collider.name == "WallRight")
        {
            rb.AddForce(0, 0, 500000 * Time.deltaTime);
        }
        if (collisionInfo.collider.name == "WallLeft")
        {
            rb.AddForce(0, 0, -500000 * Time.deltaTime);
        }
        //rb.AddForce(0, 0, -500000 * Time.deltaTime);
        //if (collisionInfo.collider.tag == "Ground")
        //{

        //  transform.position = initial;

        //}
    }
}
