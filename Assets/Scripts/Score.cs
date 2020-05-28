
using System;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    public float finishPosition = 1500f;
    public float startPosition = -1450f;
    public float distance;
    public float total;
    public float travelled;
    public Transform finishLine;
    // Update is called once per frame

    void Update()
    {
        if (player.position.x <= startPosition)
        {
            scoreText.text = "0%";
        }
        else {
            distance = player.position.x - startPosition;
            if (finishLine.position.x < 0)
            {
                total = Mathf.Abs(startPosition) - Mathf.Abs(finishLine.position.x);
            }
            travelled = distance/total*100;
            scoreText.text = travelled.ToString("F1")+"%";
            //scoreText.text = player.position.x.ToString();
        }
    }
}
