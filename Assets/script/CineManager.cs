using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;


public class CineManager : MonoBehaviour
{
   
   public static CineManager instance = null;


   [SerializeField]
   private Vector3 TapeSpeed = new Vector3(-2f, 0f, 0f);
     
    [SerializeField]
    
   private Transform Tape = null;


public UIComponents uIComponents;

SceneData sceneData = new SceneData();

void Awake () {
Assert.IsNotNull(Tape);
if (instance == null){
    instance = this;}
}

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Tape.position = Tape.position + TapeSpeed * Time.deltaTime;
        DisplayHudData();
    }

    public void IncrementCoinCount () {
        sceneData.coinCount++;
    }

    void DisplayHudData(){

        uIComponents.hud.txtCoinCount.text = "x " + sceneData.coinCount;
    }

    public void SetTapeSpeed (float value){
        TapeSpeed = new Vector3(value, TapeSpeed.y, TapeSpeed.z);
    }
}
