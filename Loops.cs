using UnityEngine;
using System.Collections;

public class Loops : MonoBehaviour {

	int variable = 32; 

	int[] array = {2,234, 3, 45, 4}; 

	void Start () {
	 /*
		while(variable < 40)
		{
			variable++; 
			if(variable < 34){
				continue; 
			}

			print("Hello this will run until 40"); 
			//variable++;  // variable = variable + 1; 
			// variable+=2 // variable = variable + 2 ; 

		}
		*/

		/*
		for(int i=0; i< 10; ++i)
		{
			print("Value of loop is " + i); 
		}

		*/

		/*
		do{
			print("Chalega hi chalega"); 
		}while(variable < 32);
		*/

		foreach(int variable in array)
		{
			print("Value inside of our array is " + variable); 
		}


		// i++   i = i + 1
		// ++i   i + 1 = i 
		 


		// variable = i++
		// variable = ( i = i + 1 )


		// variable = ++i
		// variable = (i + 1 = i ) 
	}

}
