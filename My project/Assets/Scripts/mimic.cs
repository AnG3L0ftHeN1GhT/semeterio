using System.Collections;
using UnityEngine;

public class mimic : MonoBehaviour
{
    private bool fall;

    private void Start()
    {
        gameObject.SetActive(false);
        fall = false;
    }

    private void Update()
    {
        if(fall)
        {
            StartCoroutine("Boom");
            fall = false;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        fall = true;
    }

    IEnumerator Boom()
    {
        yield return new WaitForSeconds(1);
        transform.Translate(Vector3.down);
        fall = true;
    }
}
