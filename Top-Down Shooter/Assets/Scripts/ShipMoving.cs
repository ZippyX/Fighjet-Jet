using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMoving : MonoBehaviour
{
    public float Velocity;
    private Vector2 _direction;
    private Rigidbody2D _body;

    void Start()
    {
        _body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        _direction.x = Input.GetAxisRaw("Horizontal");
        _direction.y = Input.GetAxisRaw("Vertical");
    }
    private void FixedUpdate()
    { 
        StartMoving();
        StartRotation();
    }

    private void StartMoving()// число от -1 до 1
    {
        _body.MovePosition(_body.position + Time.fixedDeltaTime * Velocity * _direction);
    }
    void StartRotation()
    {
        if (Input.GetKey(KeyCode.E) && _body.angularVelocity <= 100)
        {
            _body.AddTorque(-7);
        }
        if (Input.GetKey(KeyCode.Q) && _body.angularVelocity <= 170)
        {
            _body.AddTorque(7);
        }
    }

}