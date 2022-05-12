using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueErea : MonoBehaviour
{

    public MeshRenderer ren;
    //public GameObject canvas;

    private void Start()
    {
        ren.enabled = false;
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