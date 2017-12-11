using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PULoadingBar : MonoBehaviour {

    public Image FullImage;
    public Image OffImage;
    public float m_leftTime = 100;
	
	// Update is called once per frame
	void Update () {
        m_leftTime -= Time.deltaTime*5;

        if (m_leftTime < 0)
        {
            //delete Full and Off
            FullImage.enabled = false;
            OffImage.enabled = false;
        }
        FullImage.fillAmount = m_leftTime/100;
    }
}
