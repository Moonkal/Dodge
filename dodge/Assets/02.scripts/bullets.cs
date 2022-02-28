using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullets : MonoBehaviour
{

    public GameObject bulletPrefebs;
    /*최소 생성 주기*/
    public float spanlate = 0.5f;
    public float sapnlatemax = 3.0f;
    //실제 생성 주기
    private float spanrate;
    private float timeAfterspan = 0f;
    /*발사할 대상*/
    private Transform target;
    


    // Start is called before the first frame update
    void Start()
    {
        //최근 이후의 누적 시간을 0으로 초기화
        timeAfterspan = 0;
        //탄알 생성 간격
        sapnlatemax = Random.Range(spanlate, sapnlatemax);
        /*컴포넌트를 가진 게임 프로젝트를 찾아서 그 오브젝트의 위치값을 가져옴*/
        target = FindObjectOfType<Player_move>().transform;

        
    }

    // Update is called once per frame
    void Update()
    {
        /*timeafterspan 갱신*/
        timeAfterspan += Time.deltaTime;
        /*최그 ㄴ생성 시점에서 누적된 시간이 생성주기보다 크거나 같다면*/

        if (timeAfterspan >= spanrate) {
            /* bullet prefebs의 복사본을 transform.position 위치와 transform.rotation 회전으로 생성됨*/
            GameObject bullet = Instantiate(bulletPrefebs, transform.position, transform.rotation);
            /*생성된 bullet 게임 오브젝트의 정면 방향이 target을 향하도록 회전*/
            bullet.transform.LookAt(target);

            /*다음번 생성 간격을 spanratmin 구간 
                sanprateamx사이에서 랜덤 지정

             */

            spanrate = Random.Range(spanlate, sapnlatemax);

            /*누적되ㅐㄴ 시간 초기화*/
            timeAfterspan = 0f;
        }



        

    }


}
