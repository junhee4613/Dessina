using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dessina_bullet_spawner : MonoBehaviour
{
    public GameObject bullet_prefab;    //������ ź���� ���� ������
    public float spawn_rate_min = 0.5f; // �ּ� ���� �ֱ�
    public float spawn_rate_max = 3f;   //�ִ� ���� �ֱ�

    Transform target;   //�߻��� ���
    public float spawn_rate;   //���� �ֱ�
    float time_after_spawn; //�ֱ� ���� �������� ���� �ð�

    // Start is called before the first frame update
    void Start()
    {
        //�ֱ� ���� ������ ���� �ð��� 0���� �ʱ�ȭ
        time_after_spawn = 0;
        //ź�� ���� ������ spawn_rate_min�� spawn_rate_max ���̿��� ���� ����
        spawn_rate = Random.Range(spawn_rate_min, spawn_rate_max);
        //Player_controller ������Ʈ�� ���� ���� ������Ʈ�� ã�� ���� ������� ����
        target = FindObjectOfType<Dessina_player>().transform;       //���� �����ϴ� ��� ������Ʈ���� �˻��Ͽ� ������ Ÿ�԰� ��ġ�� ������Ʈ�� �������� �ű⶧���� ������ �����ų ��� ���α׷��� �ɰ��ϰ� ���������ֽ��ϴ�.
        //FindObjectsOfType �޼���� ������ Ÿ���� ������Ʈ�� �������̰� �� ������Ʈ���� ������ �� ����Ѵ�. 
    }

    // Update is called once per frame
    void Update()
    {
        //time_after_spawn ����
        time_after_spawn += Time.deltaTime; // time_after_spawn = time_after_spawn + Time.deltaTime;

        //�ֱ� ���� ������������ ������ �ð��� ���� �ֱ⺸�� ũ�ų� ���ٸ�
        if (time_after_spawn > spawn_rate)
        {
            //������ �ð��� ����
            time_after_spawn = 0;

            //bullet_prefab�� ��������
            //transform.position ��ĥ�� transform.rotation ȸ������ ����
            GameObject bullet
                = Instantiate(bullet_prefab, transform.position, transform.rotation);
            //������ bullet ���� ������Ʈ�� ���� ������ target�� ���ϵ��� ȸ��

            //������ ���� ������ spawn_rate_min, spawn_rate_max ���̿��� ���� ����
            spawn_rate = Random.Range(spawn_rate_min, spawn_rate_max);
        }
    }
}
