using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int HealtPoint = 3;
    private bool _isInvincibility;
    private bool _playerGetHit;
    private float _time = 0;
    private Renderer _sprite;
    void Start()

    {
        _sprite = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (HealtPoint <= 0)
            Destroy(gameObject);
        if (_playerGetHit)
        {
            TurnInvincibility();
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!_playerGetHit && !_isInvincibility && collision.gameObject.CompareTag("Enemy"))
        {
            HealtPoint -= 1;
            _playerGetHit = true;
        }

    }
    private void TurnInvincibility()
    {
        _isInvincibility = true;
        if (_time >= 1)
        {
            _playerGetHit = false;
            _isInvincibility = false;
            _sprite.material.color = Color.blue;
            _time = 0;
        }
        else
        {
            _time += Time.deltaTime;
            _sprite.material.color = Color.black;
        }
    }


}
