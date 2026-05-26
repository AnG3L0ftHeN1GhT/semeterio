using System.Collections;
using UnityEngine;

public class PlaySomething : MonoBehaviour
{
    public AudioSource som;
    private Coroutine destroy;
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
            StartCoroutine("Boom");
        }
    }

    IEnumerator Boom()
    {
        yield return new WaitForSeconds(1);
        gameObject.SetActive(false);
    }
}
