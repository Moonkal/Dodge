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
        if (!GameOver)
        {
            // 생존시간 갱신
            survivleTime += Time.deltaTime;
            //갱신한 생존 시간을 timetext 컴포넌트를 이용해 표시;
            timeText.text = "TIme :" + (int)survivleTime;

        }
        else {
            //게임 오버인 상태에서 r키를 누른다면 
            if (Input.GetKeyDown(KeyCode.R)) {
                //sample씬을 로드
                SceneManager.LoadScene("SampleScene");


            }
        }
    }
    //현재 게임을 게임오버 상태로 변경하는 메소드
    public void EndGame() {
        //현재 상태를 게임오버 상태로 전환
        GameOver = true;
        //게임 오버 텍스트 게임 오브젝트를 활성화
        gmaeOverText.SetActive(true);
        //timeText.enabled = true;
        //기록을 데이터로 저장하는 방법

        //PlayerPrefs(PlayerPrefs preference)
        //돈 1000원을 데이터에 저장하려면
        /*PlayerPrefs.SetInt("money", 1000);
        PlayerPrefs.SetString("nick", "Taehun");
        Debug.Log(PlayerPrefs.GetInt("money"));
        Debug.Log(PlayerPrefs.GetString("nick"));*/


        //best time 키로 저장된 이전까지의 최고기록을 가져옴
        float bestTime=PlayerPrefs.GetFloat("bestTime");

        //이전까지의 최고 기록과 현재 생존시간을 비교

        if (bestTime < survivleTime) {
            //최고 기록 값을 현재 생존 시간 비교
            bestTime = survivleTime;

            //변경된 최고 기록을 besttime 키로 저장;
            PlayerPrefs.SetFloat("bestTime", bestTime);

        }
        //최고 기록을 recordtesxt 컴포넌트에 표시

        recordText.text = "BestTime:" + (int)bestTime;
       

    }
    /*private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "filed"){ 
            SceneManager.LoadScene("filed")
        }
    }*/
}
