using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullets : MonoBehaviour
{

    public GameObject bullet;
    /*�ּ� ���� �ֱ�*/
    public float spanlate = 0.5f;
    public float sapnlatemax = 3.0f;
    //���� ���� �ֱ�
    private float spanrate;
    private float timeAfterspan;

    /*�߻��� ���*/
    private Transform target;
    


    // Start is called before the first frame update
    void Start()
    {
        //�ֱ� ������ ���� �ð��� 0���� �ʱ�ȭ
        timeAfterspan = 0;
        //ź�� ���� ����
        sapnlatemax = Random.Range(spanlate, sapnlatemax);
        /*������Ʈ�� ���� ���� ������Ʈ�� ã�Ƽ� �� ������Ʈ�� ��ġ���� ������*/
        target = FindObjectOfType<Player_move>().transform;

        
    }

    // Update is called once per frame
    void Update()
    {
        
        Instantiate(bullet);


    }


}
