using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Dessina_gamemanager : MonoBehaviour
{
    public static Dessina_gamemanager instance;
    public GameObject gameover_text;    //���� ���� �� Ȱ��ȭ�� �ؽ�Ʈ ���� ������Ʈ
    public Text check_point_count_text;              //���� �ð��� ǥ���� �ؽ�Ʈ ������Ʈ
    public Text record_text;            //�ְ� ����� ǥ���� �ؽ�Ʈ ������Ʈ
    public GameObject[] check_point_objs;

    public int check_point_count;         //üũ ����Ʈ�� ������ Ƚ��
    bool is_gameover;                   //���ӿ��� ����
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        // ���� �ð��� ���ӿ��� ���� �ʱ�ȭ
        check_point_count = 0;
        is_gameover = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!is_gameover)
        {
            //üũ ����Ʈ�� ������ Ƚ���� time_text �ؽ�Ʈ ������Ʈ�� �̿��� ǥ��
            check_point_count_text.text = "Score : " + check_point_count;
        }
        else
        {
            //���� ������ ���¿��� R Ű�� ���� ���
            if (Input.GetKeyDown(KeyCode.R))
            {
                // Dodge �� �ε�
                SceneManager.LoadScene("Dessina_dodge");
            }
        }
    }
    //���� ������ ���ӿ��� ���·� �����ϴ� �޼���
    public void EndGame()
    {
        //���� ���¸� ���ӿ��� ���·� ��ȯ
        is_gameover = true;
        //���ӿ��� �ؽ�Ʈ ���� ������Ʈ�� Ȱ��ȭ
        gameover_text.SetActive(true);

        //Best_time Ű�� ����� ���������� �ְ� ��� ��������
        int best_count = PlayerPrefs.GetInt("Best_count");

        //���������� �ְ� ��Ϻ��� ���� ���� �ð��� �� ũ�ٸ�
        if (check_point_count > best_count)
        {
            //�ְ� ��� ���� ���� ���� �ð� ������ ����
            best_count = check_point_count;
            //����� �ְ� ����� Best_time Ű�� ����
            PlayerPrefs.SetInt("Best_count", best_count);
        }
        //�ְ� ����� record_text �ؽ�Ʈ ������Ʈ�� �̿��� ǥ��
        record_text.text = "Best Time : " + best_count;
    }
}
