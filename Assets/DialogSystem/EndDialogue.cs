using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class EndDialogue : MonoBehaviour
{

    //public MeshRenderer ren;
    public BoxCollider LastD; //second last dialog
    public BoxCollider EndD; // ending dialouge 
    public GameObject Bus;
    
    //public GameObject black;
    //public GameObject HospitalDialogue;



    //bool startTheEnd = false;

    // Start is called before the first frame update
    void Start()
    {
        Bus.SetActive(false);
        //ren.enabled = false;
        EndD.enabled = false;
        LastD.enabled = true;
        //black.SetActive(false);
       // HospitalDialogue.SetActive(true);
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
            //ren.enabled = true;
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
            //black.SetActive(true);
        }
        else
        {
            timevalue = 0;
            Destroy(gameObject);
            
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        }
        /*timevalude -= Time.deltaTime;
        if (timevalude < 0)
        {
            Debug.Log("SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1");
        }
        */
    }

}
