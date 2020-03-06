
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    private float _del;
    public GameObject Cube;
    public GameObject Sphere;
    public float Speed;
    private int _countPoints;

    private void Awake()
    {
        SphereBehaviour.CountScore += UpScore;
        CubeBehavior.CountScoreCube += UpScore;
    }

    void Start()
    {
        _del = 0;
        Speed = 10;
    }

    void UpScore()
    {
        _countPoints++;
    }

    private void Update()
    {
        if (_countPoints == 10 && Speed>1)
        {
            Speed -= 0.5f;
            _countPoints = 0;
            Sphere.GetComponent<SphereBehaviour>().Speed = Speed;
            Cube.GetComponent<CubeBehavior>().Speed = Speed;
            Debug.Log(Speed);
        }

        _del += Time.deltaTime;
        if (_del > Speed/10)
        {
            int k = Random.Range(0, 100);
            if (k > 80)
            {
                Instantiate(Sphere, new Vector2(Random.Range(-12f, 12f),
                    Random.Range(-4.5f, 4.5f)), Quaternion.identity);
            }
            else
            {
                Instantiate(Cube, new Vector2(Random.Range(-12f, 12f),
                    Random.Range(-4.5f, 4.5f)), Quaternion.identity);
            }
            _del = 0;
        }
    }
}
