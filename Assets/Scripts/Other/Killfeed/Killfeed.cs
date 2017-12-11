using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killfeed : MonoBehaviour {

    [SerializeField]
    GameObject killFeedItemPrefab;
    [SerializeField]
    int randomTime;

    public bool showMessage = true;

    private void Update()
    {
        ShowKills();
    }

    public void ShowKills()
    {
        if (showMessage == true)
        {
            GameObject go = (GameObject)Instantiate(killFeedItemPrefab, this.transform);
            go.GetComponent<KillfeedItem>().ShowKillFeed();
            StartCoroutine(KillMessageWait());
            showMessage = false;
            Destroy(go, 4f);
        }
    }

    IEnumerator KillMessageWait()
    {
        randomTime = Random.Range(1, 3);
        yield return new WaitForSeconds(randomTime);
        showMessage = true;
    }
}
