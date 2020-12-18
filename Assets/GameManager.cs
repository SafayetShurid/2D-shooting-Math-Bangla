using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public int Score = 0;
    public static GameManager instance;

    private void Awake()
    {
        if(instance!=null)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ScoreUp(Number number)
    {
        Score = Score + 5;//number.Value;
    }

    public void BonusScoreUp(Number number)
    {
        Score = Score + 10;//(number.Value*2);
    }
}
