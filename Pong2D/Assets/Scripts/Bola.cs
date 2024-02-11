using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{
    public float velocidadeBola;
    public Rigidbody2D rigidbody2D;
    public AudioSource somDabola;
    public float direcaoAleatoriaX;
    public float direcaoAleatoriaY;

    // Start is called before the first frame update
    void Start()
    {
        MoverBola();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void MoverBola()
    {
        rigidbody2D.velocity = new Vector2(velocidadeBola, velocidadeBola);
    }

    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        somDabola.Play();
        rigidbody2D.velocity += new Vector2(direcaoAleatoriaX, direcaoAleatoriaY);
    }
}
