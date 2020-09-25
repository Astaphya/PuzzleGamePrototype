using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hareket : MonoBehaviour
{
    private float yariCap = 0.1f;
    private float hiz = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float y = Mathf.Sin(Time.time * hiz) * yariCap;
        transform.position = new Vector3(transform.position.x,transform.position.y+y,transform.position.z);
    }
}
