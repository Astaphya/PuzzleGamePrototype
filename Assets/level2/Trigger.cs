using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public static int triggerCount;
    private void Start() 
    {
        triggerCount++;
    }
   private void OnTriggerEnter2D(Collider2D other) 
   {
       if(other.gameObject.CompareTag("Ball"))
       {
           Destroy(this.gameObject);
          // triggerCount--;
       }
       
   }
   private void OnDisable() {
       triggerCount--;
   }
}
