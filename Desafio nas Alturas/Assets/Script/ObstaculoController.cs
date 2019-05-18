using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaculoController : MonoBehaviour
{
    [SerializeField]
    private float velocidade = 0.2f;

    [SerializeField]
    private float variacaoDaPosicaoY;

    private Vector3 posicaoDoAviao;

    private Pontuacao pontuacao;

    private bool pontuei;

    private void Awake()
    {
        transform.Translate(Vector3.up * Random.Range(-variacaoDaPosicaoY, variacaoDaPosicaoY));
    }
    // Start is called before the first frame update
    void Start()
    {
        posicaoDoAviao = GameObject.FindObjectOfType<AviaoController>().transform.position;
        pontuacao = GameObject.FindObjectOfType<Pontuacao>();
    }

    // Update is called once per frame
    void Update()
    {      
        transform.Translate(Vector3.left * velocidade);

        if (!pontuei && this.transform.position.x < posicaoDoAviao.x)
        {
            pontuei = true;

            pontuacao.AdicionaPontos();
        }
    }

    private void OnTriggerEnter2D(Collider2D outro)
    {
        Destruir();
    }

    public void Destruir()
    {
        GameObject.Destroy(this.gameObject);
    }
}
