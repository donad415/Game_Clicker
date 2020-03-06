using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelController : MonoBehaviour
{
    private Text _text;
    public Spawner Spawner;
    private float _speed;
    private int _level;

    void Start()
    {
        _speed = 10;
        _level = 1;
        _text = gameObject.GetComponent<Text>();
    }

    void Update()
    {
        if (_speed > Spawner.GetComponent<Spawner>().Speed)
        {
            _level++;
            _speed = Spawner.GetComponent<Spawner>().Speed;
        }

        _text.text = _level.ToString();
    }
}
