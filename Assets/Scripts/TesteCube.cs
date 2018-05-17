using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TesteCube : MonoBehaviour {

    private void Start()
    {
        ChangeByTag("Hotel",  Color.yellow);
        ChangeByTag("Shopping",Color.red);
        ChangeByTag("Restaurante", Color.blue);
        ChangeByTag("Casa", Color.green);
        ChangeByTag("Aluguel", Color.green);
        ChangeByTag("Loja", Color.red);
        ChangeByTag("Banco", Color.magenta);
        ChangeByTag("Turismo", Color.black);
    }

    private Material[] list;

    public void ChangeByTag(string tag, Color color)
    {
        GameObject[] a = GameObject.FindGameObjectsWithTag(tag);
        Debug.Log(tag + " " + a.Length);
        foreach (GameObject b in a)
        {
            list = b.GetComponent<MeshRenderer>().materials;
            
            foreach (Material t in list)
            {
                
                t.color = color;
            }
        }

    }
}