using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiretorMultiplayer : Diretor {

    private bool alguemMorto;
    private int pontosDesdeAMorte;

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
        }
    }
}
