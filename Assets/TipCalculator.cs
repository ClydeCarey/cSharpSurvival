using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipCalculator : MonoBehaviour
{
    //bill is 40 dollars
    //tip is 20% or user amount
    //calculate total
    float bill = 40.0f;
    public float tip = 20f;
    float total;

    // Start is called before the first frame update
    void Start()
    {
        //your bill is, your tip is, so you owe: totalamount
        total = (bill * (tip/100)) + bill;
        Debug.Log("Your bill is " + bill + " Your tip is " + tip + "% Your total is " + total);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
