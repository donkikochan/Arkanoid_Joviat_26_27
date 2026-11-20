using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject ball;
    public BrickManager brickManager;
    public TextMeshProUGUI scoreText;
    private int bricksBreaks = 0;
    private int Total_score = 0;
    public int numLifes = 3;
    
    public TextMeshProUGUI  numLifesText;
    public GameObject panelWin;
    public GameObject panelLose;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        panelWin.SetActive(false);
        panelLose.SetActive(false);
        numLifesText.SetText("Lifes: " + numLifes);
        scoreText.SetText("Score: "  + Total_score);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BreakBrick()
    {
        bricksBreaks++;
        if (bricksBreaks >= brickManager.GetTotalBricks())
        {
            Debug.Log("Win");
            panelWin.SetActive(true);
            Destroy(ball);
        }
    }
    
    public void AddScore(int score)
    {
        Total_score+=score;
        Debug.Log(Total_score);
        
        scoreText.text = "Score: " + Total_score;
    }

    public void NextLevel()
    {
        Debug.Log("NextLevel");
        //TODO: guardar en dades persistens el nivell +1
        SceneManager.LoadScene("GameScene");
        
    }

    public void LifeManager()
    {
        Debug.Log("LifeManager");
        numLifes--;
        numLifesText.text = "Lifes: " + numLifes;
        if (numLifes <= 0)
        {
            Destroy(ball);
            panelLose.SetActive(true);
        }
    }
}
