using HoloToolkit.Unity.InputModule;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoCidade : MonoBehaviour,IInputClickHandler {

    
    public void OnInputClicked(InputClickedEventData eventData)
    {
        if (this.gameObject.GetComponent<MeshRenderer>().material.color == Color.yellow)
        {
            CanvasController.OnNotification(this.gameObject.tag);
            Debug.Log(this.gameObject.name);
        }
    }
}
