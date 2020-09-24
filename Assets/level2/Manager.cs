using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{

    public ParticleSystem confetti;
    public ParticleSystem confettiBurst;
    // Update is called once per frame
    void Update()
    {
       // Debug.Log(Trigger.triggerCount);
       Debug.Log(Trigger.triggerCount);

        if(Trigger.triggerCount == 0)
        {
            Completed();
        }
    }

    public void Completed()
    {
        //confetti.SetActive(true);
        //confettiBurst.gameObject.SetActive(true);
        Instantiate(confetti,Vector3.zero,confetti.transform.rotation);
         Instantiate(confettiBurst,Vector3.zero,confettiBurst.transform.rotation);
        confetti.Play();
        confettiBurst.Play();
        Trigger.triggerCount = 50;
        
        Debug.Log("Bölüm tamamlandi.");
    }
}
