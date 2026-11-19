using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public BrickManager brickManager;
    public TextMeshProUGUI scoreText;
    private int bricksBreaks = 0;
    private int Total_score = 0;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
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
        }
    }
    
    public void AddScore(int score)
    {
        Total_score+=score;
        Debug.Log(Total_score);
        
        scoreText.text = "Score: " + Total_score;
    }
}
