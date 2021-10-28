using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpaceMovement : MonoBehaviour
{
    /*
    private Vector3 position;
    private float width;
    private float height;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Update()
    {
        if (Input.touchCount > 0f)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Moved)
            {
                //if (touch.position.x > 0.1f)
                Vector2 pos = touch.position;
                pos.x = (pos.x - width) / width;
                position = new Vector3(pos.x * 14, gameObject.transform.position.y, gameObject.transform.position.z);

                transform.position = position;
            }

        }
    }
    private void Awake()
    {
        ScreenAndPosition();
    }
    void ScreenAndPosition()
    {
        width = (float)Screen.width / 2.0f;
        height = (float)Screen.height / 2.0f;


        position = gameObject.transform.position;
    }
  */
    Animator animator;
    public float horizontalSpeed = 0.2f;
    float verticalSpeed = 0.05f;
    public Transform[] buttons;
    float btnPos1, btnPos2;
    public GameObject death;
    public Button fire;
    private void Start()
    {
        animator = GetComponent<Animator>();
        btnPos1 = buttons[0].position.y;
        btnPos2 = buttons[1].position.y;
    }
    private void FixedUpdate()
    {
        if (!death.activeSelf)
        {
            if (btnPos1 != buttons[0].position.y)
            {
                if (transform.position.x < 12f)
                {
                    animator.SetBool("mid", false);
                    animator.Play("Right");
                    transform.position = new Vector3(transform.position.x + horizontalSpeed, transform.position.y, transform.position.z);
                }
            }
            
            if (btnPos2 != buttons[1].position.y)
            {
                if (transform.position.x > -12f)
                {
                    animator.SetBool("mid", false);
                    animator.Play("Left");
                    transform.position = new Vector3(transform.position.x - horizontalSpeed, transform.position.y, transform.position.z);

                }
            }
            if (btnPos1 == buttons[0].position.y && btnPos2 == buttons[1].position.y)
            {
                animator.SetBool("mid", true);
                //animator.Play("ShipAnim");
            }
            movingUp();
        }
        else 
        {
            fire.interactable = false;
        }
    }
    void movingUp()
    {
        if (!death.activeSelf)
            transform.position = new Vector3(transform.position.x, transform.position.y + verticalSpeed, transform.position.z); 
    }
}
