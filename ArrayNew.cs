using UnityEngine;
using System.Collections;

public class ArrayNew : MonoBehaviour {

	// int arr[] = { 234, 234, 234, 234 }; 

	int[] arr = {3,435 ,46, 45, 456,};

	int[] arr1 = new int[5]; 

	//if-else 

	int moveSpeed = 34; 

	void Start()
	{
		if(Input.GetKey(KeyCode.UpArrow))
		{
			transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime); 
		}
		if(Input.GetKey(KeyCode.UpArrow))
		{
			
		}
	}
}
