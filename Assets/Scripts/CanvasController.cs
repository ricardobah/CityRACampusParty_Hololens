using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public static class CanvasController 
    {

        private static Object canvasMeni;
        private static Object canvasTurismo;
        private static Object canvasAluguel;
        private static Object canvasCarros;
        private static Object canvasRestaurantes;
        private static Object canvasEventos;
        private static Object canvasNoticias;
        private static Object instanciado;
    private static Object canvasBack;

        public static void CarregarCanvas()
        {
            canvasMeni = Resources.Load("CanvasMeni") ;
            canvasTurismo = Resources.Load("CanvasTurismo");
            canvasAluguel = Resources.Load("CanvasAluguel");
            canvasCarros = Resources.Load("CanvasCarros");
            canvasRestaurantes = Resources.Load("CanvasRestaurantes");
            canvasEventos = Resources.Load("CanvasEventos");
            canvasNoticias = Resources.Load("CanvasNoticias");
        }

        public static void OnNotification(string param)
        {
            //Debug.Log(param);
            switch (param)
            {
                case "BtnTurismo":
                    ChangeMaterials.ChangeByTag("Turismo", Color.yellow);
                    MonoBehaviour.Destroy(GameObject.Find("CanvasMeni").gameObject);
                    instanciado = Resources.Load("CanvasDescriptions/CanvasBack");
                    InstCanvas(instanciado);
                break;

                case "BtnAluguel":
                    ChangeMaterials.ChangeByTag("Hotel",Color.yellow);
                    MonoBehaviour.Destroy(GameObject.Find("CanvasMeni").gameObject);
                    instanciado = Resources.Load("CanvasDescriptions/CanvasBack");
                    InstCanvas(instanciado);
                break;

                case "BtnCarros":
                    MonoBehaviour.Destroy(GameObject.Find("CanvasMeni").gameObject);
                    instanciado = Resources.Load("CanvasDescriptions/CanvasBack");
                    InstCanvas(instanciado);
                break;

                case "BtnRestaurantes":
                    MonoBehaviour.Destroy(GameObject.Find("CanvasMeni").gameObject);
                    instanciado = Resources.Load("CanvasDescriptions/CanvasBack");
                    InstCanvas(instanciado);
                break;

                case "BtnEventos":
                    MonoBehaviour.Destroy(GameObject.Find("CanvasMeni").gameObject);
                    instanciado = Resources.Load("CanvasDescriptions/CanvasBack");
                    InstCanvas(instanciado);
                break;

                case "BtnNoticias":
                    MonoBehaviour.Destroy(GameObject.Find("CanvasMeni").gameObject);
                    instanciado = Resources.Load("CanvasDescriptions/CanvasBack");
                    InstCanvas(instanciado);
                break;       

                case "BtnBack":
                    instanciado = Resources.Load("CanvasDescriptions/CanvasMeni");
                    InstCanvas(instanciado);
                    MonoBehaviour.Destroy(GameObject.Find("CanvasBack"));
                break;
            case "HotelTulipa":
                MonoBehaviour.Destroy(GameObject.Find("CanvasMeni").gameObject);
                instanciado = Resources.Load("CanvasDescriptions/Infos/Ajustes1");
                InstCanvas(instanciado);
                break;
        }
        }
        public static void InstCanvas(Object inst)
        {
            GameObject.Instantiate(inst, GameObject.Find("CanvasPos").transform.position, new Quaternion(0, 0, 0, 0));
        }

        
    }
