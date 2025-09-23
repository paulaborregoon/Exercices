using UnityEngine;

public class Mission : MonoBehaviour
{
    public void NovaMissio()
    {
        PlayerStats stats = FindObjectOfType<PlayerStats>();

        if (stats.xp > 420)
        {
            Debug.Log("Let's go!");
        }
        else
        {
            Debug.Log("I'm too weak");
        }
    }

    void Start()
    {
        NovaMissio();
    }
}
