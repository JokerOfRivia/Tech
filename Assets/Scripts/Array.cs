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

    // Update is called once per frame
    void Update()
    {
    	if(Input.GetMouseButtonDown(0))
    	{
    		Ray ray=Camera.main.ScreenPointToRay(input.mousePosition);
    		RaycastHit hit;
    		for (int i=0;i<cards.length-1;i++)
    		{
    			if(Physics.Raycast(ray,out hit))
    			{
    				if(hit.transform.object=cards[i])
    				{
    					if(cards[i].transform.position.x<1)
    					{
    						while (cards[i].transform.position.x<1)
    						{
    							cards[i].transform.position.x+=0.2f;
    						}
    					}
    					else if(cards[i].transform.position.x==1)
    					{
    						while (cards[i].transform.position.x>0)
    						{
    							cards[i].transform.position.x-=0.2f;
    						}
    					}
    				}
    			}
    				

    		}
    	}
	}

}


