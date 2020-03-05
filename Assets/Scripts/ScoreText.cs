using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreText : MonoBehaviour
{

    public Text text;
    public Spawner sp;
    public int _score;

    public GameObject Sphere;
    public GameObject Cube;

    private void Awake()
    {
        SphereBehaviour.CountScore += UpdateCounter;
        CubeBehavior.CountScoreCube += UpdateCounterCube;
    }

    void Start()
    {
        _score = 0;
        text = gameObject.GetComponent<Text>();
        text.text = _score + "";
    }

    private void UpdateCounter()
    {
        _score += 2;
        text.text = _score + "";
    }

    private void UpdateCounterCube()
    {
        text.text = ++_score + "";
    }


}
