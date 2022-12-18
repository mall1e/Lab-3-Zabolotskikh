using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour, IDeath
{
    [SerializeField] private SpriteRenderer spriteRenderer;

    private bool isDeath;


    private void Awake()
    {
        isDeath = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            isDeath = true;
        }

        if (isDeath)
        {
            Death();
        }
    }

    public void Death()
    {
        spriteRenderer.color = Color.red; // изменение цвета

        afterDeath();
    }

    public void afterDeath()
    {
        transform.Rotate(new Vector3(0, 45, 0) * Time.deltaTime); // активация поворота объекта
    }
}
