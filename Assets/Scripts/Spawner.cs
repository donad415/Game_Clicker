
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    private float del;
    public GameObject Cube;
    public GameObject Sphere;
    private float speed;
    private int _countPoints;

    private void Awake()
    {
        SphereBehaviour.CountScore += UpScore;
        CubeBehavior.CountScoreCube += UpScore;
    }

    void Start()
    {
        del = 0;
        speed = 10;
    }

    void UpScore()
    {
        _countPoints++;
    }

    private void Update()
    {
        if (_countPoints == 10 && speed>1)
        {
            speed -= 0.5f;
            _countPoints = 0;
            Sphere.GetComponent<SphereBehaviour>().speed = speed;
            Cube.GetComponent<CubeBehavior>().speed = speed;
            Debug.Log(speed);
        }

        del += Time.deltaTime;
        if (del > speed/10)
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
            del = 0;
        }
    }
}
