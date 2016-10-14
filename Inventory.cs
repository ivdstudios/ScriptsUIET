using UnityEngine;
using System.Collections;

public class Inventory : MonoBehaviour {

	public class GunsNAmmo{
		public int ammo = 3; 
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

	public class Bombs{
		public int granade = 23;
		public int smokeGranade = 2; 
		public int flashBomb = 234; 
		public int mines = 2; 
		public int c4Explosive = 6; 
	}

	public GunsNAmmo gnm = new GunsNAmmo(); 
	public GunsNAmmo gnm1 = new GunsNAmmo(); 
	// public MeleeWeapon ml = new MeleeWeapon(); 
	public Bombs bmb = new Bombs(); 

	// Use this for initialization
	void Start () {
		print(gnm.ammo);
	
		gnm.Purchase(10);

		print(bmb.mines); 
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
	