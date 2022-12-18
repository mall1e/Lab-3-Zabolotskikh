using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerD : MonoBehaviour, IDeath
{
    [SerializeField] private ParticleSystem particle;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.H)) //активация смерти на кнопку H
        {
            Death();
        }
    }

    public void Death()
    {
        Destroy(gameObject); //уничтожение объекта

        afterDeath();
    }

    public void afterDeath()
    {
        Instantiate(particle, transform.position, transform.rotation); //появление партиклов
    }
}
