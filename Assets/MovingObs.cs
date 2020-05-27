
using UnityEngine;

public class MovingObs : MonoBehaviour
{
    public Rigidbody rb;
    public Vector3 initial;
    public Vector3 rot;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Ground")
        {
            //movement.enabled = false;
            transform.position = initial;

            Debug.Log("obs hit the ground!");
        }
    }
}
