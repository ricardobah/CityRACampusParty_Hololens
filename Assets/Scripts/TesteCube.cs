using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TesteCube : MonoBehaviour {

    
	void Start () {
	
	}

    private void OnCollisionEnter(Collision collision)
    {
        print(this.gameObject.name+" no "+ collision.gameObject.name);
        
    }

    // Update is called once per frame
    void Update () {
		
	}
}
