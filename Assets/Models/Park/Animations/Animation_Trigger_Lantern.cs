using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Animation_Trigger_Lantern : MonoBehaviour
{

    public float randomWait;
    public bool playAnim = true;

    void Update()
    {
        if (playAnim)
            StartCoroutine(WaitAnim()); //wait random seconds for animation
    }

    public IEnumerator WaitAnim()
    {
        playAnim = false;
        int randomWait = Random.Range(0, 10);
        print("Time" + randomWait + " Play"); //debug                
        yield return new WaitForSeconds(randomWait);
        GetComponent<Animator>().Play("Sway_better"); ;  //Put your animation string
        GetComponent<Animator>().Play("DecoreSwaye"); ;  //Put your animation string
        playAnim = true;
    }
}