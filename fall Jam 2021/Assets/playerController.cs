using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
public Rigidbody2D rgb;
    ayak Ayak;

//Animator  playerAnimator;

bool facingRight = true; // dönme işlemi.

public float harakethızı;
public float zıplamaa;
public bool isgrounded;


void Start()
{
    rgb = GetComponent<Rigidbody2D>();
    //playerAnimator = GetComponent<Animator>();
}


void Update()
{
    
    //koşma
    rgb.velocity = new Vector2(Input.GetAxis("Horizontal") * harakethızı, rgb.velocity.y);
        //playerAnimator.SetFloat("playerSpeed", Mathf.Abs(rgb.velocity.x));
        

        isgrounded = GameObject.Find("ayak").GetComponent<ayak>().isGrounded;

    //zıplama
    //playerAnimator.SetBool("isGroundedAnim", isgrounded);


    float xekseni = Input.GetAxisRaw("Horizontal");                   //hareket...
    rgb.velocity = new Vector2(xekseni * harakethızı, rgb.velocity.y);

    if (Input.GetKeyDown(KeyCode.Space) && isgrounded == true)  //zıplama...
    {
        
        rgb.velocity = Vector2.up * zıplamaa;
      
    }
    
    


    if (rgb.velocity.x > 0 && !facingRight)
    {
        FlipFace();
    }
    else if (rgb.velocity.x < 0 && facingRight)
    {
        FlipFace();
    }

}

private void FixedUpdate()
{
    
}

//private void OnCollisionEnter2D(Collision2D collision)
//{
   // if (collision.gameObject.tag == "zemin")
   // {
    //    isgrounded = true;
   // }
//}
//private void OnCollisionExit2D(Collision2D collision)
// {
//   isgrounded = false;
// }

void FlipFace()
{  //karakterin nereye gidiyorsa oraya denmesini sağlar.
    facingRight = !facingRight;
    Vector3 tempLocalScale = transform.localScale;
    tempLocalScale.x *= -1;
    transform.localScale = tempLocalScale;
}

}
