using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    private float del;
    [SerializeField]
    private GameObject Cube;
    private float speed; 

    void Start()
    {
       speed =  GetComponent<CubeBehavior>()._speed;
}
    private void Update()
    {
       
        del += Time.deltaTime;
        if (del > speed/10)
        {
            Instantiate(Cube, new Vector2(Random.Range(-12f, 12f), Random.Range(-4.5f, 4.5f)),
           Quaternion.identity);
            del = 0;
        }
    }
}
