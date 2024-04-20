using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log(message: $"Объект {other} вошёл в триггер");
    }

    /*
    void OnTriggerStay(Collider other)
    {
        Debug.Log(message: $"Объект {other} находится в триггере");
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log(message: $"Объект {other} вышел из триггера");
    }
    */
}   