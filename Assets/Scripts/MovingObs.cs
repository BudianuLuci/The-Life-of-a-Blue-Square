
using UnityEngine;

public class MovingObs : MonoBehaviour
{
    public Rigidbody rb;
    public Transform pos;
    Vector3 initialpos;
    public float initialY;


    void Start()
    {
        initialpos = transform.position;
    }
    void OnCollisionEnter(Collision collisionInfo)
    {

        if (collisionInfo.collider.tag == "Ground")
        {
            transform.position = initialpos;
        }
    }
}
