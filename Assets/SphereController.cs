using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereController : MonoBehaviour
{
    //Ʈ������(Transform)
    //��ġ, ȸ��, ũ�� ǥ���� ���˴ϴ�.
    //�θ� - �ڽ� ���¸� �����ϱ� ���ؼ��� ���˴ϴ�.
    //���� ������Ʈ���� �׻� �ϳ��� Ʈ������ ������Ʈ�� �����մϴ�.
    //Ʈ�������� ���� ���� ������Ʈ�� ������ �� �����ϴ�.

    //Scale�� 1�� �⺻ ũ��(������Ʈ�� import �� ũ��)�̰�, ��ġ�� ���� ����ϰ� �����մϴ�.
    //Scale ���� üũ�� Ǯ ��� ��� �����ϸ� ����� Ȱ��ȭ�˴ϴ�.
    //�����س��� x,y,z�� �������� ���� ������Ű�� x,y,z�� ���� ����˴ϴ�.

    //Input.GetKey : �Է� ��� �߿� �ش� Ű�� ������ ������ ǥ���մϴ�.
    //Input.GetKeyDown : �� Ű�� �Է����� �� (1��)
    //Input.GetKeyUp : �� Ű�� ���� ��(1��)

    Vector3 rotation;

    private void Start()
    {
        rotation = transform.eulerAngles;
        //transform.eulerAngles�� ������Ʈ�� Transform�� Rotation ���� Vector3�� ���·� ��ȯ�ϴ� �ڵ�
        //���Ϸ� ���� ���� ������ ���ڵ��� ����� ���� ������ ������ �� ��
        //�����ϰ� ��� : x, y, z�� �������� ���
        //������ : eulerAngles ��ġ�� ���� ������ų ��� ������Ʈ�� 90�� �̻��� ���� �ʰ� ���� �˴ϴ�.
        
        //�ذ�� : ������ ���� �� ���ʹϾ�(Quaternion)���� ����� ó���մϴ�.
        //���ʹϾ��� ����Ƽ�� ���Ϸ� ���� ������ ������ ������ �ذ�å���� ����մϴ�.

        //���ʹϾ�(Quaternion) : �����
        //3���� �׷��ȿ��� ȸ���� ǥ���� �� ��� ��� ����ϴ� ������ ������ �ǹ��մϴ�.
        //���ʹϾ��� x,y,z ���Ϳ� w(��Į��)�� ���� ����� �����մϴ�.
        //���������� ���ʹϾ��� x, y, z�� w�� ��� ������ ���Ҽ��̸�
        //w(��Į��)�� �Ǽ��� �ش��ϰ� x,y,z�� ����� �ش�˴ϴ�.

        //��� : ���ʹϾ����� ����� ��� x,y,z���� �� ȸ���ϴ� ���� �����մϴ�.
    }



    void Update()
    {
        //������Ʈ�� ���� �̵�(Transform)
        //���� ��ġ�� �ٸ� �������� �ʱ�ȭ�� ��ǥ�� �̵��ϴ� ���
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += new Vector3(0, 0, 2) * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            //transform.Translate(�̵��� ��ǥ)�� ���� ��ǥ�� �̵��ϴ� ���
            transform.Translate(new Vector3 (0, 0, -2) * Time.deltaTime);
        }

        //������Ʈ�� ���� ȸ���� ����

        if(Input.GetKey(KeyCode.A))
        {
            rotation += new Vector3(90, 0, 0) * Time.deltaTime;
            transform.rotation = Quaternion.Euler(rotation);

            //���ʹϾ� ���� ����
            //Quaternion.LookRotation(rotation); //������ upwards ������ rotation�� �����ϴ� �ڵ�
            //Quaternion.Euler(); //�� x,y,z ���� ȸ���� ������� Rotation�� ��ȯ�ϴ� ���
            //Quaternion.Angle(a, b); //���ʹϾ� �� a�� b���̿� ������ ��ȯ�ϴ� ���
            //Quaternion.Slerp(a, b, t); //a�� b���̸� t �������� ���� �����մϴ� => �ε巯�� �̵�
                // ����� ���� Mathf.Lerp(a,b,t) : a�� b ���̸� t�������� ���� �����մϴ�.
            //Quaternion.identity : ȸ������ ������ �ǹ��մϴ�. (������Ʈ�� �Ϻ��ϰ� ���� ��ǥ / �θ��� ������ ����)
        }

        if(Input.GetKey (KeyCode.D))
        {
            transform.Rotate(new Vector3(0, 90, 0) * Time.deltaTime);
            //Rotate�� ������Ʈ�� ���� transform�� �־��� ��ġ��ŭ +�ϴ� ����
        }

        if (Input.GetKey(KeyCode.S))
        {
            rotation += new Vector3(0, 0, 90) * Time.deltaTime;
            transform.eulerAngles = rotation; //���Ϸ� ��(���� ����)�� ȸ�� �� �ʱ�ȭ
        }

        if(Input.GetKey(KeyCode.W))
        {
            transform.localScale += new Vector3(2, 2, 2) * Time.deltaTime;
            //localScale�� ��ü�� ������ ũ�⸦ �ǹ��մϴ�.
        }
    }
}