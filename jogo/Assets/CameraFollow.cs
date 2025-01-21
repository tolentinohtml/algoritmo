using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;  // Referência ao transform do jogador
    public float smoothSpeed = 0.125f;  // Velocidade de suavização da câmera
    public Vector3 offset;  // Distância entre a câmera e o jogador

    void Start()
    {
        // Certifique-se de que o jogador está atribuído no Inspector ou defina um valor padrão aqui
        if (player == null)
        {
            Debug.LogError("Player não atribuído à câmera. Atribua um jogador no Inspector.");
        }
    }

    void FixedUpdate()
    {
        // Calcula a posição desejada da câmera com base na posição do jogador e no deslocamento
        Vector3 desiredPosition = player.position + offset;

        // Suaviza a transição da posição atual para a desejada
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        // Atualiza a posição da câmera
        transform.position = smoothedPosition;
    }
}
