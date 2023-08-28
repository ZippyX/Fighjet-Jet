using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int HealthPoint;

    void Update()
    {
        if (HealthPoint < 0)
            Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        HealthPoint -= 1;
        if (!collision.gameObject.CompareTag("Player")) 
            Destroy(collision.gameObject);
    }

}
