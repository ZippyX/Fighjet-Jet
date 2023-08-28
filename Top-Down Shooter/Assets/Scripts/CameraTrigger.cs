using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraTrigger : MonoBehaviour
{
    public CameraScroll Data;
    public Collider2D Collider;
    public EnemyCheck Check;    
    void Update()
    {

    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") & Check.EnemyDie & ! Data.CameraStartScrooll)
        {           
            Data.Distanse += Data.Distanse;
            Destroy(gameObject);
        }
    }
}
