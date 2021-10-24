using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1Move : MonoBehaviour
{
    Rigidbody rb;
    public float EnemyJumpRate = 1000;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.up * EnemyJumpRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
