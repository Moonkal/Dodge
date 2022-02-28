using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//UI 관련 라이브러리
using UnityEngine.UI;

//씬 관리 라이브러리
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    //게임 오버시 활성화 할 텍스트 게임 오브젝트를 담음

    public GameObject gmaeOverText;
        //생존시간을 표시할 텍스트 컴포넌트
    public Text timeText;
    //최고 기록을 표시할 텍스트 컴포넌트
    public Text recordText;
    //실제 생존 시간 
    private float survivleTime;
    //게임 오버 상태
    private bool GameOver;

    void Start()

    {
        //생존시간과 게임 오버 상대 초기화
        survivleTime = 0f;
        GameOver = false;

    }

    // Update is called once per frame
    void Update()
    {
        // 게임 오버상태가 아닌 동안 
        if (!GameOver) {
            // 생존시간 갱신
            survivleTime += Time.deltaTime;
            //갱신한 생존 시간을 timetext 컴포넌트를 이용해 표시;
            timeText.text ="TIme :"+(int)survivleTime;

        }
    }
    //현재 게임을 게임오버 상태로 변경하는 메소드
    public void EndGame() {
        //현재 상태를 게임오버 상태로 전환
        GameOver = true;
    }
}
