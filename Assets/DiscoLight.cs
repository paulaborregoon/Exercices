using UnityEngine;

public class DiscoLight : MonoBehaviour
{
    private Light llum;          // Referència a la llum
    private float speed = 0.5f;  // Temps entre canvis de color

    void Start()
    {
        if (llum == null)
        {
            llum = GetComponent<Light>(); // Si no assignes cap llum, agafa la del mateix GameObject
        }

        InvokeRepeating("ChangeColor", 0f, speed);
    }

    void ChangeColor()
    {
        llum.color = new Color(Random.value, Random.value, Random.value); // Color random
    }
}
