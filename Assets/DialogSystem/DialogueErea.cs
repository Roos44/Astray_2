using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueErea : MonoBehaviour
{
    public GameObject Person;
    public GameObject Responts;
    public GameObject All_Teleport_Point;

    public AudioClip[] audioClips;

    DialogueManager dialogueManager;

    public Dialogue dialogue;

    bool isColliding = false;

    private void Start()
    {    
        Person.SetActive(false);
        Responts.SetActive(false);
    }

    
    private void OnTriggerEnter(Collider collider)
    {

        print("Trigger");
        Debug.Log("enter"); // mischien enterd de player te vaak?

        //creates a reference to the dialogueManager.
        dialogueManager = FindObjectOfType<DialogueManager>();

        //Makes sure the collision happends once.
        if (isColliding) return;
        isColliding = true;

        print("Trigger functions");

        print("Adding the clips to the dialogueManager");
        //Sending all the audio clips to the dialogueManager.
        foreach (AudioClip item in audioClips)
        {
            if (dialogueManager.recievedClips.Count != audioClips.Length)
            {
                dialogueManager.recievedClips.Add(item);
            }
        }

        print("Starting the dialogue");
        //Starts the dialogue.
        dialogueManager.StartDialogue(dialogue);
        Person.SetActive(true);
        Responts.SetActive(true);
        All_Teleport_Point.SetActive(false);
    }

    private void OnTriggerExit(Collider other)
    {
        //When the player exits the trigger, the audio clips will be cleared from the dialoguemanager.
        dialogueManager.recievedClips.Clear();
        dialogueManager.audioClips.Clear();
        dialogueManager.endofDialogue = false;
        
        //Destroys the teleportation point.
        //Destroy(gameObject);
        Person.SetActive(false);
    }
}