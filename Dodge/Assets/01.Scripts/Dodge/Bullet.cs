using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 8f; //ź�� �̵� �ӷ�
    private Rigidbody bullet_rigidbody; //�̵��� ����� ������ٵ� ������Ʈ

    // Start is called before the first frame update
    void Start()
    {
        //�� ���� ������Ʈ���� Rigidbody ������Ʈ�� ã�� bullet_rigidbody�� �Ҵ�
        bullet_rigidbody = GetComponent<Rigidbody>();
        //������ٵ��� �ӵ� = ���� ���� * �̵� �ӷ�
        bullet_rigidbody.velocity = transform.forward * speed;

        //3�� �ڿ� �ڽ��� ���� ������Ʈ �ı�
        Destroy(gameObject, 3f);
    }

    //collider�� isTrigger�� üũǥ�� ������ �� �浹 �� �ڵ����� ����Ǵ� �޼���
    private void OnTriggerEnter(Collider other)
    {
        //�浹�� ���� ���� ������Ʈ�� Player �±׸� ���� ���
        if(other.tag == "Player")
        {
            //���� ���� ������Ʈ���� Player_controller ������Ʈ ��������
            Dessina_player player_Controller = other.GetComponent<Dessina_player>();

            //�������κ��� Player_controller ������Ʈ�� �������� �� �����ߴٸ�
            if(player_Controller != null)
            {
                //���� Player_controller ������Ʈ�� Die �޼��� ����
                player_Controller.Die();
            }
        }
    }
}
