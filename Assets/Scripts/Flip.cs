using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flip : MonoBehaviour
{
	public float flipXValue;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    	card1.OnClick();
	
    }
    void OnClick(){
        if(flipXValue<1){
    			flipXValue+=0.2f;
    		}else if(flipXValue==1){
    			flipXValue-=0.2f;
    		}
 	}
}

 


