using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gol : MonoBehaviour
{
    public bool golDoJogador1;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(golDoJogador1)
        {
            FindObjectOfType<GameManager>().AumentarPontuacaoJogador2();
            other.gameObject.transform.position = Vector2.zero;
        }
        else
        {
            FindObjectOfType<GameManager>().AumentarPontuacaoJogador1();
            other.gameObject.transform.position = Vector2.zero;
        }
    }
}
