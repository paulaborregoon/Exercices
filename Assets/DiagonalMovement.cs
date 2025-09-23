using UnityEngine;

public class DiagonalMovement : MonoBehaviour
{
    public float velocitat = 2f; //velocitat a la que es mou

    void Update()
    {
        Vector3 moviment = new Vector3(1, 1, 0) * velocitat * Time.deltaTime;
        transform.Translate(moviment, Space.World);

        // Vector3 es X,Y,Z i va a update pq es va actualitzant cada cop
        // Time.deltaTime = 0.016f (60 FPS → 1/60 = 0.016 segons per frame)
    }
}
