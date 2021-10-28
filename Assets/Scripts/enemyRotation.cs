using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyRotation : MonoBehaviour
{
    public Transform objToFollow = null;
    public bool followPlayer = false;

    public GameObject bullet;
    float timer;
    public Transform[] shotpoints;
    private void Awake()
    {
        if (!followPlayer)
        {
            return;
        }

        GameObject playerObj = GameObject.FindGameObjectWithTag("Player");
        if (playerObj != null)
        {
            objToFollow = playerObj.transform;
        }
    }
    private void Update()
    {
        timer += Time.deltaTime;
        if (timer > 2f)
        {
            timer = 0f;
            FindObjectOfType<AudioManager>().Play("Fire");
            Instantiate(bullet, shotpoints[0].transform.position, shotpoints[0].transform.rotation);
            Instantiate(bullet, shotpoints[1].transform.position, shotpoints[0].transform.rotation);
            Instantiate(bullet, shotpoints[2].transform.position, shotpoints[0].transform.rotation);
            Instantiate(bullet, shotpoints[3].transform.position, shotpoints[0].transform.rotation);
            Instantiate(bullet, shotpoints[4].transform.position, shotpoints[0].transform.rotation);
            Instantiate(bullet, shotpoints[5].transform.position, shotpoints[0].transform.rotation);
        }
        if (objToFollow == null)
        {
            return;
        }

        //Get directionto follow
        Vector3 dirToObject = objToFollow.position - transform.position;
        if (dirToObject != Vector3.zero)
        {

            transform.localRotation = Quaternion.LookRotation(-dirToObject.normalized, Vector3.back);
            //transform.localRotation = Quaternion.RotateTowards(objToFollow.rotation, transform.rotation, 180f);
        }
        //transform.position = new Vector3(transform.position.x, transform.position.y + 0.003f, transform.position.z);
    }

}
