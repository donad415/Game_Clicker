using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SphereBehaviour : MonoBehaviour
{
    private float _timer;
    public float Speed;

    public static event System.Action CountScore;

    void Start()
    {
        Speed = 10;
    }

    void OnMouseDown()
    {
        Destroy(gameObject);
        CountScore();
    }

    void Update()
    {
        _timer += Time.deltaTime;

        transform.localScale *= (1 + Time.deltaTime / (Speed * 0.3f));

        if (_timer >  Speed * 0.3)
        {
            Destroy(gameObject);
        }
    }
}
