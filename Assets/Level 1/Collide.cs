using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collide : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D other) 
    {
       Debug.Log("Çarpışma");
       if(other.gameObject.CompareTag("Image1") )
        {
            other.gameObject.transform.localPosition = new Vector3(this.transform.parent.localPosition.x + 250 , this.transform.parent.localPosition.y, 0);
            Debug.Log("Image1");
            this.transform.parent.GetComponent<Dragable>().enabled = false;
            this.transform.parent.SetParent(other.gameObject.transform);
            this.gameObject.SetActive(false);
            this.gameObject.transform.parent.GetComponent<Hareket>().enabled = false;
            GameManager.partSayac ++;
            //other.GetComponent<Dragable>().enabled = false ;

        }

        /*
        else if(other.gameObject.CompareTag("Image2"))
        {
            other.gameObject.transform.localPosition = new Vector3(this.transform.parent.localPosition.x , this.transform.parent.localPosition.y -250, 0);
            Debug.Log("Image2");
            other.gameObject.GetComponent<Dragable>().enabled = false;
            other.transform.SetParent(this.transform.parent.gameObject.transform);
        }
        */

        /*
        else if (other.gameObject.CompareTag("Image3"))
        {
            other.gameObject.transform.position = new Vector3(this.transform.parent.position.x , this.transform.parent.position.y -52.5f, 0);
            Debug.Log("Image3");
            other.gameObject.GetComponent<Dragable>().enabled = false;
            other.transform.SetParent(this.transform.parent.gameObject.transform);

        }
        */
        
    }
}
