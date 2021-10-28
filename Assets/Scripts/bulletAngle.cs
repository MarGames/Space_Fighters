using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletAngle : MonoBehaviour
{
    void Start()
    {
        Destroy(gameObject, 0.7f);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = new Vector3(transform.position.x, transform.position.y + 0.1f, transform.position.z);
    }
    private void FixedUpdate()
    {
        transform.position = new Vector3(transform.position.x + 0.1f, transform.position.y + 0.5f, transform.position.z);
    }
}
