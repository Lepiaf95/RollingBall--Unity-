using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text score;
    public Text win;

    public void showScore()
    {
        score.text = "Score : " + FindObjectOfType<Score>().getScore();
    }

    public void gameWin()
    {
        win.text = "Game Win !!!";
        win.color = new Color(250, 0, 0, 1);
        Invoke("reStart", 1.0f);
    }

    private void reStart()
    {
        FindObjectOfType<MenuManager>().returnMenu();
    }
}
