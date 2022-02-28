using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class bullet : MonoBehaviour
{
    // Start is called before the first frame update

    private Rigidbody bull;
    /*탄알*/
    public float speed = 8f;


    void Start()
    {
        bull = GetComponent<Rigidbody>();
        bull.velocity = transform.forward * speed;

        Destroy(gameObject,3f);

    }

    // Update is called once per frame
    void Update()
    {
         
    }
/* 트리거 충돌시 자동으로 실행되는 메소드*/
    private void OnTriggerEnter(Collider other)
    {
        /*상대의 게임 오브젝트가 play태그를 가졌나요?*/
        if (other.tag=="Player") {
            //상대방(충돌한) 게임 오브젝ㅌ트에서 player.무브 컴포넌트 가져오기
            Player_move player_Move = other.GetComponent<Player_move>();
            //.상대방으로부터 player move 컴포넌트를 가져오는데 성공했다면 
            if (player_Move != null)
            {
                player_Move.die();
            }
            else { 
                
            }
        }
    }
}
