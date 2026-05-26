using UnityEngine;

public class Stalking : MonoBehaviour
{
    public GameObject stalker;
    void Start()
    {
        stalker.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            stalker.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            stalker.SetActive(false);
        }
    }
}
