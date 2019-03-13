using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    private int score;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        FindObjectOfType<GameManager>().showScore();
    }

    public int getScore()
    {
        return score;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "PickUp")
        {
            score++;
            FindObjectOfType<GameManager>().showScore();
            other.gameObject.SetActive(false);
            if (score == 8)
            {
                FindObjectOfType<GameManager>().gameWin();
            }
        }
    }
}
