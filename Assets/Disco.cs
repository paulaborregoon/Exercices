using UnityEngine;

public class Disco : MonoBehaviour
{
    public Light llum;
    public Color[] colors;

    void Update()
    {
        if (colors.Length > 0)
        {
            int index = Random.Range(0, colors.Length);
            llum.color = colors[index];
        }
    }
}