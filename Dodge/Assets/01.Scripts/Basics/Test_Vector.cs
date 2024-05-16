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
            Debug.Log("������ �ִ� a(1, 2, 3)�� ��Į�� �� 10�� �ؼ� ���� �� = " + a);
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("a���Ϳ� b���͸� ���� �� = " + (a + b));
            Debug.Log("a���Ϳ� b���͸� �� �� = " + (a - b));
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("������ ����ȭ, �� ������ ũ�⸦ 1�� ���� ������ ��Ÿ�� �� = " + c.normalized);
        }
        else if (Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log("������ ũ�� =" + c.magnitude);
        }
        else if (Input.GetKeyDown(KeyCode.G))
        {       //���� -1 ~ 1
            Debug.Log("������  ���� = " + Vector3.Dot(a.normalized, b.normalized));
        }
        else if (Input.GetKeyDown(KeyCode.H))
        {
            Debug.Log("������ ���� =  " + Vector3.Cross(a, b));
        }
        // ȸ���� ��Ÿ�� �� Quaternion�� ����Ѵ� new Quaternion(0, 0, 0, 1); 4������ �̷��� �� �����ֱ� ���� ����� ��
        // transform.rotation = Quaternion.Euler(new Vector3(0 ,0, 0)); <= ������Ʈ�� ȸ���� �ִ� ��� �� �ϳ�
    }
}
