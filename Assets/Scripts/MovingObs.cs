
using UnityEngine;

public class MovingObs : MonoBehaviour
{
    public Rigidbody rb;
    public Vector3 initial;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Ground")
        {
            //movement.enabled = false;
            transform.position = initial;
        }
    }
}
