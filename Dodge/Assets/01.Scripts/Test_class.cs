using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_class : MonoBehaviour
{
    public Human junhee;
    public Human junhee_1;

    // Start is called before the first frame update
    void Start()
    {
        junhee = new Human();       //Human타입의 객체를 만들어줬다(인스턴스화)
        junhee.age = 25;            //사람의 나이를 정해줌
        //junhee.test_protected = "준희";       //사람의 이름을 정해줌
        //Debug.Log("이름 : " + junhee.name);
        Debug.Log("나이 : " + junhee.age);
        junhee_1 = junhee;
        //Debug.Log("이름 : " + junhee_1.name);
        Debug.Log("나이 : " + junhee_1.age);
        junhee_1.age = 15;                  //junhee_1의 age(나이)를 15로 바꿔줌
        Debug.Log("이름 : " + junhee.age + "나이 : " + junhee_1.age);//클래스가 참조타입이라 junhee_1의 age(나이)를 바꿔도 junhee변수 안에
                                                                 //있는 age라는 값이 바꼈다
        Debug.Log("나이 : " + junhee_1.age);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
public class Human 
{
    private string name;            //private는 Human 클래스 내부에서만 접근이 가능하다
    public int age;                 //public은 Human 클래스 외부에서도 접근이 가능하다
    protected string test_protected;
    void Test_method()
    {
        name = "이름";
        age = 25;
    }
}
public class Test_Human2 : Human
{
    void Test_method() 
    {
        test_protected = "테스트용 문자열"; //protected로 선언이 돼있어서 외부에선 접근이 불가능하지만 상속받은 클래스에선 접근이 가능하다
    }
}


