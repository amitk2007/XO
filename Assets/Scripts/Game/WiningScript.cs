using UnityEngine;
using System.Collections;
using System;

public class WiningScript : MonoBehaviour
{


    public static char[,] arr = new char[3, 3];
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public static void EnterSimbol(int[] ints, char simbol)
    {
        arr[ints[0], ints[1]] = simbol;

        if (CheckIfWining(simbol))
        {
            Win(simbol.ToString());
        }
        else if (GameManager.TurnCount==8)
        {
            Win("No one");
        }
        print(GameManager.TurnCount.ToString());
    }

    private static void Win(string simbol)
    {
        //gui win
        CleanArry();
        print(simbol + " won the game");
        EndGame.WinGame(simbol);
    }

    private static bool CheckIfWining(char simbol)
    {
        if (arr[1, 1] == simbol)
        {
            #region midlle
            if (arr[2, 2] == simbol)
            {
                if (arr[0, 0] == simbol)
                {
                    return true;
                }
            }
            else if (arr[0, 2] == simbol)
            {
                if (arr[2, 0] == simbol)
                {
                    return true;
                }
            }
            else if (arr[1, 0] == simbol)
            {
                if (arr[1, 2] == simbol)
                {
                    return true;
                }
            }
            else if (arr[0, 1] == simbol)
            {
                if (arr[2, 1] == simbol)
                {
                    return true;
                }
            }
            #endregion  
        }
        else if (arr[0, 0] == simbol)
        {
            if (arr[0, 1] == simbol)
            {
                if (arr[0, 2] == simbol)
                {
                    return true;
                }
            }
            else if (arr[1, 0] == simbol)
            {
                if (arr[2, 0] == simbol)
                {
                    return true;
                }
            }
        }
        else if (arr[2, 2] == simbol)
        {
            if (arr[1, 2] == simbol)
            {
                if (arr[0, 2] == simbol)
                {
                    return true;
                }
            }
            else if (arr[2, 1] == simbol)
            {
                if (arr[2, 0] == simbol)
                {
                    return true;
                }
            }
        }
        return false;
    }

    static void CleanArry()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                arr[i, j] = ' ';
            }
        }
    }
}

