using UnityEngine;

public class PlaySomething : MonoBehaviour
{
    public AudioSource som;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            som.Play();
        }
    }
}
