using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour
{
    public Transform objToFollow = null;
    public bool followPlayer = false;

    private void Awake()
    {
        
    }
    private void Update()
    {
        
        transform.position = Vector3.MoveTowards(new Vector3(transform.position.x, transform.position.y, 8f), objToFollow.transform.position, 1f * Time.deltaTime);
    }
    void Start()
    {
        //rotation = Vector3.Angle(transform.position, player.position);
    }

    // Update is called once per frame
    /*void Update()
    {
        rotation = Vector3.Angle(transform.position, player.position);
        print(rotation);
        //rotation = player.rotation.y - transform.rotation.y;
        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, 5f * Time.deltaTime);
        transform.rotation = new Quaternion(-90f,rotation, 90f, 0f);
    }*/
}
