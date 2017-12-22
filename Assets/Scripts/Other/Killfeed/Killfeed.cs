using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killfeed : MonoBehaviour {

    //[HideInInspector]
    public bool start = false;
    [SerializeField]
    GameObject killFeedItemPrefab;
    [SerializeField]
    int randomTime;

    private bool startCour;

    public bool showMessage = true;

    private void Start()
    {
        startCour = false;
    }

    private void Update()
    {
        ShowKills();
        if (startCour == false)
        {
            StartCoroutine(WaitForStart());
            startCour = true;
        }
    }

    public void ShowKills()
    {
        if (showMessage == true && start == true)
        {
            GameObject go = (GameObject)Instantiate(killFeedItemPrefab, this.transform);
            go.GetComponent<KillfeedItem>().ShowKillFeed();
            StartCoroutine(KillMessageWait());
            showMessage = false;
            Destroy(go, 4f);
        }
    }


    IEnumerator WaitForStart()
    {
        yield return new WaitForSeconds(2);
        start = true;
    }

    IEnumerator KillMessageWait()
    {
        randomTime = Random.Range(1, 3);
        yield return new WaitForSeconds(randomTime);
        showMessage = true;
    }
}
