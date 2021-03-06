﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diretor : MonoBehaviour
{
    public GameObject imagemGameOver;

    [SerializeField]

    private AviaoController aviao;

    private Pontuacao pontuacao;

    public void FinalizarJogo()
    {
        Time.timeScale = 0;
        imagemGameOver.SetActive(true);
        Debug.Log("Acabou");
    }

    public void ReiniciarJogo()
    {
        aviao.Reiniciar();
        imagemGameOver.SetActive(false);
        Time.timeScale = 1;
        pontuacao.Reiniciar();
        DestruirObstaculos();
        Debug.Log("Reiniciou");
    }
    void Start()
    {
        aviao = GameObject.FindObjectOfType<AviaoController>();

        pontuacao = GameObject.FindObjectOfType<Pontuacao>();
    }

    private void DestruirObstaculos()
    {
        ObstaculoController[] obstaculosEncontrado = GameObject.FindObjectsOfType<ObstaculoController>();

        foreach (ObstaculoController obstaculosAtual in obstaculosEncontrado)
        {
            obstaculosAtual.Destruir();
        }
    }
}
