using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Play()
    {
        SceneManager.LoadScene("MainGame");
    }
    public void exit()
    {
        Application.Quit();
    }
    public void menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
