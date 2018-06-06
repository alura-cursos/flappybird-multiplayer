using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour {
    [SerializeField]
    private VariavelCompartilhadaFloat velocidade;
    [SerializeField]
    private float variacaoDaPosicaoY;
    

    private void Awake()
    {
        this.transform.Translate(Vector3.up * Random.Range(-variacaoDaPosicaoY, variacaoDaPosicaoY));
    }


    private void Update () {
        this.transform.Translate(Vector3.left * this.velocidade.valor * Time.deltaTime);
	}

    private void OnTriggerEnter2D(Collider2D outro)
    {
        if (outro.CompareTag("parede"))
        {
            this.Destruir();
        }
    }

    public void Destruir()
    {
        Destroy(this.gameObject);
    }
}
