using System.Collections;
using UnityEngine;

public class mimic : MonoBehaviour
{
    private bool down;

    private void Start()
    {
        down = false;
    }

    private void Update()
    {
        if(down)
        {
            StartCoroutine("Boom");
            down = false;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        down = true;
    }

    IEnumerator Boom()
    {
        yield return new WaitForSeconds(1);
        transform.position = Vector3.down;
        down = true;
    }
}
