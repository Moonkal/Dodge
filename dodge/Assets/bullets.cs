using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullets : MonoBehaviour
{

    public GameObject bullet;
    /*최소 생성 주기*/
    public float spanlate = 0.5f;
    public float sapnlatemax = 3.0f;
    //실제 생성 주기
    private float spanrate;
    private float timeAfterspan;

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
        
        Instantiate(bullet);


    }


}
