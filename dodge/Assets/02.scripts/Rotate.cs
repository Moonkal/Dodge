using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float rotate_speed = 60f;


    // Update is called once per frame
    void Update()
    {   //roatate �޼���� �Է°� �Ű������� x,y,z�࿡ ���� ȸ������ �ް� ���� ȸ�����¿��� �Էµ� �͸�ŭ ��������� ȸ���մϴ�
        transform.Rotate(0f, Time.deltaTime, 0f);
            /* ����̴�*/


    }
}
