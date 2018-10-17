using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PontoBehaviourScript : MonoBehaviour {

    public float speed;
    float directionX;
    float directionY;
    float timer;

    private bool faceRight;

    public Animator animator;

	// Use this for initialization
	void Start () {
        timer = 0f;
        faceRight = true;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        animator.SetFloat("Speed",Mathf.Abs(directionX));
        animator.SetFloat("VerticalSpeed", Mathf.Abs(directionY));
        
        

        directionX = Input.GetAxis("Horizontal");
        directionY = Input.GetAxis("Vertical");

        transform.Translate(new Vector2(directionX, directionY) * speed * Time.deltaTime);

        Flip(directionX);

        timer += Time.deltaTime;
	}

    private void Flip(float directionX)
    {
        if(directionX > 0 && !faceRight || directionX<0 && faceRight)
        {
            faceRight = !faceRight;

            Vector3 scale = transform.localScale;

            scale.x *= -1;
            transform.localScale = scale;
        }
    }
}
