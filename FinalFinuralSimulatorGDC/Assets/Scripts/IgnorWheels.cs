using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnorWheels : MonoBehaviour {
    [SerializeField]
    Collider Streetcone;
    [SerializeField]
    Collider Wheel1;
    [SerializeField]
    Collider Wheel2;
    [SerializeField]
    Collider Wheel3;
    [SerializeField]
    Collider Wheel4;

    // Use this for initialization
    void Start ()
    {

        //Transform bullet = Instantiate(bulletPrefab) as Transform;
        Physics.IgnoreCollision(Streetcone.GetComponent<Collider>(), Wheel1.GetComponent<Collider>());
        Physics.IgnoreCollision(Streetcone.GetComponent<Collider>(), Wheel2.GetComponent<Collider>());
        Physics.IgnoreCollision(Streetcone.GetComponent<Collider>(), Wheel3.GetComponent<Collider>());
        Physics.IgnoreCollision(Streetcone.GetComponent<Collider>(), Wheel4.GetComponent<Collider>());
        

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
