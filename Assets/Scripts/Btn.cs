using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Btn : MonoBehaviour
{
    public void OnBtnDown()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y - 5f, transform.position.z);
    }
    public void OnBtnUp()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + 5f, transform.position.z);
    }
}
