using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pila<T>
{
    private Stack<T> stack = new Stack<T>();
    public void Push(T item)
    {
        stack.Push(item);
        Debug.Log("Elemento añadido: " + item);
    }
    public T Pop()
    {
        if (stack.Count > 0)
        {
            T item = stack.Pop();
            Debug.Log("Elemento retirado: " + item);
            return item;
        }
        else
        {
            Debug.LogWarning("La pila está vacía.");
            return default(T);
        }
    }

    public T Peek()
    {
        if (stack.Count > 0)
        {
            T item = stack.Peek();
            Debug.Log("Elemento en la cima: " + item);
            return item;
        }
        else
        {
            Debug.LogWarning("La pila está vacía.");
            return default(T);
        }
    }

    public bool IsEmpty()
    {
        return stack.Count == 0;
    }

    public void Clear()
    {
        stack.Clear();
        Debug.Log("Pila vaciada.");
    }
}

