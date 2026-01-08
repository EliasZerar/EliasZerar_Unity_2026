using UnityEngine;
using UnityEngine.InputSystem; 

public class PlayerShooter : MonoBehaviour
{
    public GameObject ballPrefab; 
    public Transform spawnPoint;  
    
    public float throwForce = 10f; 
    public float upForce = 5f;     

    void Update()
    {
        // Clic gauche de la souris
        if (Mouse.current != null && Mouse.current.leftButton.wasPressedThisFrame)
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // 1. Créer la balle
        GameObject currentBall = Instantiate(
            ballPrefab, 
            spawnPoint.position, 
            spawnPoint.rotation
        );
        
        // 2. Récupérer le Rigidbody
        Rigidbody rb = currentBall.GetComponent<Rigidbody>();

        // 3. Appliquer la force (avant + haut)
        Vector3 forceDirection = transform.forward * throwForce + Vector3.up * upForce;
        
        rb.AddForce(forceDirection, ForceMode.Impulse);
    }
}
