using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueErea : MonoBehaviour
{

    public MeshRenderer ren;

    private void Start()
    {
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

        }
    }

    private void OnTriggerExit(Collider other)
    {
        Destroy(gameObject);
    }

}
