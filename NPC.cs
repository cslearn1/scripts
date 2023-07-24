using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public int Health = 5; //��
    public GameObject NPCobj; //������
    public float speed = 1.5f; //��������
    public int level = 1; // �����
    void Start()
    {
        Health += level; //�� + ����� = ����� ��
        print("�������� ������:" + Health); // ����� �� � �������
    }
    void Update()
    {
        Vector3 newPosition = transform.position;// ��� �������
        newPosition.x += speed * Time.deltaTime; // ������������
        transform.position = newPosition;

    }
}
