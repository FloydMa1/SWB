using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KillfeedItem : MonoBehaviour {

    [SerializeField]
    Text text;

    public int randomName;
    public int randomColor;

    public string teamColor;
    public string color;

    public string names;

    public string nameKiller;
    public string killerColor;

    public string nameKilled;
    public string killedColor;

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        
	}

    public void ShowKillFeed()
    {
        Setup();
    }

    public void RandomName()
    {
        RandomColor();

        randomName = Random.Range(1, 7);

        switch (randomName)
        {
            case 1:
                names = "Joey";
                break;
            case 2:
                names = "Koen";
                break;
            case 3:
                names = "Sebas";
                break;
            case 4:
                names = "Tim";
                break;
            case 5:
                names = "Floyd";
                break;
            case 6:
                names = "Myrte";
                break;
        }
    }

    public void RandomColor()
    {
        randomColor = Random.Range(1, 4);

        switch (randomColor)
        {
            case 1:
                color = "blue";
                break;
            case 2:
                color = "red";
                break;
            case 3:
                color = "yellow";
                break;
        }
    }

    public void Setup()
    {
        RandomName();
        nameKiller = names;
        RandomColor();
        killerColor = color;

        RandomName();
        nameKilled = names;
        RandomColor();
        killedColor = color;

        if (nameKilled == nameKiller && killedColor != killerColor)
        {
            Setup();
        }
        else
        {
            text.text = "<color=" + killerColor + ">" + nameKiller + "</color>" + " Killed " + "<color=" + killedColor + ">" + nameKilled + "</color>";
        }
    }
}
