using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int totalCollectibles = 5;
    public float timeLimit = 60f;
    private int collectedItems = 0;
    private float timer;
    public bool gameEnded = false;

    public Text timerText;
    public GameObject winPanel;
    public GameObject losePanel;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        timer = timeLimit;
        winPanel.SetActive(false);
        losePanel.SetActive(false);
    }

    void Update()
    {
        if (gameEnded) return;

        timer -= Time.deltaTime;
        timerText.text = "Time: " + Mathf.Ceil(timer).ToString();

        if (timer <= 0)
        {
            EndGame(false);
        }
    }

    public void CollectItem()
    {
        collectedItems++;
        Debug.Log("Collected Items: " + collectedItems + "/" + totalCollectibles);

        if (collectedItems >= totalCollectibles)
        {
            Debug.Log("All items collected. Ending game.");
            EndGame(true);
        }
    }

    void EndGame(bool won)
    {
        gameEnded = true;
        Debug.Log("Game Ended: " + (won ? "Won" : "Lost"));
        if (won)
        {
            winPanel.SetActive(true);
            Debug.Log("Win panel activated.");
        }
        else
        {
            losePanel.SetActive(true);
            Debug.Log("Lose panel activated.");
        }
    }
}
