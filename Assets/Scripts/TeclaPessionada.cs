using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeclaPessionada : MonoBehaviour {
    [SerializeField]
    private KeyCode tecla;
    private Aviao aviao;

    private void Start () {
        this.aviao = this.GetComponent<Aviao>();	
	}
	
	private void Update () {
        if (Input.GetKeyDown(this.tecla))
        {
            this.aviao.DarImpulso();
        }
	}
}
