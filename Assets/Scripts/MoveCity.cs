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

    public void OnInputClicked(InputClickedEventData eventData)
    {
        City = Resources.Load("City") as GameObject;
        Instantiate(City, GameObject.Find("Cursor").transform.position, new Quaternion(0, 0, 0, 0));
        Instantiate(Resources.Load("CanvasDescriptions/Ajustes") as GameObject, new Vector3(0,0,111), new Quaternion(0,0,0,0));
        Destroy(this.gameObject);

    }

   

}
