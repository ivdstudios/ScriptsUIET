using UnityEngine;
using System.Collections;

public class FunctionOverload : MonoBehaviour {

	public int variable = 2;

	// Use this for initialization
	void Start () {
		/*
		if(variable == 3)
		{
			print("this is 2"); 
		}
		else if(variable == 4)
		{
			print("japan is great"); 
		}
		else if(variable == 6)
		{
			print("Sometimes I feel like dying in UIET"); 
		}	
		else{
			print("yaaron ki baarat");
		}*/



	}

	void Update()
	{
		if(Input.GetKey(KeyCode.UpArrow))
		{
			transform.Translate(new Vector3(1.0f, 0.0f, 0.0f) * variable * Time.deltaTime) ;
		}
	
		if(Input.GetKey(KeyCode.DownArrow))
		{
			transform.Translate(-Vector3.forward * variable * Time.deltaTime) ;
		}

		if(Input.GetKey(KeyCode.LeftArrow))
		{
			transform.Rotate(Vector3.left* variable * Time.deltaTime);
		}
		if(Input.GetKey(KeyCode.RightArrow))
		{
			transform.Rotate(-Vector3.left * variable * Time.deltaTime) ;
		}
			
	}

}



/*
 * 
 * new Vector3(1, 0, 0)  -----> Vector3.right
 * new Vector3(-1, 0, 0) -----> Vector3.left
 * new Vector3(0, 1, 0)  ------>  Vector3.up
 * new Vector3(0, -1, 0) -------> Vector3.down
 * new Vector3(0, 0, 1) -------> Vector3.forward
 * new Vector3(0, 0, -1) -------> Vector3.back