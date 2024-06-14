using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    GameObject[] obstacles = new GameObject[3];      //장애물 오브젝트들
    bool stepped = false;               //플레이어 캐릭터가 밟았는가

    private void Awake()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            obstacles[i] = transform.GetChild(i).gameObject;
        }
    }

    //컴포넌트가 활성화될 때마다 매번 실행되는 메서드(플레이를 누를 때도 최초로 한번 실행됨)
    private void OnEnable()
    {
        //밟힘 상태를 리셋
        stepped = false;
        for (int i = 0; i < obstacles.Length; i++)
        {
            //현재 순번의 장애물을 1/3의 확률로 활성화
            if(Random.Range(0, 3) == 0)
            {
                obstacles[i].SetActive(true);
            }
            else
            {
                obstacles[i].SetActive(false); 
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //충돌한 상대방의 태그가 Player이고 이전에 플레이어 캐릭터가 밟지 않았다면
        if(collision.collider.tag == "Player" && !stepped)
        {
            //점수를 추가하고 밟힘 상태를 참으로 변경
            stepped=true;
            GameManager_uni_run.instance.AddScore(1);
        }
    }
}
