using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrumRollTrigger : MonoBehaviour {
   [SerializeField] AudioSource DrumRoll;

    [SerializeField]
    AudioSource BackgroundMusic;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    { DrumRoll.volume = Mathf.Lerp(0, 1, 0.1f);
        BackgroundMusic.volume = Mathf.Lerp(0.2f, 0.001f, 0.1f);
    }
}
