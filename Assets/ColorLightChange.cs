using UnityEngine;

public class ColorLightChange : MonoBehaviour
{
    void Start()
    {
        Light llum = GetComponent<Light>();
        llum.color = Color.blue;
    }
    void Update()
    {
        
    }
}
