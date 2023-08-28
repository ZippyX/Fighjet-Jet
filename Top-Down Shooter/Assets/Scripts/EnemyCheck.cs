using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCheck : MonoBehaviour
{
    public bool EnemyDie;// поле, с помощью которого можно обратиться к полям камеры
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!(GameObject.FindGameObjectWithTag("Enemy")))
        {
            EnemyDie = true;
        }
    }
}
