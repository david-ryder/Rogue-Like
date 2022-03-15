using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int force;
    public Rigidbody2D rb;

    // Update is called once per frame
    void Update()
    {
        // Move up
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.AddForce(transform.up * force);
        }
        else if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            rb.AddForce(transform.up * -force);
        }

        // Move right
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rb.AddForce(transform.right * force);
        }
        else if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            rb.AddForce(transform.right * -force);
        }

        // Move down
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            rb.AddForce(transform.up * -force);
        }
        else if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            rb.AddForce(transform.up * force);
        }

        // Move left
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rb.AddForce(transform.right * -force);
        }
        else if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            rb.AddForce(transform.right * force);
        }
    }
}
