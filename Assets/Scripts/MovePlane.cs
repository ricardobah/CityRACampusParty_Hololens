using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlane : MonoBehaviour {

    float inicial;
	void Start () {
        inicial = transform.position.z;
	}

    // Update is called once per frame
    /*
    float timeCounter;
    void Update () {
        timeCounter += Time.deltaTime;
        float x = this.transform.position.x+ Mathf.Cos(timeCounter);
        float z =this.transform.position.z+Mathf.Sin(timeCounter);
       
        transform.position = new Vector3(x, this.transform.position.y, z);
	}*/

    private void Update()
    {
        float newz=this.transform.position.z-Time.deltaTime;
        this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, newz);
       // Debug.Log(newz);
        if (newz <-12)
        {
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, inicial);
        }
    }
}
