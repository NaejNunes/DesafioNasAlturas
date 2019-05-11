using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AviaoController : MonoBehaviour
{
    
    Rigidbody2D fisica;

    [SerializeField]
    private float forca = 10f;

    [SerializeField]
    private Diretor diretor;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Começou");
    }
    private void Awake()
    {
        //Debug.Log("Acordei");
        this.fisica = this.GetComponent<Rigidbody2D>();
        diretor = GameObject.FindObjectOfType<Diretor>();
    }

    private void Impulsionar()
    {
        this.fisica.velocity = Vector2.zero;
        this.fisica.AddForce(Vector2.up * forca, ForceMode2D.Impulse);
    }

    void OnCollisionEnter2D(Collision2D colisao)
    {
        fisica.simulated = false;
        diretor.FinalizarJogo();       
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            //Debug.Log("Atirou");
            Impulsionar();
        }
    }
}

