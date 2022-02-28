using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float rotate_speed = 60f;


    // Update is called once per frame
    void Update()
    {   //roatate 메서드는 입력값 매개변수로 x,y,z축에 대한 회전값을 받고 현재 회전상태에서 입력된 것만큼 상대적으로 회전합니다
        transform.Rotate(0f, Time.deltaTime, 0f);
            /* 기능이다*/


    }
}
