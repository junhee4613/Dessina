using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_variable : MonoBehaviour
{
    //������ �����ϴ� ����� Ÿ�԰� �������� �����ϰ� ����Ŭ���� �ٿ��ش�.

    public int test_int;   //������ �Ҵ��� �� intŸ������ ������ �����ϴ�.
    public float test_float;   //������ ���������� �Ҽ��� ���� ������ �� floatŸ���� ������ �����ϴ�.
    public string test_string; //���ڿ��� �Ҵ����� �� stringŸ���� ������ �������ش�.
    public bool test_bool;     //true�� false�� �� �� ���� ������ ���� �Ҵ� �� �� boolŸ���� ������ �������ش�.

    /*public int test_int2;
    public int test_int3;
    public int test_int4;*/

    
    public int test_bool1;
    public int test_bool2;

    public bool test_while;

    public int[] test_array_int = new int[2];            //intŸ���� �迭 ���� ���� ���
    private void Start()
    {
        // int 1 = 0�� �ݺ��� �����ϴ� ����, i < 10�� i �� 10���� ���� ������ �ݺ�, i++ �� i�� 1�� ����
        /*for (int i = 0; i < 10; i++)    
        {
            Debug.Log(i);
        }*/


        //test_method(test_int2, test_int3);
        //test_int4 = test_method2(test_int2, test_int3);


        //test_array_int[0] = 1;            //�迭 0��° �ε����� 1�� ���� �Ҵ�
        //test_int = test_array_int[0];       //�迭 0��° �ε����� �ִ� ���� 1�� test_int�� �Ҵ�
    }
    private void Update()
    {
        /*if (test_bool)        boolŸ�� ���� ����ϴ� �� ����
        {
            Debug.Log("��");
        }
        else
        {
            Debug.Log("����");
        }*/

        //while���� ��ȣ �ȿ� �ִ� ���� ������ �� �������� �ݺ��� �Ѵ�.
        /*while (true)
        {
            Debug.Log(test_bool1++);
            if(test_bool1 < 10)
                break;
        }*/
        //�� ������ ����
        //a > b �� a�� b���� ũ�� 
        //a < b �� b�� a���� ũ��
        //a == b a�� b�� ����.
        //a <= b b�� a�� ���ų� ũ��.
        //a >= b a�� b�� ���ų� ũ��
        //a != b a �� b�� �ٸ���.

        //��������
        // && �׸��� ����
        // || �Ǵ�
        // !  �ƴϴ�

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (test_bool1 < test_bool2)
            {
                Debug.Log("if�� ����(���̴�)");
            }
            else if (test_bool1 == test_bool2)
            {
                Debug.Log("else if ����(���̴�)");
            }
            else
            {
                Debug.Log("else �� ����(��� ����)");
            }

            if (test_bool1 < test_bool2)
            {
                Debug.Log("if�� ����(���̴�)");
            }
            else
            {
                Debug.Log("else �� ����(��� ����)");
            }

            if (test_bool1 < test_bool2)
            {
                Debug.Log("if�� ����(���̴�)");
            }
            else if (test_bool1 == test_bool2)
            {
                Debug.Log("else if ����(���̴�)");
            }
        }
    }
    //�Ʒ��� �ִ� �� ��ü �ּ�(Ctrl + Shift + / �� ������ �ȴ� ),
    //(Ctrl + k ���� �� Ctrl + C) �̰� Ǯ���� (Ctrl + k �� ���� �� Ctrl + U)
    /*void test_method(int a, int b)  //return�� �����ִ� �Լ� �Լ��� ���� void�� �������ش�.
    {
        Debug.Log(a + b);
    }
    int test_method2(int a, int b)  //return�� ���ִ� �Լ� ������ ��ȯ�Ǵ� ���� Ÿ���� �������ش�.
    {
        return a + b;
    }*/




}
