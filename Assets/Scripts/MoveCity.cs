using HoloToolkit.Unity.InputModule;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCity : MonoBehaviour, IInputClickHandler
{
    private GameObject City;

    private void Start()
    {
        InputManager.Instance.PushFallbackInputHandler(gameObject);
    }

    GameObject city;
    private double auxX, auxY, auxZ;
    Object instanciado;
    public void OnInputClicked(InputClickedEventData eventData)
    {
        City = Resources.Load("City") as GameObject;
        city= Instantiate(City, GameObject.Find("Cursor").transform.position, new Quaternion(0, 0, 0, 0));
        auxX = city.transform.localScale.x - city.transform.localScale.x * 0.1;
        auxY = city.transform.localScale.y - city.transform.localScale.y * 0.1;
        auxZ = city.transform.localScale.z - city.transform.localScale.z * 0.1;
        city.transform.localScale = new Vector3((float)auxX, (float)auxY, (float)auxZ);
        instanciado = Resources.Load("CanvasDescriptions/CanvasMeni");
        CanvasController.InstCanvas(instanciado);
        Destroy(this.gameObject);
       

    }

   

}
