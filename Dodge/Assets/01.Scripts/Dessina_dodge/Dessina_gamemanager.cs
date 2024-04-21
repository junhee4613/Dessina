using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Dessina_gamemanager : MonoBehaviour
{
    public static Dessina_gamemanager instance;
    public GameObject gameover_text;    //게임 오버 시 활성화할 텍스트 게임 오브젝트
    public Text check_point_count_text;              //생존 시간을 표시할 텍스트 컴포넌트
    public Text record_text;            //최고 기록을 표시할 텍스트 컴포넌트
    public GameObject[] check_point_objs;

    public int check_point_count;         //체크 포인트에 도달한 횟수
    bool is_gameover;                   //게임오버 상태
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        // 생존 시간과 게임오버 상태 초기화
        check_point_count = 0;
        is_gameover = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!is_gameover)
        {
            //체크 포인트에 도달한 횟수를 time_text 텍스트 컴포넌트를 이용해 표시
            check_point_count_text.text = "Score : " + check_point_count;
        }
        else
        {
            //게임 오버인 상태에서 R 키를 누른 경우
            if (Input.GetKeyDown(KeyCode.R))
            {
                // Dodge 씬 로드
                SceneManager.LoadScene("Dessina_dodge");
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
        int best_count = PlayerPrefs.GetInt("Best_count");

        //이전까지의 최고 기록보다 현재 생존 시간이 더 크다면
        if (check_point_count > best_count)
        {
            //최고 기록 값을 현재 생존 시간 값으로 변경
            best_count = check_point_count;
            //변경된 최고 기록을 Best_time 키로 저장
            PlayerPrefs.SetInt("Best_count", best_count);
        }
        //최고 기록을 record_text 텍스트 컴포넌트를 이용해 표시
        record_text.text = "Best Time : " + best_count;
    }
}
