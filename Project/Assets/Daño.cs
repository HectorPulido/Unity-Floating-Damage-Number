using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Daño : MonoBehaviour {

    public Animator anim;
    public GameObject numeroPrefab;

    void InstanciarNumero()
    {
        GameObject go = Instantiate(numeroPrefab, transform.position + Random.onUnitSphere *0.5f, Quaternion.identity) as GameObject;
        go.GetComponent<Numero>().Inicializar(Random.Range(1, 10));
    }

    void OnMouseDown()
    {
        anim.SetTrigger("Daño");
        InstanciarNumero();
    }
}
