using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Countdown : MonoBehaviour
{

    public float timevalude;
    public GameObject Desapiring_Object;
    // Start is called before the first frame update
    void Start()
    {
        Desapiring_Object.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        countdown();
    }


    public void countdown()
    {
        timevalude -= Time.deltaTime;
        if (timevalude < 0)
        {
            Desapiring_Object.SetActive(false);
        }
    }

}
