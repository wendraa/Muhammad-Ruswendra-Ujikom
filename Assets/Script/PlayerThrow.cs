using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerThrow : MonoBehaviour
{
    private GameObject throwFood;

    private float speedFood;
    private bool repeatThrow;

    void Update() 
    {
        if (repeatThrow)
        {
            itsFood();
        }
    }

    private void itsFood()
    {
        
    }

    // private void  throwOn (InputValue inputValue)
    // {
    //     repeatThrow = inputValue.isPressed;
    // }

}
