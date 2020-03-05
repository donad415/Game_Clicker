
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBehavior : MonoBehaviour
{
    private float _timer;
    public float speed;

    public static event System.Action CountScoreCube;

    void Start()
    {
        speed = 10;
    }

    void OnMouseDown()
    {
        Destroy(gameObject);
        CountScoreCube();
    }

    void Update()
    {
        _timer += Time.deltaTime;

        transform.localScale *= (1 + Time.deltaTime / (speed * 0.3f));

        if (_timer > speed * 0.3)
        {
            Destroy(gameObject);
        }
    }
}
