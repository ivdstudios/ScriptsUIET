using UnityEngine;
using System.Collections;

public class PracticeClasses : MonoBehaviour {

	public class Vehicle
	{
		private static int number = 1233; 
		private int SpecialNumberForCustomer; 

		public Vehicle()
		{
			number++; 
			print("The object is being formed " + number);
		}

		public void ChangeNumber(int newNumber)
		{
			SpecialNumberForCustomer = newNumber;
		}
	}

	void Start () {

		Vehicle an = new Vehicle() ;  
		Vehicle ann = new Vehicle(); 

		ann.ChangeNumber(1); 

	}

}
