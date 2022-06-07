using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class EndDialogue : MonoBehaviour
{

    //public BoxCollider LastD; 
    //public BoxCollider EndD; 
    public GameObject Bus;
    private bool StartTheTimer;
    
    void Start()
    {
        Bus.SetActive(false);
        StartTheTimer = false;
    }

    private void Update()
    {
        if (StartTheTimer == true)
        {
            Countdown();
        }
    }
    private void OnTriggerEnter(Collider collider)
    {
        StartTheTimer = true;
        Bus.SetActive(true);
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
