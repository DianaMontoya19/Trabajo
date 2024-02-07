using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class temporizador : MonoBehaviour
{
    public float timer = 0f;
    public Text textoTimer;
    public GameObject game;
    void Update()
    {
        timer -= Time.deltaTime;
        textoTimer.text = "" + timer.ToString("f0");

        if(timer <= 0f)
        {
            game.gameObject.SetActive(true);
            Time.timeScale = 0f;
            timer = 0f;
        }
    }
    
}
