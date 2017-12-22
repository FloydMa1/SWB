using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartButtonFadeIn : MonoBehaviour {

    void Start()
    {
        StartCoroutine(DoFade());
    }

    IEnumerator DoFade()
    {
        CanvasGroup cg = GetComponent<CanvasGroup>();
        while (cg.alpha < 1)
        {
            cg.alpha += Time.deltaTime / 2;
            yield return null;
        }
        cg.interactable = true;
        yield return null;
    }
}
