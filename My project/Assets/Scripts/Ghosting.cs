using UnityEngine;

public class Ghosting : MonoBehaviour
{
    public GameObject z;
    public GameObject m;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            z.SetActive(true);
            m.SetActive(true);
        }
    }
}
