using UnityEngine;

public class SphereColorChange : MonoBehaviour
{
    [SerializeField] private Renderer[] spheres;     // pots omplir-ho manualment a l'Inspector
    [SerializeField] private float delay = 0.5f;     // retard entre rotacions (segons)
    [SerializeField] private bool autoCollectChildren = true; // si true, recull els Renderers dels fills

    void Start()
    {

    }

    void Update()
    {
        
    }
}
