using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonControl : MonoBehaviour
{
    
    
    
    public void PointerEnter(){
        transform.localScale = new Vector2(1.2f,1.2f);
    }


    
    public void PointerExit()
    {
        transform.localScale = new Vector2(1f,1f);
    }
}
