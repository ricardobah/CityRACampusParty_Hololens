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
        ChangeByTag("Locadora", Color.black);
    }

    private Material[] list;

    public void ChangeByTag(string tag, Color color)
    {
        GameObject[] a = GameObject.FindGameObjectsWithTag(tag);
        foreach (GameObject b in a)
        {
            list = b.GetComponent<MeshRenderer>().materials;
            Debug.Log(list.Length);
            foreach (Material t in list)
            {
                
                t.color = color;
            }
        }

    }
}
