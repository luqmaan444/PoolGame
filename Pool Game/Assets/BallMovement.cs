using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        float force = 100f;

        if (other.tag == "cue")
        {
            Vector3 dir = other.transform.position - transform.position;
            dir = -dir.normalized;
            rb.AddForce(dir * force);
        }

    }
}
