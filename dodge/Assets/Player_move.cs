using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_move : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody playerRigidbody;
    public float speed = 5f;
    public GameObject my;


    private void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    /* 이동의 사용할 컴포넌트*/

    // Update is called once per frame
    void Update()
    {

        float xInput= Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        Vector3 newVelocity =new  Vector3(xSpeed, 0, zSpeed);

        playerRigidbody.velocity = newVelocity;

    }


    void directinput() {
        if (Input.GetKey(KeyCode.UpArrow) == true)
        {
            playerRigidbody.AddForce(0f, 0f, speed);

        }
        if (Input.GetKey(KeyCode.LeftArrow) == true)
        {
            playerRigidbody.AddForce(-speed, 0f, 0f);

        }
        if (Input.GetKey(KeyCode.RightArrow) == true)
        {
            playerRigidbody.AddForce(speed, 0f, 0f);

        }
        if (Input.GetKey(KeyCode.DownArrow) == true)
        {
            playerRigidbody.AddForce(0f, 0f, -speed);

        }

    }

    public void die() {
        my.SetActive(false);
        gameObject.SetActive(false);
 
    }
    
}
