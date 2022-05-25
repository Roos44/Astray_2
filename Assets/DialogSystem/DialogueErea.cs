using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueErea : MonoBehaviour
{
    public MeshRenderer Person;
    public GameObject Responts;
    public GameObject All_Teleport_Point;
    public AudioClip[] audioClips;

    //DialogueManager dialogueManager;

    public Dialogue dialogue;

    private void Start()
    {    
        Person.enabled = false;
        Responts.SetActive(false);

        //ref naar manager script
        //dialogueManager = FindObjectOfType<DialogueManager>();
    }

    
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {


            //foreach (AudioClip item in audioClips)
            //{
            //    dialogueManager.recievedClips.Add(item);
            //}

            //AudioDialogue.Play();
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
            Person.enabled = true;
            Responts.SetActive(true);
            All_Teleport_Point.SetActive(false);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Destroy(gameObject);
        Person.enabled = false;        
    }
}