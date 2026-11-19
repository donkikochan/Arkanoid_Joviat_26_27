using System;
using Unity.VisualScripting;
using UnityEngine;

public class Brick : MonoBehaviour
{
    GameManager gm;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject o = GameObject.FindGameObjectWithTag("GameController");
        gm = o.GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "Ball")
        {
            Destroy(this.gameObject);
            
            //Comunicate with GameManager
            gm.AddScore(1);
            gm.BreakBrick();
        }
    }
}
