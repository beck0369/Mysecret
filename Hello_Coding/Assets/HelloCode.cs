using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloCode : MonoBehaviour
{
    //void Start()
    //{
    //    Debug.Log("Hello World!");
    //}  


    //private void Start()
    //{
    //    string characterName = "���";
    //    char bloodType = 'A';
    //    int age = 17;
    //    float height = 168.3f;
    //    bool isFemale = true;

    //    Debug.Log("ĳ���� �̸� :" + characterName);
    //    Debug.Log("������ :" + bloodType);
    //    Debug.Log("���� :" + age);
    //    Debug.Log("Ű :" + height);
    //    Debug.Log("�����ΰ�? :" + isFemale);
    //}


    //private void Start()
    //{
    //    float distance = GetDistance(2, 2, 5, 6);
    //    Debug.Log("(2, 2)���� (5, 6)������ �Ÿ� : " + distance);
    //}
    //float GetDistance(float x1, float y1, float x2, float y2)
    //{
    //    float width = x2 - x1;
    //    float height = y2 - y1;

    //    float distance = width * width + height * height;
    //    distance = Mathf.Sqrt(distance);

    //    return distance;
    //}


    //int love = 100;

    //private void Start()
    //{
    //    Love();
    //}

    //public void Love()
    //{
    //    if (love > 70)
    //    {
    //        Debug.Log("�¿��� : �����ΰ� ��Ͱ� �Ǿ���!");
    //    }
    //    if (love <= 70)
    //    {
    //        Debug.Log("��忣�� : �����ο��� ������.");
    //    }
    //}


    //private void Start()
    //{
    //    int love = 80;

    //    if(love > 90)
    //    {
    //        Debug.Log("Ʈ�翣�� : �����ΰ� ��ȥ�ߴ�!");
    //    }
    //    else if(love > 70)
    //    {
    //        Debug.Log("�¿��� : �����ΰ� ��Ͱ� �Ǿ���!");
    //    }
    //    else
    //    {
    //        Debug.Log("��忣�� : �����ο��� ������.");
    //    }
    //}


    //private void Start()
    //{
    //    for (int i = 0; i < 10; i++)
    //    {
    //        Debug.Log(i + " ��° �����Դϴ�.");
    //    }
    //}


    //private void Start()
    //{
    //    int i = 0;

    //    while(i<10)
    //    {
    //        Debug.Log($"{i++}��° �����Դϴ�.");

    //    }
    //}


    //private void Start()
    //{
    //    int[] student = new int[5];

    //    student[0] = 100;
    //    student[1] = 90;
    //    student[2] = 80;
    //    student[3] = 70;
    //    student[4] = 60;

    //    Debug.Log("0�� �л��� ���� : " + student[0]);
    //    Debug.Log("1�� �л��� ���� : " + student[1]);
    //    Debug.Log("2�� �л��� ���� : " + student[2]);
    //    Debug.Log("3�� �л��� ���� : " + student[3]);
    //    Debug.Log("4�� �л��� ���� : " + student[4]);
    //}


    private void Start()
    {
        int[] student = new int[5];

        student[0] = 100;
        student[1] = 90;
        student[2] = 80;
        student[3] = 70;
        student[4] = 60;

        for(int i = 4; i >= 0;i--)
        {
            Debug.Log((i + 1) + " �� �л��� ���� : " + student[i]);
        }
    }
}
