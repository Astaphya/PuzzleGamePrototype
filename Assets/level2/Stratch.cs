using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stratch : MonoBehaviour
{
    public GameObject maskPrefab;
    // Start is called before the first frame update
    void Start()
    {
        GameObject maskSprite = Instantiate(maskPrefab,this.transform.position,maskPrefab.transform.rotation);
        maskSprite.transform.SetParent(this.gameObject.transform,false); 
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.hasChanged)
        {
            
        }
    }
}
