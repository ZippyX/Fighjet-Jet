using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AverageEnemy : MonoBehaviour,IShooting
{
    public GameObject Bullet;
    public Transform Muzzle;
    public float BulletForce;
    private float _time;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (_time > 0.5)
        {
            Shooting();

            _time = 0;
        }
        else
            _time += Time.deltaTime;

    }

    public void Shooting()
    {
        var bullet = Instantiate(Bullet, Muzzle.position, Quaternion.identity);
        bullet.GetComponent<Rigidbody2D>().AddForce(Muzzle.transform.right * BulletForce);
    }
}
