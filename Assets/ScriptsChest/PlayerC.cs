using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerC : MonoBehaviour
{
    [SerializeField] private float _movementSpeed = 5f;
    [SerializeField] private Rigidbody2D _playerRB;

    bool _isActive = false;
    bool _isOpen = false;

    private Vector2 playerPosition;
    private Vector2 _movement;

    private void Update()
    {
        Movement();

        if (_isActive)
        {
            if (Input.GetKeyDown(KeyCode.F)) // открытие сундука на кнопку F
            {
                _isOpen = true;

                playerPosition = transform.position;
                
            }
        }

        if (_isOpen)
        {
            OpenChest();
        }

    }

    private void OpenChest() // передача позиции игрока в момент открытия сундука
    {
        EventManager.sendUse(playerPosition);
    }

    private void Movement() // передвижение игрока
    {
        _movement.x = Input.GetAxis("Horizontal");
        _movement.y = Input.GetAxis("Vertical");

        _playerRB.MovePosition(_playerRB.position + _movement * _movementSpeed * Time.fixedDeltaTime);
    }

    private void OnTriggerStay2D(Collider2D collision) // создание зоны, в которой игрок может открыть сундук
    {
        if (collision.tag == "Chest")
        {
            _isActive = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Chest")
        {
            _isActive = false;
        }
    }


 
    



}
