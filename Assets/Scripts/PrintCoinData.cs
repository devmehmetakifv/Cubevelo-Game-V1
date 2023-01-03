using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrintCoinData : MonoBehaviour
{
    coinDataManager cDManager;
    public Text coinArea1,coinArea2,coinArea3,coinArea4,coinArea5;
    void Start(){
        cDManager = FindObjectOfType<coinDataManager>();
    }
    void Update(){
        PrintOutTimeData();
    }
    public void PrintOutTimeData(){
        coinArea1.text = cDManager.ReceiveCoinData(1);
        coinArea2.text = cDManager.ReceiveCoinData(2);
        coinArea3.text = cDManager.ReceiveCoinData(3);
        coinArea4.text = cDManager.ReceiveCoinData(4);
        coinArea5.text = cDManager.ReceiveCoinData(5);
    }
}
