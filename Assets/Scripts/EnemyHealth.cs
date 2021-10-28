using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int health = 10;
    public int damage = 5;
    public GameObject particle;
    public GameObject parent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0f)
        {
            FindObjectOfType<AudioManager>().Play("Explosion");
            Destroy(gameObject);
            Destroy(parent);
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
