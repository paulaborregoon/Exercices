using UnityEngine;

public class ChangeColorLight : MonoBehaviour
{
    public Light llum;
    void Start()
    {
        llum = GetComponent<Light>();
        llum.color = Color.blue;
    }
}