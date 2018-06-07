using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfaceCanvasInativo : MonoBehaviour {
    [SerializeField]
    private GameObject fundo;
    private Canvas canvas;

    private void Awake()
    {
        this.canvas = this.GetComponent<Canvas>();
    }
    
    public void Mostrar(Camera camera)
    {
        this.fundo.SetActive(true);
        this.canvas.worldCamera = camera;
    }
}
