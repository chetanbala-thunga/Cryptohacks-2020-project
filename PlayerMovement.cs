using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public PlayerMovement movement;

    public float fForce = 2000f;
    public float rForce = 500f;
    public float lForce = -500f;

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0,0,fForce * Time.deltaTime);

        if (Input.GetKey("d")){
            rb.AddForce(rForce * Time.deltaTime,0,0, ForceMode.VelocityChange);
        }
        
        if (Input.GetKey("a")){
            rb.AddForce(lForce * Time.deltaTime,0,0,ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<Manager>().EndGame();
        }
    }
}
