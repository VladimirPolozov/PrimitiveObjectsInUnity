using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log(message: $"������ {other} ����� � �������");
    }

    /*
    void OnTriggerStay(Collider other)
    {
        Debug.Log(message: $"������ {other} ��������� � ��������");
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log(message: $"������ {other} ����� �� ��������");
    }
    */
}   