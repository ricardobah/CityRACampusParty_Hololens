using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;
using HoloToolkit;
public class SetPositionCity : MonoBehaviour
{

    private double auxX, auxY, auxZ;
   
    private GameObject canvasMeni,city;
    bool inst = false;

	void Start () {

        city = GameObject.Find("City(Clone)");
        canvasMeni = GameObject.Find("CanvasMeni");
	}



        public void OnClickUp()
        {
       
            auxX = city.transform.localScale.x + city.transform.localScale.x * 0.1;
            auxY = city.transform.localScale.y + city.transform.localScale.y * 0.1;
            auxZ = city.transform.localScale.z + city.transform.localScale.z * 0.1;
            city.transform.localScale= new Vector3((float)auxX,(float)auxY,(float)auxZ);
           // City.transform.localScale= new Vector3(2,2,2);
        }

    public void OnClickDown()
    {
       
        auxX = city.transform.localScale.x - city.transform.localScale.x * 0.1;
        auxY = city.transform.localScale.y - city.transform.localScale.y * 0.1;
        auxZ = city.transform.localScale.z - city.transform.localScale.z * 0.1;
        city.transform.localScale= new Vector3((float)auxX, (float)auxY, (float)auxZ);
    }

    public void OnClickFinish()
    {
        foreach (Transform child in canvasMeni.transform)
        {
            child.gameObject.SetActive(true);
        }
        
        Destroy(this.gameObject);
    }
}
