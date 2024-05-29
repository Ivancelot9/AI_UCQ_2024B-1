using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentMovement : MonoBehaviour
{
    public Vector3 MovementDirection = Vector3.forward;
    void Start()
    {
        if(MovementDirection.magnitude == 0.0f)
        {
            Debug.LogError(message: "ERROR, SE TRATO DE NORMALIZAR UN VECTOR 0");
        }
        else
        {
            MovementDirection = MovementDirection.normalized;
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        //transform position es la posicion del gameobject dueño de este script
        //Sumando a esa posicion la direccion de movimiento
        transform.position += MovementDirection * Time.deltaTime;
    }

     void OnDrawGizmos()
    {
        MovementDirection = MovementDirection.normalized;
        Gizmos.DrawLine(transform.position,transform.position + MovementDirection * 10000f);
    }
}

