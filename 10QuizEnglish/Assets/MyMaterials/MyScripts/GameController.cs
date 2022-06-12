using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Text ScoreText;
    
    // Start is called before the first frame update
    void Start()
    {
        ScoreText.text = "SCORE :" + CreateQBorad1.GameScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
