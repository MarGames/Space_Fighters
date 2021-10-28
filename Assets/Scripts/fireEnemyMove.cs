using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireEnemyMove : MonoBehaviour
{
    float timer;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        //transform.position = new Vector3(transform.position.x, transform.position.y + 0.005f, transform.position.z);
    }
    private void FixedUpdate()
    {
        if (timer > 2f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + 0.05f, transform.position.z);
        }
    }
}
