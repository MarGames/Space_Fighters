using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject[] waves;
    int wave;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            wave++;
            if (wave == 1)
            {
                
                    waves[0].SetActive(true);
                
            }
            if (wave == 2)
            {
                
                    waves[1].SetActive(true);
                
            }
            if (wave == 3)
            {
                waves[2].SetActive(true);
            }
            if (wave == 4)
            {
                waves[3].SetActive(true);
            }
            if (wave == 5)
            {
                waves[4].SetActive(true);
            }
            if (wave == 6)
            {
                waves[5].SetActive(true);
            }
            if (wave == 7)
            {
                waves[6].SetActive(true);
            }
            if (wave == 8)
            {
                waves[7].SetActive(true);
            }
            if (wave == 9)
            {
                waves[8].SetActive(true);
            }
            if (wave == 10)
            {
                waves[9].SetActive(true);
            }
            if (wave == 11)
            {
                waves[10].SetActive(true);
            }
        }
        
    }
}
