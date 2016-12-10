using UnityEngine;
using System.Collections;

public class TextScript : MonoBehaviour {

    public Camera cam;
    static GameObject turnText;
	// Use this for initialization
	void Start () {
        turnText = this.gameObject;
        this.transform.position = cam.ScreenToWorldPoint(new Vector3(/*Screen.width, Screen.height*/0,Screen.height, 15));
        ChangeTurnText("X");
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public static void ChangeTurnText(string str)
    {
        turnText.transform.GetComponent<TextMesh>().text = "Player: "+str;
    }
}
