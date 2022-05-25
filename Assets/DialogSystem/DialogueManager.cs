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
    Queue<AudioClip> AudioClips;

    public List<AudioClip> recievedClips;

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();

        AudioClips = new Queue<AudioClip>();
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

        //AudioClips.Clear();
        //recievedClips.Clear();

        foreach (AudioClip item in recievedClips)
        {
            AudioClips.Enqueue(item);
        }
        //AudioClips.Enqueue(recievedClips[0]);

        DisplaynextSentence();    

    }

    public void DisplaynextSentence()
    {
        if (sentences.Count == 0 )
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));

        audioSource.clip = AudioClips.Dequeue();
        audioSource.Play();

        //AudioClip audioclip = AudioClips.Dequeue();
        //audioSource.Stop();
        //audioSource.clip = audioclip;
        //audioSource.Play();

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

    public bool EndofDialogue;

    public void EndDialogue()
    {
        animator.SetBool("IsOpen", false);
        EndofDialogue = true;
    }

    
}