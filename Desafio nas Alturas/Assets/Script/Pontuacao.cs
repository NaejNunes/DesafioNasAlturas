using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pontuacao : MonoBehaviour
{
    [SerializeField]

    private Text textoPontuacao;

    private int pontos;

    private AudioSource somPontuacao;

     void Awake()
    {
        somPontuacao = GetComponent<AudioSource>();

    }
    public void AdicionaPontos()
    {
        pontos += 1;
        somPontuacao.Play();
        AtualizarTexto();
    }

    public void AtualizarTexto()
    {
        textoPontuacao.text = pontos.ToString();
    }

    public void Reiniciar()
    {
        pontos = 0;
        AtualizarTexto();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
