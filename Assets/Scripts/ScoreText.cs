using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreText : MonoBehaviour
{

    public Text Text;
    public Spawner Spawner;
    public int Score;

    public GameObject Sphere;
    public GameObject Cube;

    private void Awake()
    {
        SphereBehaviour.CountScore += UpdateCounter;
        CubeBehavior.CountScoreCube += UpdateCounterCube;
    }

    void Start()
    {
        Score = 0;
        Text = gameObject.GetComponent<Text>();
        Text.text = Score.ToString();
    }

    private void UpdateCounter()
    {
        Score += 2;
        Text.text = Score.ToString();
    }

    private void UpdateCounterCube()
    {
        Score++;
        Text.text = Score.ToString();
    }


}
