using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AtivarJogadorComAnimacao : MonoBehaviour {
    [SerializeField]
    private UnityEvent aoTerminarAnimacao;
    public void AtivarJogador()
    {
        this.aoTerminarAnimacao.Invoke();
    }
}
