using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BilliardBall_Sink : MonoBehaviour
{
    public float SinkSpeed;
    public GameObject BilliardBall;
    private Rigidbody BallCol;
    private float BallSpeed;

    void Awake()
    {

        BallCol = GetComponent<Rigidbody>();
        Vector3 Velocity = BallCol.velocity;
        BallSpeed = BallCol.velocity.magnitude;
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Pockets" && BallSpeed < SinkSpeed)
        {
            Destroy(BilliardBall);
        }
    }

}
