using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float seconds;
    public float minuts;
    public Text text;
    public GameObject enemyPrefab;
    public GameObject spawn;

    private void FixedUpdate()
    {
        text.text = minuts.ToString()+":"+seconds.ToString();

        seconds-=1 * Time.deltaTime;
        Debug.Log(seconds);

        if (seconds <= 0)
        {
            if (minuts > 0)
            {
                seconds = 60;
                minuts -= 1;
                Debug.Log(minuts);
            }
        }
        if (seconds % 2 == 1)
        {
            Instantiate(enemyPrefab, spawn.transform.position, spawn.transform.rotation);
        }
        if (seconds <= 0 && minuts <= 0)
        {
            SceneManager.LoadScene(0);
        }
    }
}
