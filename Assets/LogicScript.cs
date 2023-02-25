using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LogicScript : MonoBehaviour
{
    public int PlayerScore;
    public TextMeshProUGUI scoreText;
    public GameObject gameOverScreen;
    private bool isGameOver = false;

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd) {
        if (!isGameOver)
        {
            PlayerScore += scoreToAdd;
            scoreText.text = PlayerScore.ToString();
        }
    }

    public void restartGame() {
        isGameOver = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver() {
        isGameOver = true;
        gameOverScreen.SetActive(true);
    }

    void Start()
    {
        // Limit the refresh rate based on the user's screen refreshrate.
        Application.targetFrameRate = Screen.currentResolution.refreshRate;
    }
}
