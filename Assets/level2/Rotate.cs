using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField]
    private float rotationRate = 0.1f;
    
    private void Update() {
       // float rotZ = Input.GetAxis("Vertical") * rotateSpeed * Mathf.Deg2Rad;
       // transform.Rotate(0,0,-rotZ);

        Touch touch = Input.GetTouch(0);
         if (touch.phase == TouchPhase.Moved)
            {
                Debug.Log("Touch phase Moved");
                transform.Rotate(0,
                                 0, -touch.deltaPosition.y*rotationRate, Space.World);
            }

        }

    }
     

