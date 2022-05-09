using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndDialogue : MonoBehaviour
{

    public MeshRenderer ren;
    public BoxCollider LastD;
    public BoxCollider EndD;
    public GameObject black;

    public Dialogue dialogue;

    bool startTheEnd = false;

    // Start is called before the first frame update
    void Start()
    {
        ren.enabled = false;
        EndD.enabled = false;
        LastD.enabled = true;
        startTheEnd = false;
        black.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (LastD == false)
        {
            EndD.enabled = true;
            ren.enabled = true;
            startTheEnd = true;
            //black.SetActive(true);
            //Debug.Log("trigger end dialogue");
        }
        if (startTheEnd == true)
        {
            
        }

    }
}
