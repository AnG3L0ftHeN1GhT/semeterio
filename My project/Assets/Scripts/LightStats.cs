using System.Collections;
using UnityEngine;

public class LightStats : MonoBehaviour
{
    private Light Luz;
    public bool CanFlicker;
    public int FlickChance;
    private float FlickCheck;
    public float MinIntensity;
    public float MaxIntensity;
    public float MinFlickRate;
    public float MaxFlickRate;
    void Start()
    {
        Luz = GetComponent<Light>();
        if(FlickChance < 1)
        {
            FlickChance = 1;
        }
        if(FlickChance > 100)
        {
            FlickChance = 100;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(CanFlicker)
        {
            FlickCheck = Random.Range(1, 100);
            if (FlickCheck <= FlickChance)
            {
                StartCoroutine("Flickering");
            }
        }
    }

    IEnumerator Flickering()
    {
        Luz.intensity = Random.Range(MinIntensity, MaxIntensity);
        yield return new WaitForSeconds(Random.Range(MinFlickRate, MaxFlickRate));
        Luz.intensity = 1;
    }
}
