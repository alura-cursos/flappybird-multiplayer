using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiretorMultiplayer : Diretor {

    private Jogador[] jogadores;
    private bool alguemMorto;
    private int pontosDesdeAMorte;

    protected override void Start()
    {
        base.Start();
        this.jogadores = GameObject.FindObjectsOfType<Jogador>();
    }

    public void AvisarQueAlguemMorreu()
    {
        this.alguemMorto = true;
        this.pontosDesdeAMorte = 0;
    }
    public void ReviverSePrecisar()
    {
        if (this.alguemMorto)
        {
            this.pontosDesdeAMorte++;
            if(this.pontosDesdeAMorte >= 2)
            {
                this.ReviverJogadores();
            }
        }
    }

    private void ReviverJogadores()
    {
        this.alguemMorto = false;
        foreach(var jogador in this.jogadores)
        {
            jogador.Ativar();
        }
    }
}
