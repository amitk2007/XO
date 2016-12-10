using UnityEngine;
using System.Collections;

public class CubeScript : MonoBehaviour {

    bool clickable = true;
    public int[] cubeInts;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

    }

    void OnMouseDown()
    {
        if (clickable==true)
        {
            WiningScript.EnterSimbol(cubeInts, GameManager.PlayersTurn);
            if (GameManager.PlayersTurn=='X')
            {
                gameObject.GetComponent<Animation>().Play("RotateRight");
                GameManager.PlayersTurn = 'O';
                TextScript.ChangeTurnText("O");
                GameManager.TurnCount++;
            }
            else if (GameManager.PlayersTurn=='O')
            {
                this.GetComponent<Animation>().Play("RotateLeft");
                GameManager.PlayersTurn = 'X';
                TextScript.ChangeTurnText("X");
                GameManager.TurnCount++;
            }
            clickable = false;
        }
    }
}
