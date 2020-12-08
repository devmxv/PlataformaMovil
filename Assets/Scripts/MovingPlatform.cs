using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    //---Variables de posición de marcadores
    public Transform position1;
    public Transform position2;

    //---Valor de velocidad
    [SerializeField] float moveSpeed = 3f;

    bool moveRight = true;

    // Update is called once per frame
    void Update()
    {
        //---Si posición de plataforma supera a posición de position2, entonces tiene que moverse a la izquierda
        if(transform.position.x > position2.position.x)
        {
            moveRight = false;
        } //---Desplazamiento a la derecha
        if(transform.position.x < position1.position.x)
        {
            moveRight = true;
        }

        //---Desplazamiento de la plataforma
        if (moveRight)
        {
            transform.position = new Vector2(transform.position.x + moveSpeed * Time.deltaTime, transform.position.y);
        } else
        {
            transform.position = new Vector2(transform.position.x - moveSpeed * Time.deltaTime, transform.position.y);
        }
        
    }


}
