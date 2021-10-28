using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFire : MonoBehaviour
{
    public GameObject bullet;
    float timer;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 2f)
        {
            timer = 0f;
            Instantiate(bullet, transform.position, bullet.transform.rotation);
        }
    }
}
