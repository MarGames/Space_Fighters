using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class secondEnemyRotation : MonoBehaviour
{

    public GameObject bullet;
    float timer;
    public Transform[] shotpoints;
    private void Awake()
    {
    }
    private void Update()
    {
        timer += Time.deltaTime;
        if (timer > 2f)
        {
            timer = 0f;
            Instantiate(bullet, shotpoints[0].transform.position, shotpoints[0].rotation);
            Instantiate(bullet, shotpoints[1].transform.position, shotpoints[0].rotation);
            Instantiate(bullet, shotpoints[2].transform.position, shotpoints[0].rotation);
            Instantiate(bullet, shotpoints[3].transform.position, shotpoints[0].rotation);
            Instantiate(bullet, shotpoints[4].transform.position, shotpoints[0].rotation);
            Instantiate(bullet, shotpoints[5].transform.position, shotpoints[0].rotation);
        }
        
        //transform.position = new Vector3(transform.position.x, transform.position.y + 0.003f, transform.position.z);
    }
}
