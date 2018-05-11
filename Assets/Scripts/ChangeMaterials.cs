using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;
public static  class ChangeMaterials{

   
    private static Material[] list;
   

    public static void  ChangeByTag(string tag)
    {
        GameObject[] a = GameObject.FindGameObjectsWithTag(tag);
        foreach(GameObject b in a)
        {
            list = b.GetComponent<MeshRenderer>().materials;
            Debug.Log(list.Length);
            foreach (Material t in list)
            {
                t.color = Color.yellow;
            }
        }

    }
}
