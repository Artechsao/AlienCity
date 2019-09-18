using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JewelController : MonoBehaviour {

    /*Verifica as colisões da pedra*/
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player") //se quem colidiu com a pedra é o jogador, então troca a pedra de posição.
        {
            if (transform.position.x == -5)
            {
                transform.position = new Vector3(5, -3f);
            }
            else
            {
                transform.position = new Vector3(-5, -3f);
            }
            
        }
    }
}
