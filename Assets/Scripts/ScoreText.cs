using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    public int score;
    public Text text;


    void Start()
    {
        score = 0;
        text = gameObject.GetComponent<Text>();
    }

    void Update()
    {

        text.text = score + "";
    }
}
