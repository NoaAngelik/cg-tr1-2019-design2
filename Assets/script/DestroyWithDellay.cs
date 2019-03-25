using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWithDellay : MonoBehaviour
{
    // Start is called before the first frame update
   
   public float delay = 3f;

   
    void Start()
    {
        Destroy(gameObject, delay);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
