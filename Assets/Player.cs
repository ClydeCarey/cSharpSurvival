using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int easyDifficulty = 0;
    public int mediumDifficulty = 1;
    public int hardDifficulty = 2;
    public int currentDifficulty = 1;

    
    void Start()
    {
        currentDifficulty = mediumDifficulty;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //if score >= 50
    

    //then print "you are awesome"
}
