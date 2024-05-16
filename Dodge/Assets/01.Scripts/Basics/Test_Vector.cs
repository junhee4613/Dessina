using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Vector : MonoBehaviour
{
    public Vector3 a = new Vector3(1, 2, 3);
    public Vector3 b = new Vector3(2, 3, 4);
    public Vector2 c = new Vector2(4, 5);
    // Start is called before the first frame update
    void Start()
    {
        a.x = 10;
        a.y = 20;
        a.z = 30;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {      
            a = a * 10;
            Debug.Log("기존에 있던 a(1, 2, 3)을 스칼라 곱 10을 해서 나온 값 = " + a);
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("a벡터와 b벡터를 더한 값 = " + (a + b));
            Debug.Log("a벡터와 b벡터를 뺀 값 = " + (a - b));
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("벡터의 정규화, 즉 벡터의 크기를 1로 만들어서 방향을 나타낸 건 = " + c.normalized);
        }
        else if (Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log("벡터의 크기 =" + c.magnitude);
        }
        else if (Input.GetKeyDown(KeyCode.G))
        {       //값은 -1 ~ 1
            Debug.Log("벡터의  내적 = " + Vector3.Dot(a.normalized, b.normalized));
        }
        else if (Input.GetKeyDown(KeyCode.H))
        {
            Debug.Log("벡터의 외적 =  " + Vector3.Cross(a, b));
        }
        // 회전을 나타낼 땐 Quaternion을 사용한다 new Quaternion(0, 0, 0, 1); 4원수로 이뤄진 걸 보여주기 위해 써놓은 것
        // transform.rotation = Quaternion.Euler(new Vector3(0 ,0, 0)); <= 오브젝트에 회전을 주는 방식 중 하나
    }
}
