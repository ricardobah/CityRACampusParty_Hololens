using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TesteCube : MonoBehaviour {

    private void Start()
    {
        ChangeByTag("Hotel",  Color.yellow);
        ChangeByTag("Shopping",Color.red);
        ChangeByTag("Restaurante", Color.blue);
        //ChangeByTag("Hotel", Color.black);
        ChangeByTag("Aluguel", Color.green);
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
