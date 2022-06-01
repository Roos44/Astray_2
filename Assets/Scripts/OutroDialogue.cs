using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OutroDialogue : MonoBehaviour
{

    DialogueManager dialogueManager;

    [SerializeField] GameObject DiaLogueManager;

    void Start()
    {
        dialogueManager = DiaLogueManager.GetComponent<DialogueManager>();
    }

    // Update is called once per frame
    void Update()
    {
        EndTheGame();
    }

    public void EndTheGame()
    {
        if (dialogueManager.endofDialogue == true)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

}
