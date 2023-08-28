using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    float _bulletLifeTime;
    void Start()
    {
                    
    }

    // Update is called once per frame
    void Update()
    {
        var position = GetComponent<Transform>().position;
        if (position.y < -6 || position.y > 6 || position.x < -15 || position.x > 70)
            Destroy(gameObject);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("PlayerBullet"))
            Destroy(collision.gameObject);
        Destroy(gameObject);
    }


}
