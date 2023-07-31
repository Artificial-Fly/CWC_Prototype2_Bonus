using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Globals : MonoBehaviour
{
    public int lives;
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        lives = 30;
        Debug.Log("SCORE: "+ score);
        Debug.Log("LIVES: "+ lives);
    }

    // Update is called once per frame
    void Update()
    {
        if(lives<=0){
            Debug.Log("GAME OVER");
        }
    }
}
