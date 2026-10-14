using TMPro;
using UnityEngine;

public class HUDController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI livesText;
    [SerializeField] private TextMeshProUGUI enemiesText;
    [SerializeField] private TextMeshProUGUI eText;

    private void Awake()
    {
        //Initialize UI on start
        PositionTopLeft();
        PositionTopRight();
        PositionBottomMiddle();
        UpdateLives(0);
        UpdateEnemies(0);
        UpdateE();

    }

    public void UpdateLives(int lives)
    {
        if (livesText != null)
            livesText.text = "Lives: " + lives;
        else
            Debug.LogError("HUDController: livesText is not assigned in the Inspector.");
    }

    public void UpdateEnemies(int defeated)
    {
        if (enemiesText != null)
            enemiesText.text = "Enemies Defeated: " + defeated;
        else
            Debug.LogError("HUDController: enemiesText is not assigned in the Inspector.");
    }

    public void UpdateE()
    {
        if (eText != null)
            eText.text = "Press E to knockback";
        else
            Debug.LogError("HUDController: enemiesText is not assigned in the Inspector.");
    }

    public void PositionTopLeft(float xOffset = 20f, float yOffset = -20f)
    {
        livesText.rectTransform.anchorMin = new Vector2(0, 1);
        livesText.rectTransform.anchorMax = new Vector2(0, 1);
        livesText.rectTransform.pivot = new Vector2(0, 1);

        livesText.rectTransform.anchoredPosition = new Vector2(xOffset, yOffset);
    }

    public void PositionTopRight(float xOffset = -20f, float yOffset = -20f)
    {
        enemiesText.rectTransform.anchorMin = new Vector2(1, 1);
        enemiesText.rectTransform.anchorMax = new Vector2(1, 1);
        enemiesText.rectTransform.pivot = new Vector2(1, 1);

        enemiesText.rectTransform.anchoredPosition = new Vector2(xOffset, yOffset);
    }

    public void PositionBottomMiddle(float xOffset = -20f, float yOffset = 35f)
    {
        eText.rectTransform.anchorMin = new Vector2(0.5f, 0);
        eText.rectTransform.anchorMax = new Vector2(0.5f, 0);
        eText.rectTransform.pivot = new Vector2(0.5f, 0);

        eText.rectTransform.anchoredPosition = new Vector2(xOffset, yOffset);
    }
}