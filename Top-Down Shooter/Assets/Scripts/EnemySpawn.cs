using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public List<Transform> Place;
    public GameObject Enemy;
    public GameObject TrackEnemy;
    public EnemyCheck Data;
    public GameObject HeavyEnemy;
    public CameraScroll Camera;
    public int Phase;

    void OnTriggerStay2D(Collider2D collision)
    {
        if (Data.EnemyDie && !Camera.CameraStartScrooll)
        {
            Spawn();
            Destroy(gameObject);
        }
        Debug.Log(Phase);
       // чтобы игрок спокойно мог передвигать после активации триггера, его можно убрать
    }
    
    void Spawn()// 
    {
        if (Phase == 1)
            for (int i = 0; i < Place.Count; i++)
            {
                if (i == 9)
                {
                    InstanseEnemy(TrackEnemy, -90, i);
                    continue;
                }
                if (i >= 7)
                {
                    InstanseEnemy(Enemy, -90, i);
                }
                else
                    InstanseEnemy(Enemy, 0, i);
            }
        if (Phase == 2)
        {

            for (int i = 0; i < Place.Count; i++)
            {
                if (i == 6)
                {
                    InstanseEnemy(Enemy, -90, i);
                }
                else if (i >= 3)
                {
                    InstanseEnemy(HeavyEnemy, -90, i);
                    continue;
                }

                else
                {
                    InstanseEnemy(TrackEnemy, -90, i);
                }

            }
        } 

    }
    void InstanseEnemy(GameObject Enemy,float z,int i) // поворот объекта, i - элемент массива
    {
        Instantiate(Enemy, Place[i].position, Quaternion.Euler(new Vector3(0, 0,z)));
    }
}
