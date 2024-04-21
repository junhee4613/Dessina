using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dessina_player : MonoBehaviour
{
    public Rigidbody player_rigidbody;          //�̵��� ����� ������ٵ� ������Ʈ
    public float speed = 8f;                    //�̵��ӷ�
    

    private void Awake()
    {

    }
    // Start is called before the first frame update
    void Start()
    {
        //���� ������Ʈ���� Rigidbody ������Ʈ�� ã�� player_rigidbody�� �Ҵ�
        player_rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //������� �������� �Է°��� �����Ͽ� ����
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        //���� �̵� �ӵ��� �Է°��� �̵� �ӷ��� ����� ����
        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        //Vector3 �ӵ��� (xSpeed, 0, zSpeed)�� ����
        Vector3 newVelocity = new Vector3(xSpeed, 0, zSpeed);
        //������ٵ��� �ӵ��� newVelocity �Ҵ�
        player_rigidbody.velocity = newVelocity;
    }
    public void Die()
    {
        //�ڽ��� ���� ������Ʈ�� ��Ȱ��ȭ
        gameObject.SetActive(false);

        //���� �����ϴ� GameManager Ÿ���� ������Ʈ�� ã�Ƽ� ��������
        Dessina_gamemanager gameManager = FindObjectOfType<Dessina_gamemanager>();
        // ������ GameManager ������Ʈ�� EndGame() �޼��� ����
        gameManager.EndGame();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Check_point")
        {
            other.gameObject.SetActive(false);
            int num = Random.Range(0, 3);
            Dessina_gamemanager.instance.check_point_objs[num].SetActive(true);
            //�̱��� �������� ���� Dessina_gamemanager�� �����ؼ� check_point_count�� ���� ���� + 1��ŭ ����
            Dessina_gamemanager.instance.check_point_count += 1;
        }
    }
}
