using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCheck : MonoBehaviour
{
    public bool EnemyDie;// ����, � ������� �������� ����� ���������� � ����� ������
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
