using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    //name
    //description
    //image
    //attack strength

    public string itemName = "Sword";
    public string itemDescription = "A stout one handed sword";
    public Sprite _swordSprite;
    public float attackStrength = 32.0f;



    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Item name" + itemName);
        
    }

}
