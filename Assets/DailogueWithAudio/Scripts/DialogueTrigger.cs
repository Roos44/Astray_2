using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour {

	public Dialogue dialogue2;

	void OnTriggerEnter(Collider col){
		if(col.gameObject.tag == "Player"){
			//This Line Triggers Dialogue
			FindObjectOfType<DialogueManager>().StartDialogue(dialogue2);
		}
	}
}
