using UnityEngine;

public class LightControll : MonoBehaviour
{
    public Light llum;
    public float temps = 10f;
    void Start()
    {
        Invoke("AtenuarLlum", temps);
    }

    void AtenuarLlum()
    {
        llum.intensity = 0.5f; // Redueix la intensitat a la meitat
    }
}
