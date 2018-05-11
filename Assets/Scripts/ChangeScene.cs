using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {

    public string scene;
	void Start () {
        /*if (SceneManager.GetActiveScene().name == "Meni" && scene=="Main")
        {
            MeniToMain();
        }*/
	}
	
    public void MeniToMain()
    {
        CanvasController.CarregarCanvas();
        SceneManager.LoadScene(scene);
    }
	// Update is called once per frame
	void Update () {
		
	}
}
