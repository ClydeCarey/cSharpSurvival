using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{


    public string myName = "jonathan";
    public int myAge = 26;
    public string myLocation = "Atlanta";
    public bool haskey = false;

    // Start is called before the first frame update
    void Start()
    {
        myName = "loren";            
        Debug.Log("My name is: " + myName);
        Debug.Log(myAge);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
