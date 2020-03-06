
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBehavior : MonoBehaviour
{
    private float _timer;
    public float Speed;

    public static event System.Action CountScoreCube;

    void Start()
    {
        Speed = 10;
    }

    void OnMouseDown()
    {
        Destroy(gameObject);
        CountScoreCube();
    }

    void Update()
    {
        _timer += Time.deltaTime;

        transform.localScale *= (1 + Time.deltaTime / (Speed * 0.3f));

        if (_timer > Speed * 0.3)
        {
            Destroy(gameObject);
        }
    }
}
