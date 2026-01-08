using UnityEngine;

public class Target : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        // Vérifie si c'est bien un ballon qui touche la cible
        if (collision.gameObject.GetComponent<Rigidbody>() != null) 
        {
            // Ajoute un point
            GameManager.instance.AddScore();
            
            // Détruit la cible
            Destroy(gameObject);
            
           
        }
    }
}