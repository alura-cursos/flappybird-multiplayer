using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleDoComputador : MonoBehaviour {
    private Aviao aviao;
  
    private void Start () {
        this.aviao = this.GetComponent<Aviao>();
        StartCoroutine(this.Impulsionar());
	}

    private IEnumerator Impulsionar()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.5f);
            this.aviao.DarImpulso();
        }
    }
}
