using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour
{

    public GameObject[] cards; //the array itself; an array of game objects/cards


    // Start is called before the first frame update
    void Start()
    {

    }
    void onClick(){

    }

    // Update is called once per frame
    void Update()
    {
    	var hit=RaycastHit;
    	var ray=Camera.main.ScreenPointToRay(input.mousePosition);
    	for (int i=0;i<cards.length-1;i++){
    		if(Input.GetMouseButtonDown(0)){
    			if(Physics.Raycast(ray,hit)){
    				if(hit.transform.object=cards[i]){
    					if(cards[i].transform.position.x<1){
    					while (cards[i].transform.position.x<1){
    				}
    				}else if(cards[i].transform.position.x==1){
    					while (cards[i].transform.position.x>0){
    				}
    			}
    				}
    			}
    				

    		}
    	}
	}

}

