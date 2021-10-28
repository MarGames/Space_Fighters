using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroids : MonoBehaviour
{
    public int health, damage;
    public GameObject particle;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0) 
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullet") 
        {
            GameObject partic;
            partic = Instantiate(particle, transform.position, Quaternion.identity);
            Destroy(partic, 0.5f);
            //print("Entered");
            Destroy(other.gameObject);
            health = health - damage;
        }
    }
}
