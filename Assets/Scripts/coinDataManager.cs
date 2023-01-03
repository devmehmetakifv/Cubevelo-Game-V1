using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class coinDataManager : MonoBehaviour
{
    int levelIndex;
    string coinData1,coinData2,coinData3,coinData4,coinData5;
    public List<string> coinDataList;

    void Start(){
        coinDataList = new List<string>();
        levelIndex = SceneManager.GetActiveScene().buildIndex;
    }
    public void AddCoinData(Text coinData, int levelBuildIndex){
        switch(levelBuildIndex){
            case 1:
                coinData1 = coinData.text;
                coinDataList.Add(coinData1);
            break;
            case 2:
                coinData2 = coinData.text;
                coinDataList.Add(coinData2);
            break;
            case 3:
                coinData3 = coinData.text;
                coinDataList.Add(coinData3);
            break;
            case 4:
                coinData4 = coinData.text;
                coinDataList.Add(coinData4);
            break;
            case 5:
                coinData5 = coinData.text;
                coinDataList.Add(coinData5);
            break;
        }
    }
    public string ReceiveCoinData(int levelOrder){
        if(levelOrder == 1)
            return coinDataList[0];
        else if(levelOrder == 2)
            return coinDataList[1];
        else if(levelOrder == 3)
            return coinDataList[2];
        else if(levelOrder == 4)
            return coinDataList[3];
        else if(levelOrder == 5)
            return coinDataList[4];
        else
            return "NULL";
    }
}
