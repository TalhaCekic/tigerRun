using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hungery : MonoBehaviour
{
 public float lastHungerUpdateTime = 0f;
 public float currentTime;
 public int hunger = 100;
 void Start() {
     InvokeRepeating("omnom", 0, 1f); //90/5 = 18, so over 90 seconds you would have lost 5 hunger.
 }
 
 
 
 void omnom() 
 {
    hunger -= 1;
 }
 
 void Update() {
      currentTime = Time.time;
 
      if(currentTime - lastHungerUpdateTime > 90f) {
           hunger -= 5;
           lastHungerUpdateTime = currentTime;
      }
 
      if(hunger < 1) 
      {
        Destroy(this.gameObject);
      }
 }
}
