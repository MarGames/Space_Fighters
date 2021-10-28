using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particleFire : MonoBehaviour
{
    public GameObject death;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (death.activeSelf)
        {
            Destroy(gameObject);
        }
    }
}
