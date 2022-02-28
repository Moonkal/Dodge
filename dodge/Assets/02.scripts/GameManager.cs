using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//UI ���� ���̺귯��
using UnityEngine.UI;

//�� ���� ���̺귯��
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    //���� ������ Ȱ��ȭ �� �ؽ�Ʈ ���� ������Ʈ�� ����

    public GameObject gmaeOverText;
        //�����ð��� ǥ���� �ؽ�Ʈ ������Ʈ
    public Text timeText;
    //�ְ� ����� ǥ���� �ؽ�Ʈ ������Ʈ
    public Text recordText;
    //���� ���� �ð� 
    private float survivleTime;
    //���� ���� ����
    private bool GameOver;

    void Start()

    {
        //�����ð��� ���� ���� ��� �ʱ�ȭ
        survivleTime = 0f;
        GameOver = false;

    }

    // Update is called once per frame
    void Update()
    {
        // ���� �������°� �ƴ� ���� 
        if (!GameOver) {
            // �����ð� ����
            survivleTime += Time.deltaTime;
            //������ ���� �ð��� timetext ������Ʈ�� �̿��� ǥ��;
            timeText.text ="TIme :"+(int)survivleTime;

        }
    }
    //���� ������ ���ӿ��� ���·� �����ϴ� �޼ҵ�
    public void EndGame() {
        //���� ���¸� ���ӿ��� ���·� ��ȯ
        GameOver = true;
    }
}
