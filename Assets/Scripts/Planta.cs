using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Planta : MonoBehaviour
{
    public Animator animator;
    



    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == ("Accionar"))
        {
            animator.enabled = true;
            Debug.Log("entro");
        }
    }
    private void OnCollisionEnter2D(Collision2D coll)
    {
        if(coll.gameObject.name == ("End"))
        {
            animator = GetComponent<Animator>();
            animator.SetTrigger("crash");
            Invoke("Back", 0.5f);
        }
    }

    //if (other.name==("End" ))
    //{

    //    animator.SetTrigger("crash");  
    //    Invoke("Back", 0.5f);



    //}
    //if (other.gameObject.CompareTag("Tamal"))
    //{


    //    tamal.Play();
    //    Debug.Log("entro");
    //}

   private void Back()
    {

        SceneManager.LoadScene("End");
    }
}
