using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    // Start is called before the first frame update
    public EnemyCheck Data;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Data.EnemyDie)
            UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
    }
    /*
     * ¬еро€тнее всего лучшим решением было бы сделать 3 класса, которые отвечают за выход, рестарт, перевод на другую сцену
     */
}
