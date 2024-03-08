using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    
    Vector3 pos;
    private void Update()
    {

        pos.x = Mathf.Cos(Time.time * 360 * Mathf.Deg2Rad);
        pos.z = Mathf.Sin(Time.time * 360 * Mathf.Deg2Rad);
        transform.position = pos;

        //Mathf.Cos() �ﰢ�Լ� �ڻ��� ���� ����ϴ� ���
        //Mathf.Sin() �ﰢ�Լ� ���� ���� ����ϴ� ���
        //Mathf.Deg2Rad : ����(Degree) -> ����(Radian)
        //������ �� �� ���� ���� ������ �߽����� �������� ���̸�ŭ �� �������� �������� �� �����ϴ� ���� ũ�� (�� 57.3��)
    }
}
