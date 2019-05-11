using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chao : MonoBehaviour
{

    [SerializeField]
    private float velocidade;

    [SerializeField]
    private Vector3 posicaoInicial;

    private float tamanhoRealDaImagem;
    // Start is called before the first frame update

    void Awake()
    {
        posicaoInicial = transform.localPosition;
        float tamanhoDaImagem = GetComponent<SpriteRenderer>().size.x;
        float escala = transform.localScale.x;
        tamanhoRealDaImagem = tamanhoDaImagem * escala;
        Debug.Log(tamanhoRealDaImagem);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float deslocamento = Mathf.Repeat(Time.time * velocidade, tamanhoRealDaImagem);
        transform.position = posicaoInicial + Vector3.left * deslocamento;
    }
}
