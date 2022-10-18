using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothLookAt : MonoBehaviour
{
    public GameObject Objeto;
    // Start is called before the first frame update
    private void Awake()
    {
        Objeto = GameObject.Find("ObjetoVer");
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 posJugador = transform.position;
        Vector3 posObjeto = Objeto.transform.position;

        Vector3 posRelativa = posObjeto - posJugador;

        Quaternion rotacion = Quaternion.LookRotation(posRelativa, Vector3.up);

        transform.rotation = Quaternion.Slerp(transform.rotation, rotacion, 1 * Time.deltaTime);
    }
}
