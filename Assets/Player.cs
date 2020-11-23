using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //create a variable to save name
    //variable age
    //speed
    //health
    //score
    //collected all keys
    //ammo
    public string playerName = "Duke Nukem";
    public int age = 30;
    public float speed = 22.1f;
    public float health = 85.5f;
    public int myScore = 39;
    public bool hasAllKeys = false;
    public int ammo = 40;
        
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("My name is: " + playerName);
        Debug.Log("I am " + age + "years old");
        Debug.Log("My speed is: " + speed);
        Debug.Log("I have " + health + "HP");
        Debug.Log("My score is: " + myScore);
        Debug.Log("I have all the keys is: " + hasAllKeys);
        Debug.Log("I have " + ammo + "bullets");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
