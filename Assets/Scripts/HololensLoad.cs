using HoloToolkit.Unity.InputModule;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class HololensLoad : MonoBehaviour, IInputClickHandler{

    public GameObject sceneManager;
    private Transform transf;
 
	void Start () {

        transf = this.gameObject.GetComponent<Transform>();
        
    }

    // chamar o sceneManager p trocar de cena após click no hololens

   
    public void OnInputClicked(InputClickedEventData eventData)
    {
        sceneManager.GetComponent<ChangeScene>().MeniToMain();
    }

    void FixedUpdate () {
        transf.Rotate(new Vector3(0,transf.rotation.y + 30,0) * Time.deltaTime);
  	}
}
