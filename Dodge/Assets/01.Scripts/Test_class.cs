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
        junhee = new Human();       //HumanŸ���� ��ü�� ��������(�ν��Ͻ�ȭ)
        junhee.age = 25;            //����� ���̸� ������
        //junhee.test_protected = "����";       //����� �̸��� ������
        //Debug.Log("�̸� : " + junhee.name);
        Debug.Log("���� : " + junhee.age);
        junhee_1 = junhee;
        //Debug.Log("�̸� : " + junhee_1.name);
        Debug.Log("���� : " + junhee_1.age);
        junhee_1.age = 15;                  //junhee_1�� age(����)�� 15�� �ٲ���
        Debug.Log("�̸� : " + junhee.age + "���� : " + junhee_1.age);//Ŭ������ ����Ÿ���̶� junhee_1�� age(����)�� �ٲ㵵 junhee���� �ȿ�
                                                                 //�ִ� age��� ���� �ٲ���
        Debug.Log("���� : " + junhee_1.age);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
public class Human 
{
    private string name;            //private�� Human Ŭ���� ���ο����� ������ �����ϴ�
    public int age;                 //public�� Human Ŭ���� �ܺο����� ������ �����ϴ�
    protected string test_protected;
    void Test_method()
    {
        name = "�̸�";
        age = 25;
    }
}
public class Test_Human2 : Human
{
    void Test_method() 
    {
        test_protected = "�׽�Ʈ�� ���ڿ�"; //protected�� ������ ���־ �ܺο��� ������ �Ұ��������� ��ӹ��� Ŭ�������� ������ �����ϴ�
    }
}


