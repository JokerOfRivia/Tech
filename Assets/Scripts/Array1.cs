using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour
{
    
    public Card[] cards; //the array itself; an array of cards



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //get the mouse position and convert it into world position
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            //convert 3D word pos into 2D wordld pos
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            //create the ray and declare the hit
            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);

            //if the ray hit anything
            if (hit.collider != null)
            {

                //the thing gets hitted has component Card
                if (hit.collider.gameObject.GetComponent<Card>() != null) 
                {
                	if(hit.collider.gameObject.GetComponent<Card>().transform.position.x<1){

                		Vector3 pos=hit.collider.gameObject.GetComponent<Card>().transform.position;
                		float temp=0.2f;
                		pos.x+=temp;
                		transform.position=pos;
                        Debug.Log(hit.collider.gameObject.name);

                    }
                }


                
            }
        }
    }
}
	




