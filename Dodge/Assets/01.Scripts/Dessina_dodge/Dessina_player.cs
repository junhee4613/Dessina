using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dessina_player : MonoBehaviour
{
    public Rigidbody player_rigidbody;          //이동에 사용할 리지드바디 컴포넌트
    public float speed = 8f;                    //이동속력
    

    private void Awake()
    {

    }
    // Start is called before the first frame update
    void Start()
    {
        //게임 오브젝트에서 Rigidbody 컴포넌트를 찾아 player_rigidbody에 할당
        player_rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //수평축과 수직축의 입력값을 감지하여 저장
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        //실제 이동 속도를 입력값과 이동 속력을 사용해 결정
        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        //Vector3 속도를 (xSpeed, 0, zSpeed)로 생성
        Vector3 newVelocity = new Vector3(xSpeed, 0, zSpeed);
        //리지드바디의 속도에 newVelocity 할당
        player_rigidbody.velocity = newVelocity;
    }
    public void Die()
    {
        //자신의 게임 오브젝트를 비활성화
        gameObject.SetActive(false);

        //씬에 존재하는 GameManager 타입의 오브젝트를 찾아서 가져오기
        Dessina_gamemanager gameManager = FindObjectOfType<Dessina_gamemanager>();
        // 가져온 GameManager 오브젝트의 EndGame() 메서드 실행
        gameManager.EndGame();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Check_point")
        {
            other.gameObject.SetActive(false);
            int num = Random.Range(0, 3);
            Dessina_gamemanager.instance.check_point_objs[num].SetActive(true);
            //싱글톤 패턴으로 인해 Dessina_gamemanager에 접근해서 check_point_count의 현재 점수 + 1만큼 증가
            Dessina_gamemanager.instance.check_point_count += 1;
        }
    }
}
