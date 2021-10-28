using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int health = 100;
    public int damage = 2;
    public GameObject[] firePoints;
    public GameObject collapse;
    public GameObject death;
    public Text txt;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0f)
        {
            Destroy(gameObject);
        }
        if (health< 0)
        {
            health = 0;
        }
        txt.text = "" + health;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            GameObject partcile;
            partcile = Instantiate(collapse, transform.position, Quaternion.identity);
            Destroy(partcile, 5f);
            //death.SetActive(true);
            FindObjectOfType<AudioManager>().Play("Explosion");
            Destroy(other.gameObject);
            health = health - 25;
            //Time.timeScale = 0f;
        }
        if (other.tag == "life")
        {
            Destroy(other.gameObject);
            health = health + 25;
        }
        if (other.tag == "UnlockFire")
        {
            if (!firePoints[0].activeSelf)
            {
                firePoints[0].SetActive(true);
            }
            else
            {
                if (!firePoints[1].activeSelf)
                    firePoints[1].SetActive(true);
                else
                {
                    if (!firePoints[2].activeSelf)
                        firePoints[2].SetActive(true);
                    else 
                    {
                        if (!firePoints[3].activeSelf)
                            firePoints[3].SetActive(true);
                        else
                        {
                            if (!firePoints[4].activeSelf)
                                firePoints[4].SetActive(true);
                            else
                            {
                                if (!firePoints[5].activeSelf)
                                    firePoints[5].SetActive(true);
                            }
                        }
                    }
                }
            }
            Destroy(other.gameObject);
        }
        if (other.tag == "enemyBullet")
        {
            Destroy(other.gameObject);
            health = health - damage;
        }
    }
}
