using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Transform childTransform;        //������ �ڽ� ���� ������Ʈ�� Ʈ������

    // Start is called before the first frame update
    void Start()
    {
        //�ڽ��� ���� ��ġ�� (0, -1, 0)���� ����
        transform.position = new Vector3(0, -1, 0);
        //�ڽ��� ���� ��ġ�� (0, 2, 0)���� ����
        childTransform.localPosition = new Vector3(0, 2, 0);

        //�ڽ��� ���� ȸ���� (0, 0, 30)���� ����
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, 30));
        //�ڽ��� ���� ȸ���� (0, 60, 0)���� ����
        childTransform.localRotation = Quaternion.Euler(new Vector3(0, 60, 0));
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            //���� ����Ű�� ������ �ʴ� (0, 1, 0)�� �ӵ��� �����̵�
            transform.Translate(new Vector3(0, 1, 0) * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            //�Ʒ��� ����Ű�� ������ �ʴ� (0, -1, 0)�� �ӵ��� �����̵�
            transform.Translate(new Vector3(0, -1, 0) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //���� ����Ű�� ������
            //�ڽ��� �ʴ�(0, 0, 180) ȸ��
            transform.Rotate(new Vector3(0, 0, 180) * Time.deltaTime);
            //�ڽ��� �ʴ�(0, 180, 0) ȸ��
            childTransform.Rotate(new Vector3(0, 180, 0) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //������ ����Ű�� ������
            //�ڽ��� �ʴ�(0, 0, -180) ȸ��
            transform.Rotate(new Vector3(0, 0, -180) * Time.deltaTime);
            //�ڽ��� �ʴ�(0, -180, 0) ȸ��
            childTransform.Rotate(new Vector3(0, -180, 0) * Time.deltaTime);
        }


        /*
         * Vector�� �ӱ�
         * Vector3.one = Vector3(1, 1, 1)
            Vector3.right = Vector3(1, 0, 0)
            Vector3.left = Vector3(-1, 0, 0)
            Vector3.back = Vector3(0, 0, -1)
            Vector3.forward = Vector3(0, 0, 1)
            Vector3.down = Vector3(0, -1, 0)
            Vector3.up = Vector3(0, 1, 0)
         */
        if (Input.GetKeyDown(KeyCode.Q))
        {       //Transform�� �ӱ�
            Debug.Log("���� ������Ʈ�� �� ���� = " + transform.forward);
            Debug.Log("���� ������Ʈ�� ���� ���� = " + transform.right);
            Debug.Log("���� ������Ʈ�� ���� ���� = " + transform.up);
        }
    }
}
