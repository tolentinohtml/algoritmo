using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;  
    public float smoothSpeed = 0.125f;  
    public Vector3 offset;  

    void Start()
    {
        
        if (player == null)
        {
            Debug.LogError("Player não atribuído à câmera. Atribua um jogador no Inspector.");
        }
    }

    void FixedUpdate()
    {
       
        Vector3 desiredPosition = player.position + offset;

        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        transform.position = smoothedPosition;
    }
}
