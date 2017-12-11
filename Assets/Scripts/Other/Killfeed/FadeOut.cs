using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeOut : MonoBehaviour {

	void Start()
    {
        StartCoroutine(DoFade());
    }

    IEnumerator DoFade()
    {
        yield return new WaitForSeconds(2);
        CanvasGroup cg = GetComponent<CanvasGroup>();
        while (cg.alpha > 0)
        {
            cg.alpha -= Time.deltaTime / 2;
            yield return null;
        }
        cg.interactable = false;
        yield return null;
    }
}
