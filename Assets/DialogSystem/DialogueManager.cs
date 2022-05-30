using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Text nameText;
    public Text dialogueText;
    //public object TriggerEara;

    public Animator animator;

    public AudioSource audioSource;

    private  Queue<string> sentences;    
    
    public Queue<AudioClip> audioClips;
    public List<AudioClip> recievedClips;

    public bool skip;

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
        audioClips = new Queue<AudioClip>();
    }

    void Update()
    {
        if (skip) //Created for simulation the skipp button.
        {
            DisplaynextSentence();
            skip = false;
        }
    }

    public void StartDialogue(Dialogue dialogue)
    {
        animator.SetBool("IsOpen", true);
        nameText.text = dialogue.name;
        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        foreach (AudioClip item in recievedClips)
        {
            audioClips.Enqueue(item);
        }

        DisplaynextSentence();
    }

    //When the skip button is pressed.
    public void DisplaynextSentence()
    {
        if (!endofDialogue)
        {
            if (sentences.Count == 0)
            {
                EndDialogue();
                return;
            }

            string sentence = sentences.Dequeue();
            StopAllCoroutines();
            StartCoroutine(TypeSentence(sentence));

            audioSource.clip = audioClips.Peek();
            audioClips.Dequeue();
            audioSource.Play();
        }
    }

    IEnumerator TypeSentence (string sentence)
    {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return null;
            //DisplaynextSentence();
        }
    }
    
    public bool endofDialogue;

    public void EndDialogue()
    {
        animator.SetBool("IsOpen", false);
        endofDialogue = true;
    }    
}