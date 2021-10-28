using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject bulletPref;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void fireBtn()
    {
        FindObjectOfType<AudioManager>().Play("Fire");
        GameObject bullet;
        if (gameObject.activeSelf)
        {
            bullet = Instantiate(bulletPref, transform.position, bulletPref.transform.rotation);
        }
    }
}
