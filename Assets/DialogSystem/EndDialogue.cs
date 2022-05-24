using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class EndDialogue : MonoBehaviour
{

    public BoxCollider LastD; 
    public BoxCollider EndD; 
    public GameObject Bus;
    
    
    void Start()
    {
        Bus.SetActive(false);
        EndD.enabled = false;
        LastD.enabled = true;
      
    }

    // Update is called once per frame
    void Update()
    {
        OpenLastDidlogueErea();
    }

    void OpenLastDidlogueErea()
    {
        if (LastD == false)
        {
            EndD.enabled = true;
            Bus.SetActive(true);
            Countdown();
        }
    }

    public float timevalue = 10;
    void Countdown()
    {
        if (timevalue > 0)
        {
            timevalue -= Time.deltaTime;
        }
        else
        {
            timevalue = 0;
            Destroy(gameObject);
            
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        }
       
    }

}
