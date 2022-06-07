using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimerToMainScreen : MonoBehaviour
{

    private void Update()
    {
        Countdown();
    }
    public float timevalue = 10;
    void Countdown()
    {
        if (timevalue > 0)
        {
            timevalue -= Time.deltaTime;
        }
        else
        {
            timevalue = 0;
            Destroy(gameObject);

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);

        }

    }
}
