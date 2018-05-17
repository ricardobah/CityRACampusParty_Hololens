using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;
public static  class ChangeMaterials{

   
    private static Material[] list;

    private static List<Color> colorList = new List<Color>();
    public static void  ChangeByTag(string tag,Color newColor)
    {
        GameObject[] a = GameObject.FindGameObjectsWithTag(tag);
        foreach(GameObject b in a)
        {
            list = b.GetComponent<MeshRenderer>().materials;
            Debug.Log(list.Length); 
                foreach(Material t in list)
            {
                colorList.Add(t.color);
              
            }
            foreach (Material t in list)
            {
              
                t.color = newColor;
            }
        }

    }
    public static void removeColor()
    {
        int i = 0;
        if (list != null)
        {
            foreach (Material a in list)
            {
                a.color = colorList[i];
                i++;
            }
            colorList.Clear();
        }
       
    }
}
