using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipShoot : MonoBehaviour,IShooting
{
    public GameObject Bullet;
    public Transform Muzzle;
    public float Force;
    private float _time = 0;
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        SpawnBullet();
    }
    void SpawnBullet()
    {
        if (_time >= 0.10f)
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
        bullet.GetComponent<Rigidbody2D>().AddForce(Muzzle.right * Force);
    }
}

