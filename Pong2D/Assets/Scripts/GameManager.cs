using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int pontoJogador1;
    public int pontoJogador2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AumentarPontuacaoJogador1()
    {
        pontoJogador1 += 1;
    }

    public void AumentarPontuacaoJogador2()
    {
        pontoJogador2 += 1;
    }
}
