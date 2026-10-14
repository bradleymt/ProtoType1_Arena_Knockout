using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Gameplay Values")]
    public int lives = 3;
    public int enemiesDefeated = 0;

    [Header("References")]
    [SerializeField] private HUDController hud;

    private void Start()
    {
        //Find HUD if not assigned
        if (hud == null)
        {
            hud = FindObjectOfType<HUDController>();
            if (hud == null)
            {
                Debug.LogError("GameManager: No HUDController found in the scene.");
                return;
            }
        }

        //Initialize HUD display
        hud.UpdateLives(lives);
        hud.UpdateEnemies(enemiesDefeated);
    }

    public void LoseLife()
    {
        lives--;
        hud.UpdateLives(lives);

        if (lives <= 0)
        {
            Debug.Log("Game Over!");
        }
    }

    public void EnemyDefeated()
    {
        enemiesDefeated++;
        hud.UpdateEnemies(enemiesDefeated);
    }
}