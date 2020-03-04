using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBehavior : MonoBehaviour
{

    
    private float _timer;
    private Rigidbody rb;

    private Spawner sp;
   



    void Start()
    {
        rb = GetComponent<Rigidbody>();
        sp = GameObject.Find("Spawner").GetComponent<Spawner>();
        

    }
    void OnMouseDown()
    {
        Destroy(gameObject);
        sp.countDestroy++;
    }

    void OnTriggerEnter(BoxCollider other)
    {
        rb.AddForce(transform.forward*0.1f);
    }

    void Update()
    {

        _timer += Time.deltaTime;
       
        transform.localScale *=  (1+Time.deltaTime/sp.speed);

        if (_timer > sp.speed)
        {
            Destroy(gameObject);
            
        }

        if (sp.countDestroy >= 10 &&
            sp.speed> 1)
        {
            sp.speed -= 0.5f;
            sp.countDestroy = 0;
            
        }

    }

}
