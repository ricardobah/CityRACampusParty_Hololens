using UnityEngine;


    public class Indestructible : MonoBehaviour
    {
        private void Awake()
        {
            gameObject.transform.SetParent(null);
            DontDestroyOnLoad(gameObject);
        }
    }
