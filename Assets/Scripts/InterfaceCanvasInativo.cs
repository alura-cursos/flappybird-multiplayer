using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InterfaceCanvasInativo : MonoBehaviour {
    [SerializeField]
    private GameObject fundo;
    [SerializeField]
    private Text texto;
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

    public void Sumir()
    {
        this.fundo.SetActive(false);
    }
        
    public void AtualizarTexto(int pontosParaReviver)
    {
        this.texto.text = pontosParaReviver.ToString();
    }
}
