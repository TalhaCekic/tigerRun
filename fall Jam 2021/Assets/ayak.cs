using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ayak : MonoBehaviour
{
    public bool isGrounded;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ground")
        {
            isGrounded = true;
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        isGrounded = false;
    }



}
