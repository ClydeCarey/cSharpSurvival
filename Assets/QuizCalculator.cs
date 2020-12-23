using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizCalculator : MonoBehaviour
{
    public float quiz1;
    public float quiz2;
    public float quiz3;
    public float quiz4;
    public float quiz5;
    //create random quiz values for 5 quiz grades and print average

    // Start is called before the first frame update
    void Start()
    {
        quiz1 = Random.Range(0.0f, 100.0f);
        quiz2 = Random.Range(0.0f, 100.0f);
        quiz3 = Random.Range(0.0f, 100.0f);
        quiz4 = Random.Range(0.0f, 100.0f);
        quiz5 = Random.Range(0.0f, 100.0f);

        Debug.Log("Grade 1: " + quiz1 + "Grade 2: " + quiz2 + "Grade 3: " + quiz3 + "Grade 4: " + quiz4 + "Grade 5: " + quiz5);
        float averageScore = ((quiz1 + quiz2 + quiz3 + quiz4 + quiz5) / 5);
        averageScore = Mathf.Round(averageScore * 100.0f) / 100.0f;

        Debug.Log("the average score is: " + averageScore );

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
