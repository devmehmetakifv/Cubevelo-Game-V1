using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class timeDataManager : MonoBehaviour
{
    int levelIndex;
    string timeData1,timeData2,timeData3,timeData4,timeData5;
    public List<string> dataList;

    void Start(){
        dataList = new List<string>();
        levelIndex = SceneManager.GetActiveScene().buildIndex;
    }
    public void AddTimeData(Text timeData, int levelBuildIndex){
        switch(levelBuildIndex){
            case 1:
                timeData1 = timeData.text;
                dataList.Add(timeData1);
            break;
            case 2:
                timeData2 = timeData.text;
                dataList.Add(timeData2);
            break;
            case 3:
                timeData3 = timeData.text;
                dataList.Add(timeData3);
            break;
            case 4:
                timeData4 = timeData.text;
                dataList.Add(timeData4);
            break;
            case 5:
                timeData5 = timeData.text;
                dataList.Add(timeData5);
            break;
        }
    }
    public string ReceiveTimeData(int levelOrder){
        if(levelOrder == 1)
            return dataList[0];
        else if(levelOrder == 2)
            return dataList[1];
        else if(levelOrder == 3)
            return dataList[2];
        else if(levelOrder == 4)
            return dataList[3];
        else if(levelOrder == 5)
            return dataList[4];
        else
            return "NULL";
    }
}
