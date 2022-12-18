using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class EnemyC : MonoBehaviour
{

    private float _speed = 3f;
    private void Awake()
    {
        EventManager.OnOpenEvent.AddListener(moveToPosition); // добавление слушателя в событие
    }

    private void moveToPosition(Vector2 playerPose) // передвижение объекта в позицию игрока
    {
        transform.position = Vector2.MoveTowards(transform.position, playerPose, _speed * Time.fixedDeltaTime); 
    }

   
}
