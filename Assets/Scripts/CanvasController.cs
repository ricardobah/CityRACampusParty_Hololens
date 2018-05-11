using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public static class CanvasController 
    {

        private static Object CanvasMeni;
        private static Object CanvasTurismo;
        private static Object CanvasAluguel;
        private static Object CanvasCarros;
        private static Object CanvasRestaurantes;
        private static Object CanvasEventos;
        private static Object CanvasNoticias;
        private static Object instanciado;


        public static void CarregarCanvas()
        {
            CanvasMeni = Resources.Load("CanvasMeni") ;
            CanvasTurismo = Resources.Load("CanvasTurismo");
            CanvasAluguel = Resources.Load("CanvasAluguel");
            CanvasCarros = Resources.Load("CanvasCarros");
            CanvasRestaurantes = Resources.Load("CanvasRestaurantes");
            CanvasEventos = Resources.Load("CanvasEventos");
            CanvasNoticias = Resources.Load("CanvasNoticias");
        }

        public static void OnNotification(string param)
        {
            //Debug.Log(param);
            switch (param)
            {
                case "BtnTurismo":
               
                    break;
                case "BtnAluguel":
                    ChangeMaterials.ChangeByTag("Hotel");
                MonoBehaviour.Destroy(GameObject.Find("CanvasMeni").gameObject);
                    break;
                case "BtnCarros":

                    break;
                case "BtnRestaurantes":

                    break;
                case "BtnEventos":

                    break;
                case "BtnNoticias":

                    break;
                case "HotelTulipa":
                    instanciado=Resources.Load("CanvasDescriptions/Ajustes1");
                    InstCanvas(instanciado);
                    break;
            }
        }
        public static void InstCanvas(Object inst)
        {
        GameObject.Instantiate(inst, GameObject.Find("CanvasPos").transform.position, new Quaternion(0, 0, 0, 0));
        }
    }
