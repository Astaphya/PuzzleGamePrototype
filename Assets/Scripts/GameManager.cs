using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private Button NextLevelButton;
    public static int partSayac = 0;

    public ParticleSystem confetti;
    public ParticleSystem confettiBurst;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(partSayac == 3 )
        {
            BolumTamamlandi();
            
        }
        
    }

    public void BolumTamamlandi()
    {
        Debug.Log("Tebrikler. Bölümü tamamladınız.");
        NextLevelButton.gameObject.SetActive(true);
        partSayac = 0;
        Instantiate(confetti,Vector3.zero , confetti.transform.rotation);
        Instantiate(confettiBurst,Vector3.zero,confettiBurst.transform.rotation);
    }

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(1);
    }
}
