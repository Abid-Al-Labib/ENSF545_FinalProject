﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class milkshakeMinus : MonoBehaviour
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
        milkshakeBox.currentPrice -= 0.5;
        summaryBox.updatePrice();
    }
}