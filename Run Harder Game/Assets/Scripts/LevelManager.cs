using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
	public int coins;
	public Text coinText;

    // Start is called before the first frame update
    void Start()
    {
    	coinText.text = "Score: " + coins; //displays empty score at start of game
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddCoins(int numberOfCoins)
    {
    	coins+=numberOfCoins;
    	coinText.text = "Score: " + coins; //displays updated score

    }
}
