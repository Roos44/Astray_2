using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueErea : MonoBehaviour
{

    public MeshRenderer ren;
    //public GameObject canvas;

    private void Start()
    {
        //canvas.SetActive(false);
        ren.enabled = false;
        //indObjectOfType(MeshRenderer)
        //MeshRenderer.enabled = false
        //Getcomponent.GameObject(MeshRenderer) = false;
        //look.Get
    }

    public Dialogue dialogue;
    private void OnTriggerEnter(Collider collider)
    {

        if (collider.gameObject.tag == "Player")
        {
            //Debug.Log(" we are in BOYYYYS");
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
            //canvas.SetActive(true);

        }
    }

    private void OnTriggerExit(Collider other)
    {
        Destroy(gameObject);
    }

    //public bool EndofDialogue;
    /*void Test()
    {
        if (FindObjectOfType<DialogueManager>().EndDialogue(EndofDialogue = true))
        {
           \(-_-\) help
        }
    }
    */
}
