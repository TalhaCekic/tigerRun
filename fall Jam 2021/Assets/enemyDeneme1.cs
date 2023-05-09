using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyDeneme1 : MonoBehaviour
{
public GameObject target; //the enemy's target
    public float moveSpeed = 5; //move speed
    
    void Start()
    {
        
    }
    void Update()
    {
       


    }
    void OnTriggerEnter2D(Collider2D enemyArea)
    {
      if(enemyArea.tag == "Player")
      {
        target = GameObject.FindGameObjectWithTag("Player");
        Vector2 targetDir = target.transform.position - transform.position;
        float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;
        Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, q, 180);
        transform.Translate(Vector3.up * Time.deltaTime * moveSpeed);
      }
    }
}
