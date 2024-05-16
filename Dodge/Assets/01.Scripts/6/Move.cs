using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Transform childTransform;        //움직일 자식 게임 오브젝트의 트랜스폼

    // Start is called before the first frame update
    void Start()
    {
        //자신의 전역 위치를 (0, -1, 0)으로 변경
        transform.position = new Vector3(0, -1, 0);
        //자식의 지역 위치를 (0, 2, 0)으로 변경
        childTransform.localPosition = new Vector3(0, 2, 0);

        //자신의 전역 회전을 (0, 0, 30)으로 변경
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, 30));
        //자식의 지역 회전을 (0, 60, 0)으로 변경
        childTransform.localRotation = Quaternion.Euler(new Vector3(0, 60, 0));
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            //위쪽 방향키를 누르면 초당 (0, 1, 0)의 속도로 평행이동
            transform.Translate(new Vector3(0, 1, 0) * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            //아래쪽 방향키를 누르면 초당 (0, -1, 0)의 속도로 평행이동
            transform.Translate(new Vector3(0, -1, 0) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //왼쪽 방향키를 누르면
            //자신을 초당(0, 0, 180) 회전
            transform.Rotate(new Vector3(0, 0, 180) * Time.deltaTime);
            //자식을 초당(0, 180, 0) 회전
            childTransform.Rotate(new Vector3(0, 180, 0) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //오른쪽 방향키를 누르면
            //자신을 초당(0, 0, -180) 회전
            transform.Rotate(new Vector3(0, 0, -180) * Time.deltaTime);
            //자식을 초당(0, -180, 0) 회전
            childTransform.Rotate(new Vector3(0, -180, 0) * Time.deltaTime);
        }


        /*
         * Vector의 속기
         * Vector3.one = Vector3(1, 1, 1)
            Vector3.right = Vector3(1, 0, 0)
            Vector3.left = Vector3(-1, 0, 0)
            Vector3.back = Vector3(0, 0, -1)
            Vector3.forward = Vector3(0, 0, 1)
            Vector3.down = Vector3(0, -1, 0)
            Vector3.up = Vector3(0, 1, 0)
         */
        if (Input.GetKeyDown(KeyCode.Q))
        {       //Transform의 속기
            Debug.Log("게임 오브젝트의 앞 방향 = " + transform.forward);
            Debug.Log("게임 오브젝트의 왼쪽 방향 = " + transform.right);
            Debug.Log("게임 오브젝트의 위쪽 방향 = " + transform.up);
        }
    }
}
