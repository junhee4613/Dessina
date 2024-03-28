using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_2 : MonoBehaviour
{
    //변수를 선언하는 방법은 타입과 변수명을 선언하고 세미클론을 붙여준다.

    public int test_int;   //정수를 할당할 때 int타입으로 변수를 선언하다.
    public float test_float;   //정수도 가능하지만 소수의 값을 저장할 때 float타입의 변수를 선언하다.
    public string test_string; //문자열을 할당해줄 때 string타입의 변수를 선언해준다.
    public bool test_bool;     //true와 false의 값 즉 참과 거짓의 값을 할당 할 때 bool타입의 변수를 선언해준다.

    /*public int test_int2;
    public int test_int3;
    public int test_int4;*/

    
    public int test_bool1;
    public int test_bool2;

    public bool test_while;

    public int[] test_array_int = new int[2];            //int타입의 배열 변수 선언 방법
    private void Start()
    {
        // int 1 = 0은 반복을 시작하는 숫자, i < 10은 i 가 10보다 작을 때까지 반복, i++ 는 i를 1씩 증가
        /*for (int i = 0; i < 10; i++)    
        {
            Debug.Log(i);
        }*/


        //test_method(test_int2, test_int3);
        //test_int4 = test_method2(test_int2, test_int3);


        //test_array_int[0] = 1;            //배열 0번째 인덱스에 1의 값을 할당
        //test_int = test_array_int[0];       //배열 0번째 인덱스에 있는 1의 값을 test_int에 할당
    }
    private void Update()
    {
        /*if (test_bool)        bool타입 변수 사용하는 곳 예시
        {
            Debug.Log("참");
        }
        else
        {
            Debug.Log("거짓");
        }*/

        //while문은 괄호 안에 있는 값이 만족을 할 때까지만 반복을 한다.
        /*while (true)
        {
            Debug.Log(test_bool1++);
            if(test_bool1 < 10)
                break;
        }*/
        //비교 연산자 종류
        //a > b 는 a는 b보다 크다 
        //a < b 는 b는 a보다 크다
        //a == b a는 b와 같다.
        //a <= b b는 a와 같거나 크다.
        //a >= b a는 b와 같거나 크다
        //a != b a 와 b는 다르다.

        //논리연산자
        // && 그리고를 뜻함
        // || 또는
        // !  아니다

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (test_bool1 < test_bool2)
            {
                Debug.Log("if문 실행(참이다)");
            }
            else if (test_bool1 == test_bool2)
            {
                Debug.Log("else if 실행(참이다)");
            }
            else
            {
                Debug.Log("else 문 실행(모두 거짓)");
            }

            if (test_bool1 < test_bool2)
            {
                Debug.Log("if문 실행(참이다)");
            }
            else
            {
                Debug.Log("else 문 실행(모두 거짓)");
            }

            if (test_bool1 < test_bool2)
            {
                Debug.Log("if문 실행(참이다)");
            }
            else if (test_bool1 == test_bool2)
            {
                Debug.Log("else if 실행(참이다)");
            }
        }
    }
    //아래에 있는 건 전체 주석(Ctrl + Shift + / 를 누르면 된다 ),
    //(Ctrl + k 누른 후 Ctrl + C) 이걸 풀려면 (Ctrl + k 를 누른 후 Ctrl + U)
    /*void test_method(int a, int b)  //return을 안해주는 함수 함수명 옆에 void로 선언해준다.
    {
        Debug.Log(a + b);
    }
    int test_method2(int a, int b)  //return을 해주는 함수 옆에는 반환되는 값의 타입을 지정해준다.
    {
        return a + b;
    }*/




}
