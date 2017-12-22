using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ButtonController : MonoBehaviour {

    [SerializeField] private GameObject startButton;
    [SerializeField] private GameObject restartButton;
    [SerializeField] private GameObject victoryMessage;
    [SerializeField] private GameObject defeatMessage;

    [SerializeField]

    [HideInInspector]
    public bool startGame;
    [HideInInspector]
    public bool playerDead;
    [HideInInspector]
    public bool endGame;

    public GameObject[] UI;

    // Use this for initialization
    void Start()
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();

        Time.timeScale = 0F;

        startGame = false;
        playerDead = false;
        endGame = false;

        SetActiveFalse();
        restartButton.SetActive(false);
    }

    // Update is called once per frame
    void Update () {
        if (GameObject.Find("SpaceShitParent"))
        {
            if (GameObject.Find("SpaceShitParent").GetComponent<OnDead>().isDead)
            {
                playerDead = true;
                StartCoroutine(WaitForRestartButton());
            }
        }
        if (GameObject.Find("Player"))
        {
            if (GameObject.Find("Player").GetComponent<CheckpointController>().objCheck1 && GameObject.Find("Player").GetComponent<CheckpointController>().objCheck2)
            {
                endGame = true;
                StartCoroutine(EndGame());
            }
        }   
    }

    public void StartGame()
    {
        Time.timeScale = 1f;
        startGame = true;
        SetActiveTrue();
        startButton.SetActive(false);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    IEnumerator WaitForRestartButton()
    {
        yield return new WaitForSeconds(1);
        restartButton.SetActive(true);
        defeatMessage.SetActive(true);
    }

    IEnumerator EndGame()
    {
        yield return new WaitForSeconds(1);
        restartButton.SetActive(true);

        if (Time.timeScale >= 0.1)
        {
            Time.timeScale -= 0.4f * Time.fixedDeltaTime;
        }

        SetActiveFalse();
        victoryMessage.SetActive(true);

        yield return new WaitForSeconds(2);

        Time.timeScale = 0;
    }

    void SetActiveFalse()
    {
        foreach (GameObject ui in UI)
        {
            ui.SetActive(false);
        }
    }

    void SetActiveTrue()
    {
        foreach (GameObject ui in UI)
        {
            ui.SetActive(true);
        }
    }
}
