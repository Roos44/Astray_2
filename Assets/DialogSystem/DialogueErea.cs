using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueErea : MonoBehaviour
{
    public MeshRenderer Person;
    public GameObject Responts;
    public GameObject All_Teleport_Point;
    public AudioClip[] audioClips;

    DialogueManager dialogueManager;

    public Dialogue dialogue;

    bool isColliding = false;

    private void Start()
    {    
        Person.enabled = false;
        Responts.SetActive(false);

        //creates a reference to the dialogueManager.
        dialogueManager = FindObjectOfType<DialogueManager>();
    }

    
    private void OnTriggerEnter(Collider collider)
    {
        //Makes sure the collision happends once.
        if (isColliding) return;
        isColliding = true;

        //When the player enters the trigger area, the dialogue starts.
        if (collider.gameObject.tag == "Player")
        {
            //Sending all the audio clips to the dialogueManager.
            foreach (AudioClip item in audioClips)
            {
                if (dialogueManager.recievedClips.Count != audioClips.Length)
                {
                    dialogueManager.recievedClips.Add(item);
                }
            }

            //Starts the dialogue.
            dialogueManager.StartDialogue(dialogue);
            Person.enabled = true;
            Responts.SetActive(true);
            All_Teleport_Point.SetActive(false);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        //When the player exits the trigger, the audio clips will be cleared from the dialoguemanager.
        dialogueManager.recievedClips.Clear();
        dialogueManager.audioClips.Clear();
        dialogueManager.EndofDialogue = false;
        
        //Destroys the teleportation point.
        Destroy(gameObject);
        Person.enabled = false;        
    }
}