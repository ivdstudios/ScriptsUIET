using UnityEngine;
using System.Collections;

public class Inventory : MonoBehaviour {

	public class GunsNAmmo{
		public int ammo = 3; 
		public int granade = 2; 
		public bool arquebus = false;
		public bool blunderbuss = false; 
		public bool musket = false; 
		public bool rifle = true; 

		public void Purchase(int payment){ // payment = 10
			ammo = ammo + payment; 
			print(ammo); 
		}
	}

	class MeleeWeapon{
		public bool knief = true;
		public bool hammer = false; 
		public bool baseballBat = false; 
		public int boomerang = 4; 
	}

	public GunsNAmmo gnm = new GunsNAmmo(); 
	public GunsNAmmo gnm1 = new GunsNAmmo(); 
	// public MeleeWeapon ml = new MeleeWeapon(); 


	// Use this for initialization
	void Start () {
		print(gnm.ammo);
	
		gnm.Purchase(10);

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
	