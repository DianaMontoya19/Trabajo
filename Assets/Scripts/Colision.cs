using UnityEngine;

public class Colision : MonoBehaviour
{
    public AudioSource tamal;
    void Start()
    {
        
        tamal = GetComponent<AudioSource>();
    }

    // Update is called once per frame

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            tamal.Play();
        }

    }
}
