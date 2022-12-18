using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventManager : MonoBehaviour
{
    public static UnityEvent<Vector2> OnOpenEvent = new UnityEvent<Vector2>(); // создание события


    public static void sendUse(Vector2 playerPosition)
    {
        OnOpenEvent?.Invoke(playerPosition);
    }

   
}
