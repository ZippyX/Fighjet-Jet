using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackingBullet : MonoBehaviour
{
    public float Speed;
    private Vector3 _playerPosition;
    private float _bulletLifeTime;
    // Start is called before the first frame update
    void Start()
    {
        _playerPosition = GameObject.FindGameObjectWithTag("Player").transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (_bulletLifeTime > 0.8)
        {
            Destroy(gameObject);
        }
        else _bulletLifeTime += Time.deltaTime;
        transform.position = Vector2.MoveTowards(transform.position, _playerPosition, Speed * Time.deltaTime);

    }
}
