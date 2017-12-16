using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public float velocidade;

    // Use this for initialization
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.up * velocidade;
    }

    void OnCollisionEnter2D(Collision2D c)
    {
        if (c.gameObject.name == "baseblock")
        {
            // Calculate posição onde bola acertou base.
            float x = AcertouBase(transform.position, c.transform.position, c.collider.bounds.size.x);

            // Calculate direção e seta tamanho pra 1.
            Vector2 direcao = new Vector2(x, 1).normalized;

            // Redefine direção da bola.
            GetComponent<Rigidbody2D>().velocity = direcao * velocidade;
        }
    }

    float AcertouBase(Vector2 bolaPosicao, Vector2 basePosicao, float tamanhoBase)
    {
        /*
         *  1  -0.5  0  0.5   1  <- x value
         *  ===================  <- baseBlock
         */
        return ((bolaPosicao.x - basePosicao.x) / tamanhoBase);
    }

}
