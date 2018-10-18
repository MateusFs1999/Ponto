using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash : MonoBehaviour {

    private Rigidbody2D rb;       
    public float speedDash;
    float leesDash = 0f;
    Vector2 direction = new Vector2();
    void Start () {
        rb = GetComponent<Rigidbody2D>();
        
	}	
	
	void Update () {
        Verificando();     
    }

   void Verificando()
    {
        if (Input.GetButtonDown("Fire1"))
        {    
            Vector3 mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

            direction = new Vector2(mousePosition.x - transform.position.x,
                                    mousePosition.y - transform.position.y);

            rb.AddForce(direction * speedDash);

            Debug.Log("Ativado");
        }
        else if(Input.GetButtonUp("Fire1"))
        {
            
            direction = new Vector2();
            rb.AddForce(direction * leesDash);
        }
       

        


    }
}
