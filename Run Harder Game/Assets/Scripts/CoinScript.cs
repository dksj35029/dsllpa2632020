using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{

    private LevelManager gameLevelManager;
    public int coinValue;

    public int score = 0;


    // Start is called before the first frame update
    void Start()
    {
        gameLevelManager = FindObjectOfType<LevelManager>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other) //when the player collides with the coin
    {
        gameLevelManager.AddCoins(coinValue); //updates the scoore method
        Destroy(gameObject);
        score++;
        Debug.Log("Score is: " + score);

    }
}
