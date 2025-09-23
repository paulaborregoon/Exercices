using UnityEngine;

public class Mission : MonoBehaviour
{
    public void NewMission()
    {
        PlayerStats stats = FindAnyObjectByType<PlayerStats>();

        if (stats != null) //verifica si existeix stats
        {
            if (stats.xp > 420)
            {
                Debug.Log("Let's go!");
            }
            else
            {
                Debug.Log("I'm too weak");
            }
        }
        else
        {
            Debug.LogError("No s'ha trobat cap PlayerStats a l'escena!");
        }
    }

    void Start()
    {
        NewMission();
    }
}
