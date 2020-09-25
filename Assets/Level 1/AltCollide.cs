using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AltCollide : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) 
    {
       Debug.Log("Çarpışma");
       if(other.gameObject.CompareTag("Image2") )
        {
            other.transform.SetParent(this.transform.parent.gameObject.transform);
            other.gameObject.transform.localPosition = new Vector3(0 , -250, 0);
            Debug.Log("Image2");
            other.gameObject.GetComponent<Dragable>().enabled = false;
            GameManager.partSayac++;
            this.gameObject.SetActive(false);
            other.gameObject.transform.GetComponent<Hareket>().enabled = false;

        }
}
}
