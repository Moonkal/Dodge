using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_move : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody player;
    public float speed = 5f;
    public GameObject my;
    private void Start()
    {
       

    }

    /* 이동의 사용할 컴포넌트*/

    // Update is called once per frame
    void Update()
    {

        float xInput= Input.GetAxis("holizontal");
        float zInput = Input.GetAxis("vertical");

    }


    void directinput() {
        if (Input.GetKey(KeyCode.UpArrow) == true)
        {
            player.AddForce(0f, 0f, speed);

        }
        if (Input.GetKey(KeyCode.LeftArrow) == true)
        {
            player.AddForce(-speed, 0f, 0f);

        }
        if (Input.GetKey(KeyCode.RightArrow) == true)
        {
            player.AddForce(speed, 0f, 0f);

        }
        if (Input.GetKey(KeyCode.DownArrow) == true)
        {
            player.AddForce(0f, 0f, -speed);

        }

    }

    void die() {
        my.SetActive(false);
        gameObject.SetActive(false);
 
    }
    
}
