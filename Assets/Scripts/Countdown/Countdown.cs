using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour {

    public Transform LoadingBar;
    [SerializeField] private float currentAmount;
    [SerializeField] private float speed;

    public int Minutes = 0;
    public int Seconds = 0;
    private int initMinutes;
    private int initSeconds;

    public Text m_text;
    private float m_leftTime = 15f;

    // Update is called once per frame
    void Update () {
        if (m_leftTime > 0f)
        {
            //  Update countdown clock
            m_leftTime -= Time.deltaTime;
            Minutes = GetLeftMinutes();
            Seconds = GetLeftSeconds();

            //  Show current clock
            if (m_leftTime > 0f)
            {
                m_text.text = Minutes + ":" + Seconds.ToString("00");
            }
            else
            {
                //  The countdown clock has finished
                m_text.text = "0:00";
            }
        }

        LoadingBar.GetComponent<Image>().fillAmount = m_leftTime/(initMinutes*60f+initSeconds);
	}

    private void Awake()
    {
        //m_text = GetComponent<Text>();
        m_leftTime = GetInitialTime();
        initMinutes = Minutes;
        initSeconds = Seconds;
    }

    private float GetInitialTime()
    {
        return Minutes * 60f + Seconds;
    }

    private int GetLeftMinutes()
    {
        return Mathf.FloorToInt(m_leftTime / 60f);
    }

    private int GetLeftSeconds()
    {
        return Mathf.FloorToInt(m_leftTime % 60f);
    }
}
