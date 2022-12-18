using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyD : MonoBehaviour, IDeath
{
    [SerializeField] private GameObject coin;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            Death();
        }
    }

    public void Death()
    {
        Destroy(gameObject);

        afterDeath();
    }

    public void afterDeath()
    {
        Instantiate(coin, transform.position, transform.rotation); // появление монетки вместо объекта
    }
}
