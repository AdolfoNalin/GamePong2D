using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int pontoJogador1;
    public int pontoJogador2;
    public Text txtPontuacao;
    public AudioSource gol;

    // Start is called before the first frame update
    void Start()
    {
        pontoJogador1 = 0;
        pontoJogador2 = 0;
        txtPontuacao.text = $"{pontoJogador1} x {pontoJogador2}";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AumentarPontuacaoJogador1()
    {
        pontoJogador1 += 1;
        AtualizarPontucao();
    }

    public void AumentarPontuacaoJogador2()
    {
        pontoJogador2 += 1;
        AtualizarPontucao();
    }

    public void AtualizarPontucao()
    {
        txtPontuacao.text = $"{pontoJogador1} x {pontoJogador2}";
        gol.Play();
    }
}
