using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullets : MonoBehaviour
{

    public GameObject bulletPrefebs;
    /*�ּ� ���� �ֱ�*/
    public float spanlate = 0.5f;
    public float sapnlatemax = 3.0f;
    //���� ���� �ֱ�
    private float spanrate;
    private float timeAfterspan = 0f;
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
        /*timeafterspan ����*/
        timeAfterspan += Time.deltaTime;
        /*�ֱ� ������ �������� ������ �ð��� �����ֱ⺸�� ũ�ų� ���ٸ�*/

        if (timeAfterspan >= spanrate) {
            /* bullet prefebs�� ���纻�� transform.position ��ġ�� transform.rotation ȸ������ ������*/
            GameObject bullet = Instantiate(bulletPrefebs, transform.position, transform.rotation);
            /*������ bullet ���� ������Ʈ�� ���� ������ target�� ���ϵ��� ȸ��*/
            bullet.transform.LookAt(target);

            /*������ ���� ������ spanratmin ���� 
                sanprateamx���̿��� ���� ����

             */

            spanrate = Random.Range(spanlate, sapnlatemax);

            /*�����Ǥ��� �ð� �ʱ�ȭ*/
            timeAfterspan = 0f;
        }



        

    }


}
