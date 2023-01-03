using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrintTimeData : MonoBehaviour
{

    timeDataManager tDManager;
    public Text textArea1,textArea2,textArea3,textArea4,textArea5;
    void Start(){
        tDManager = FindObjectOfType<timeDataManager>();
    }
    void Update(){
        PrintOutTimeData();
    }
    public void PrintOutTimeData(){
        textArea1.text = tDManager.ReceiveTimeData(1);
        textArea2.text = tDManager.ReceiveTimeData(2);
        textArea3.text = tDManager.ReceiveTimeData(3);
        textArea4.text = tDManager.ReceiveTimeData(4);
        textArea5.text = tDManager.ReceiveTimeData(5);
    }
}
