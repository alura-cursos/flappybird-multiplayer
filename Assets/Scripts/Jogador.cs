using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour
{
    private Carrossel[] cenario;
    private GeradorDeObstaculos obstaculo;
    private Aviao aviao;
    private bool estouMorto;

    private void Start()
    {
        this.cenario = this.GetComponentsInChildren<Carrossel>();
        this.obstaculo = this.GetComponentInChildren<GeradorDeObstaculos>();
        this.aviao = this.GetComponentInChildren<Aviao>();
    }

    public void Desativar()
    {
        this.estouMorto = true;
        this.obstaculo.Parar();
        foreach (var carrossel in this.cenario)
        {
            carrossel.enabled = false;
        }
    }

    public void Ativar()
    {
        if (this.estouMorto)
        {
            this.aviao.Reiniciar();
            this.obstaculo.Recomecar();
            foreach (var carrossel in this.cenario)
            {
                carrossel.enabled = true;
            }
            this.estouMorto = false;
        }
    }

}
