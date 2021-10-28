using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletLeft : MonoBehaviour
{
    public GameObject particle;
    void Start()
    {
        Destroy(gameObject, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = new Vector3(transform.position.x, transform.position.y + 0.1f, transform.position.z);
    }
    private void FixedUpdate()
    {
        transform.Translate(Vector3.back * 10f * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            GameObject partic;
            partic = Instantiate(particle, transform.position, Quaternion.identity);
            Destroy(partic, 0.5f);
        }
    }
}
