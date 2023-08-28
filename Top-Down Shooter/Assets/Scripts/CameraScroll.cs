using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScroll : MonoBehaviour
{
    public float Velocity = 0.5f;
    private float _time;
    public bool CameraStartScrooll;
    public EnemyCheck Check;
    public float Distanse = 20; // дистанция, на которую передвигается камера
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Check.EnemyDie)
        {
            if (_time > 0.1f)
            {
                StartMovingCamera();
                _time = 0;
            }
            else
                _time += Time.deltaTime;
        
        }

        Debug.Log(CameraStartScrooll);
    }

    void StartMovingCamera()
    {
        if (transform.position.x <= Distanse)
        {
            transform.position += new Vector3(0.1f, 0) * Velocity;
            CameraStartScrooll = true;
        }
        else
        { 
            Check.EnemyDie = false;
            CameraStartScrooll = false;
        }
    }
}
