
using UnityEngine;

public class HorziontalMovingObstacles : MonoBehaviour
{
    public Rigidbody rb;
    public Transform posinitial;
    void Start()
    {   
        if (posinitial.position.z > 0)
        {
            rb.AddForce(0, 0, -500000 * Time.deltaTime);
        }
        else
        {
            rb.AddForce(0, 0, 500000 * Time.deltaTime);
        }
        
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
        if (collisionInfo.collider.name == "HMovingObstacleLeft")
        {
            rb.AddForce(0, 0, -500000 * Time.deltaTime);
        }
        if (collisionInfo.collider.name == "HMovingObstacleRight")
        {
            rb.AddForce(0, 0, 500000 * Time.deltaTime);
        }
       
    }
}
