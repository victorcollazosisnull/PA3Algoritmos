using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    public Vector2 Posicion { get; set; }
    public DoublyLinkedCircularList<Node> Adyacentes { get; set; }

    public Node(Vector2 posicion)
    {
        Posicion = posicion;
        Adyacentes = new DoublyLinkedCircularList<Node>();
    }

   
    public void AddNeighbor(Node neighbor)
    {
        Adyacentes.InsertAtEnd(neighbor);
    }

}

