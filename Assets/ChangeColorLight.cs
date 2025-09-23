using UnityEngine;

public class ChangeColorLight : MonoBehaviour
{
    void Start()
    {
        Light llum = GetComponent<Light>();
        llum.color = Color.blue;
    }
}