using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    private Vector3 _startScale;
    private float _timer;
    private float _speedBackgruund;

    void Start()
    {
        _speedBackgruund = 1.0001f;
        _startScale = transform.localScale;
    }

    void Update()
    {
        if (_timer < 15)
        {
            transform.localScale *= 1.0001f;
            _timer += Time.deltaTime;
        }
        else if (_timer >= 15)
        {
            if (transform.localScale.x / _speedBackgruund > _startScale.x)
            {
                transform.localScale /= _speedBackgruund;
                _timer += Time.deltaTime;
            }
            else
            {
                _timer = 0;
            }
        }
        else
        {
            _timer = 0;
        }
    }
}
