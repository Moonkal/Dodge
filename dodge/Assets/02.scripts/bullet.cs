using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class bullet : MonoBehaviour
{
    // Start is called before the first frame update

    private Rigidbody bull;
    /*ź��*/
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
/* Ʈ���� �浹�� �ڵ����� ����Ǵ� �޼ҵ�*/
    private void OnTriggerEnter(Collider other)
    {
        /*����� ���� ������Ʈ�� play�±׸� ��������?*/
        if (other.tag=="Player") {
            //����(�浹��) ���� ��������Ʈ���� player.���� ������Ʈ ��������
            Player_move player_Move = other.GetComponent<Player_move>();
            //.�������κ��� player move ������Ʈ�� �������µ� �����ߴٸ� 
            if (player_Move != null)
            {
                player_Move.die();
            }
            else { 
                
            }
        }
    }
}
