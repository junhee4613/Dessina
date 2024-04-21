using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dessina_bullet_spawner : MonoBehaviour
{
    public GameObject bullet_prefab;    //생성할 탄알의 원본 프리팹
    public float spawn_rate_min = 0.5f; // 최소 생성 주기
    public float spawn_rate_max = 3f;   //최대 생성 주기

    Transform target;   //발사할 대상
    public float spawn_rate;   //생성 주기
    float time_after_spawn; //최근 생성 시점에서 지난 시간

    // Start is called before the first frame update
    void Start()
    {
        //최근 생성 이후의 누적 시간을 0으로 초기화
        time_after_spawn = 0;
        //탄알 생성 간격을 spawn_rate_min과 spawn_rate_max 사이에서 랜덤 지정
        spawn_rate = Random.Range(spawn_rate_min, spawn_rate_max);
        //Player_controller 컴포넌트를 가진 게임 오브젝트를 찾아 조준 대상으로 설정
        target = FindObjectOfType<Dessina_player>().transform;       //씬에 존재하는 모든 오브젝트들을 검사하여 지정한 타입과 일치한 오브젝트를 가져오는 거기때문에 여러번 실행시킬 경우 프로그램이 심각하게 느려질수있습니다.
        //FindObjectsOfType 메서드는 지정한 타입의 오브젝트가 여러명이고 그 오브젝트들을 가져올 때 사용한다. 
    }

    // Update is called once per frame
    void Update()
    {
        //time_after_spawn 갱신
        time_after_spawn += Time.deltaTime; // time_after_spawn = time_after_spawn + Time.deltaTime;

        //최근 생성 시점에서부터 누적된 시간이 생성 주기보다 크거나 같다면
        if (time_after_spawn > spawn_rate)
        {
            //누적된 시간을 리셋
            time_after_spawn = 0;

            //bullet_prefab의 복제본을
            //transform.position 위칠와 transform.rotation 회전으로 생성
            GameObject bullet
                = Instantiate(bullet_prefab, transform.position, transform.rotation);
            //생성된 bullet 게임 오브젝트의 정면 방향이 target을 향하도록 회전

            //다음번 생성 간격을 spawn_rate_min, spawn_rate_max 사이에서 랜덤 지정
            spawn_rate = Random.Range(spawn_rate_min, spawn_rate_max);
        }
    }
}
