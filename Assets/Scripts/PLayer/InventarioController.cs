using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventarioController : MonoBehaviour
{
    private Pila<SpriteRenderer> miPila;
    public int cant;
    void Start()
    {
        miPila = new Pila<SpriteRenderer>();
        }

    private void Update()
    {
       
    }

}
