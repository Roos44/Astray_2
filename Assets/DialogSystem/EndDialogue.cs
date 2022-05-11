using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class EndDialogue : MonoBehaviour
{

    public MeshRenderer ren;
    public BoxCollider LastD;
    public BoxCollider EndD;
    public GameObject black;
    public GameObject HospitalDialogue;


   
    //bool startTheEnd = false;

    // Start is called before the first frame update
    void Start()
    {
        ren.enabled = false;
        EndD.enabled = false;
        LastD.enabled = true;
        black.SetActive(false);
        HospitalDialogue.SetActive(false);
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
            ren.enabled = true;
            Countdown();

            //System.Threading.Thread.Sleep(1000);

        }
    }

    public float timevalue = 10;
    void Countdown()
    {
        if (timevalue > 0)
        {
            timevalue -= Time.deltaTime;
            black.SetActive(true);
        }
        else
        {
            timevalue = 0;
            Destroy(gameObject);
            HospitalDialogue.SetActive(true);
            Debug.Log("SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1");
        }
        /*timevalude -= Time.deltaTime;
        if (timevalude < 0)
        {
            Debug.Log("SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1");
        }
        */
    }

}
