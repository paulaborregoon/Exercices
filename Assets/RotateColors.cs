using UnityEngine;

public class RotateColors : MonoBehaviour
{
    public GameObject[] spheres; 
    public float delay = 0.5f; //temps entre canvis de color
    void Start()
    {
        InvokeRepeating("RotationColors", delay, delay); // delay delay ??
    }

    void RotationColors()
    {
        Color lastColor = spheres[spheres.Length - 1].GetComponent<Renderer>().material.color;

        for(int i = spheres.Length-1; i>0;  i--)
        {
            spheres[i].GetComponent<Renderer>().material.color =
                spheres[i - 1].GetComponent<Renderer>().material.color;
        }

        spheres[0].GetComponent<Renderer>().material.color = lastColor;
    }
}


