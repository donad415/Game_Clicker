using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBehavior : MonoBehaviour
{

    public float _speed;
    private float _timer;
    private Rigidbody rb;
    private int _countDestroy;
    

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        _countDestroy = 0;
    }
    void OnMouseDown()
    {
        Destroy(gameObject);
    }

    void OnTriggerEnter(BoxCollider other)
    {
        rb.AddForce(transform.forward*0.1f);
    }

    void Update()
    {

        _timer += Time.deltaTime;
        
        transform.localScale *=  (1+Time.deltaTime/_speed);
        if (_timer > _speed)
        {
            Destroy(gameObject);
            _countDestroy++;
        }

        if (_countDestroy >= 10 && _speed > 1)
        {
            _speed -= 0.5f;
        }


    }

}
