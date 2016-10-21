using UnityEngine;
using System.Collections;

public class PropertiesMeri : MonoBehaviour {

	class Bank
	{
		private int amount = 6876; 

		public int Amount{
			get{
				return amount; 
			}
		}


		public Bank()
		{
			print("Ki apka kahata khul gaya hai"); 
		}
	}

	void Start()
	{
		Bank RamVilasPaswan = new Bank(); 
		RamVilasPaswan.Amount = 342; 
		print(RamVilasPaswan.Amount); 
	}
}
