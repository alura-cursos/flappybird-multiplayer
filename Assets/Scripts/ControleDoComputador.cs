using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleDoComputador : MonoBehaviour {
    [SerializeField]
    private float intervalo;
    private Aviao aviao;
  
    private void Start () {
        this.aviao = this.GetComponent<Aviao>();
        StartCoroutine(this.Impulsionar());
	}

    private IEnumerator Impulsionar()
    {
        while (true)
        {
            yield return new WaitForSeconds(intervalo);
            this.aviao.DarImpulso();
        }
    }
}
