﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pizzaMinus : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        if (pizzaBox.currentPrice > 0)
        {
                pizzaBox.currentPrice -= 1.99;
                summaryBox.updatePrice();
        }   
    }
}
