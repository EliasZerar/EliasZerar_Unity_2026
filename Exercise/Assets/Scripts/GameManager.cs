using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance; 
    public int targetsHit = 0;          // Score actuel
    public int targetsToWin = 3;        // Objectif
    public GameObject winText;          // Le texte de victoire

    void Awake()
    {
        instance = this;
    }

    public void AddScore()
    {
        targetsHit++;
        Debug.Log("Score: " + targetsHit);

        if(targetsHit >= targetsToWin)
        {
            ShowVictory();
        }
    }

    void ShowVictory()
    {
        if(winText != null)
        {
            winText.SetActive(true); // Affiche le texte
            Debug.Log("Gagné !");
        }
    }
}