using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueErea : MonoBehaviour
{

    //public MeshRenderer ren;
    public MeshRenderer Person;
    public GameObject Responts;
    public GameObject All_Teleport_Point;
    //public GameObject Bus;
    //public GameObject canvas;

    private void Start()
    {
        //ren.enabled = false;
        Person.enabled = false;
        Responts.SetActive(false);
       //Bus.SetActive(true);
    }

    public Dialogue dialogue;
    private void OnTriggerEnter(Collider collider)
    {

        if (collider.gameObject.tag == "Player")
        {
            //Debug.Log(" we are in BOYYYYS");
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
            Person.enabled = true;
            Responts.SetActive(true);
            All_Teleport_Point.SetActive(false);
           // Bus.SetActive(false);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Destroy(gameObject);
        Person.enabled = false;
        //Bus.SetActive(true);
    }
}