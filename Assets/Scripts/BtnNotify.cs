using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnNotify : MonoBehaviour {

	
	public void NotifyOnClick()
    {
        CanvasController.OnNotification(this.gameObject.name);
    }
}
