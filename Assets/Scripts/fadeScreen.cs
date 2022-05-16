using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fadeScreen : MonoBehaviour
{
    public bool FadeOnStart = true;
    public float fadeDuration;
    public Color fadeColor;
    private Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        if (FadeOnStart)
            FadeIn();
    }

    private void Update()
    {
                Countdown();
    }

    public void Fade(float alphaIn, float alphaOut)
    {
        //StartCoroutine(FadeRoutine(alphaIn,alphaOut));
        StartCoroutine(FadeRoutine(alphaIn, alphaOut));
    }

    public void FadeIn()
    {
        Fade(1, 0);
    }
    public void FadeOut()
    {
        Fade(0, 1); 
    }

    public IEnumerator FadeRoutine(float alphaIn, float alphaOut)
    {
        float timer = 0;
        if (timer <= fadeDuration)
        {
            Color newColor = fadeColor;
            newColor.a = Mathf.Lerp(alphaIn, alphaOut, timer / fadeDuration);

            rend.material.SetColor("_Color", newColor);

            timer += Time.deltaTime;
            yield return null;


        }

        /* Color newColor2 = fadeColor;
         newColor2.a = alphaOut;

         rend.material.SetColor("_Color", newColor2);

         if (fadeDuration == 0)
         {
             print("Fadedur = 0");
             Destroy(gameObject);
         }*/

    }
    public float timevalue = 10;
    void Countdown(float alphaIn, float alphaOut)
    {
        if (timevalue > 0)
        {
            Color newColor = fadeColor;
            timevalue -= Time.deltaTime;
            newColor.a = Mathf.Lerp(alphaIn, alphaOut, timevalue / fadeDuration);
        }
        else
        {
            timevalue = 0;
            Destroy(gameObject);

        }

    }


}
