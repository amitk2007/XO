using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EndGame : MonoBehaviour {

    public static GameObject canvas;
    public GameObject Can;
	// Use this for initialization
	void Start () {
        canvas = Can;
        canvas.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    public static void WinGame(string winning)
    {
        canvas.SetActive(true);
        canvas.transform.GetChild(0).transform.GetChild(0).GetComponent<Text>().text = winning + " won the Game";
    }

    public void BackToMenu()
    {
        Application.LoadLevel("Menu");
    }
    public void TryAgain()
    {
        Application.LoadLevel("Game");
    }
}
