﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CineManager : MonoBehaviour
{
    // Start is called before the first frame update
   [SerializeField]
   private Vector3 TapeSpeed = new Vector3(-2f, 0f, 0f);
     
    [SerializeField]
    
   private Transform Tape = null;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Tape.position = Tape.position + TapeSpeed * Time.deltaTime;
        
    }
}
