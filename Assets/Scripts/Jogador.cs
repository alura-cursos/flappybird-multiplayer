using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour {
    private Carrossel[] cenario;
    private GeradorDeObstaculos obstaculo;

    private void Start()
    {
        this.cenario = this.GetComponentsInChildren<Carrossel>();
        this.obstaculo = this.GetComponentInChildren<GeradorDeObstaculos>();
    }

    public void Desativar()
    {
        this.obstaculo.Parar();
        foreach(var carrossel in this.cenario)
        {
            carrossel.enabled = false;
        }
    }

}
