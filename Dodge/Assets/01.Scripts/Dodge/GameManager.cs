using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;       //UI 관련 라이브러리
using UnityEngine.SceneManagement;  //씬 관리 관련 라이브러리
using JetBrains.Annotations;

public class GameManager : MonoBehaviour
{
    public GameObject gameover_text;    //게임 오버 시 활성화할 텍스트 게임 오브젝트
    public Text time_text;              //생존 시간을 표시할 텍스트 컴포넌트
    public Text record_text;            //최고 기록을 표시할 텍스트 컴포넌트

    private float survive_time;         //생존 시간
    bool is_gameover;                   //게임오버 상태
    // Start is called before the first frame update
    void Start()
    {
        // 생존 시간과 게임오버 상태 초기화
        survive_time = 0;
        is_gameover = false;
    }

    // Update is called once per frame
    void Update()
    {
        //게임 오버가 아닌 동안
        if (!is_gameover)
        {
            //생존 시간 갱신
            survive_time += Time.deltaTime;
            //갱신한 생존 시간을 time_text 텍스트 컴포넌트를 이용해 표시
            time_text.text = "Time" + (int)survive_time;
        }
        else
        {
            //게임 오버인 상태에서 R 키를 누른 경우
            if (Input.GetKeyDown(KeyCode.R))
            {
                // Dodge 씬 로드
                SceneManager.LoadScene("Dodge_scene");
            }
        }
    }
    //현재 게임을 게임오버 상태로 변경하는 메서드
    public void EndGame()
    {
        //현재 상태를 게임오버 상태로 전환
        is_gameover = true;
        //게임오버 텍스트 게임 오브젝트를 활성화
        gameover_text.SetActive(true);

        //Best_time 키로 저장된 이전까지의 최고 기록 가져오기
        float best_time = PlayerPrefs.GetFloat("Best_time");

        //이전까지의 최고 기록보다 현재 생존 시간이 더 크다면
        if(survive_time > best_time) 
        {
            //최고 기록 값을 현재 생존 시간 값으로 변경
            best_time = survive_time;
            //변경된 최고 기록을 Best_time 키로 저장
            PlayerPrefs.SetFloat("Best_time", best_time);
        }
        //최고 기록을 record_text 텍스트 컴포넌트를 이용해 표시
        record_text.text = "Best Time : " + (int)best_time;
    }
}
