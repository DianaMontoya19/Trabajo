using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sonidos : MonoBehaviour
{
    public AudioSource sonidoMoneda;
    private float sound = 1f;
    Vida vida;

    //public string sonidos;
    void Start()
    {
        vida = FindObjectOfType<Vida>();
        sonidoMoneda = GetComponent<AudioSource>();
    }

    // Update is called once per frame
   
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag ("Player"))
        {
            vida.Sound();
            Invoke("Sound", sound);
            sonido();
        }

    }
 
    public void sonido()
    {
        sonidoMoneda.Play();
    }
}
