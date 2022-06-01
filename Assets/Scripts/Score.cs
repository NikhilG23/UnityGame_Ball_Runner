using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text ScoreText;
    public int myscore=0;
    public Text finalScoreText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = myscore.ToString();
        finalScoreText.text ="Score: "+myscore.ToString();
    }
    public void AddScore(int score)
    {
        myscore = myscore + score;
    }
}
