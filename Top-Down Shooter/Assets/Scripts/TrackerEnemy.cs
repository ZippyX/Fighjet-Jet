using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackerEnemy : MonoBehaviour,IShooting
{
    public GameObject Bullet;
    public Transform Muzzle;
    private float _time;
    public void Shooting()
    {
        Instantiate(Bullet, Muzzle.position, Quaternion.identity);
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
}
