using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AviaoController : MonoBehaviour
{
    
    Rigidbody2D fisica;
    [SerializeField]
    private float forca;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Começou");
    }
    private void Awake()
    {
        //Debug.Log("Acordei");
        this.fisica = this.GetComponent<Rigidbody2D>();
    }

    private void Impulsionar()
    {
        this.fisica.AddForce(Vector2.up * forca, ForceMode2D.Impulse);
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

