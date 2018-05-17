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
        private static GameObject canvasAtual;
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
    private static GameObject[] Canvlist;
        public static void OnNotification(string param)
        {
            //Debug.Log(param);
            switch (param)
            {
                case "BtnTurismo":
                    ChangeMaterials.ChangeByTag("Turismo", Color.yellow);
                    MonoBehaviour.Destroy(GameObject.Find("CanvasMeni(Clone)").gameObject);
                    instanciado = Resources.Load("CanvasDescriptions/CanvasBack");
                    InstCanvas(instanciado);
                break;

                case "BtnAluguel":
                    ChangeMaterials.ChangeByTag("Aluguel", Color.yellow);
                    ChangeMaterials.ChangeByTag("Hotel",Color.yellow);
                    MonoBehaviour.Destroy(GameObject.Find("CanvasMeni(Clone)").gameObject);
                    instanciado = Resources.Load("CanvasDescriptions/CanvasBack");
                    InstCanvas(instanciado);
                break;

                case "BtnCarros":
                instanciado = Resources.Load("CanvasDescriptions/Infos/aluguel_carro");
                InstCanvas(instanciado);
                MonoBehaviour.Destroy(GameObject.Find("CanvasMeni(Clone)").gameObject);
                    instanciado = Resources.Load("CanvasDescriptions/CanvasBack");
                    InstCanvas(instanciado);
                break;

                case "BtnRestaurantes":
                      ChangeMaterials.ChangeByTag("Restaurante", Color.yellow);
                     MonoBehaviour.Destroy(GameObject.Find("CanvasMeni(Clone)").gameObject);
                    instanciado = Resources.Load("CanvasDescriptions/CanvasBack");
                    InstCanvas(instanciado);
                break;

              

                case "BtnNoticias":
                instanciado = Resources.Load("CanvasDescriptions/Infos/canvas_Noticias");
                InstCanvas(instanciado);
                MonoBehaviour.Destroy(GameObject.Find("CanvasMeni(Clone)").gameObject);
                    instanciado = Resources.Load("CanvasDescriptions/CanvasBack");
                    InstCanvas(instanciado);
                break;       

                case "BtnBack":
                    Canvlist = GameObject.FindGameObjectsWithTag("Banco");  
                    foreach(GameObject a in Canvlist)
                    {
                        MonoBehaviour.Destroy(a);
                    }
                Debug.Log("asdasdasdasdas");
                    ChangeMaterials.removeColor();
                    instanciado = Resources.Load("CanvasDescriptions/CanvasMeni");
                    InstCanvas(instanciado);
                    MonoBehaviour.Destroy(GameObject.Find("CanvasBack(Clone)"));
                break;
                case "Hotel":
               
                    instanciado = Resources.Load("CanvasDescriptions/Infos/Hotel");
                    InstCanvas(instanciado);
                break;
            case "Aluguel":

                instanciado = Resources.Load("CanvasDescriptions/Infos/Alugar");
                InstCanvas(instanciado);
                break;
            case "Restaurante":

                instanciado = Resources.Load("CanvasDescriptions/Infos/PIZZA_DOREAS");
                
                InstCanvas(instanciado);
                break;
            case "Turismo":
          

                instanciado = Resources.Load("CanvasDescriptions/Infos/evento");
                InstCanvas(instanciado);
                
                break;

        }
        }
        public static void InstCanvas(Object inst)
        {    
            GameObject.Instantiate(inst, GameObject.Find("CanvasPos").transform.position, new Quaternion(0, 0, 0, 0));
        }

        
    }
