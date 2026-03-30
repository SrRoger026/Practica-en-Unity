using System.Collections;
using System.Collections.Generic;
using Unity.Burst.Intrinsics;
using UnityEngine;

public class mover : MonoBehaviour
{
    public float velocidad = 10.0f;
    float x, y;
    public float fuerza = 10;
    Rigidbody2D cuerpo;
    public bool tocarPiso = false;
    Animator anim;
    bool verdeOrecha = true;

    //public GameObject poder;
    //public Transform arma;
    public float velocidadbala = 10.0f;
    bool mirarHacia = true;

    void Start()
    {
        cuerpo = GetComponent<Rigidbody2D>();
        //anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        //print(x);
        /*if (x != 0)
        {
            anim.SetBool("run", true);
        }
        else
        {
            anim.SetBool("run", false);
        }*/

        /*if (x > 0 && !verdeOrecha)
        {
            GirarPersonaje();
        }
        else if (x < 0 && verdeOrecha) {
            GirarPersonaje();
        }

        if (Input.GetButtonDown("Fire1")) {
            print("disparar");
            anim.SetTrigger("disparar");
        }*/
    }

    /*public void Disparar()
    {
        Vector2 direccion = verdeOrecha ? Vector2.right : Vector2.left;
        float angulo = verdeOrecha ? 90f : 270f;
        GameObject clon = Instantiate(poder, arma.position, Quaternion.Euler(0, 0, angulo));
        Rigidbody2D cl = clon.GetComponent<Rigidbody2D>();
        cl.velocity = direccion * velocidadbala;
    }

    private void GirarPersonaje()
    {
        verdeOrecha = !verdeOrecha;
        Vector3 giro = transform.localScale;
        giro.x *= -1;
        transform.localScale = giro;
    }*/

    private void FixedUpdate()
    {
        //cuerpo.velocity = new Vector3(x*velocidad*Time.deltaTime, 0, 0);
        cuerpo.velocity = new Vector2(x * velocidad, cuerpo.velocity.y);

        if (Input.GetKey(KeyCode.Space) && tocarPiso)
        {
            //print("brincando");
            //anim.SetBool("brincar", true);
            cuerpo.AddForce(Vector2.up * fuerza, ForceMode2D.Impulse);
            tocarPiso = false;
        }

        if (cuerpo.velocity.y < 0)
        {
            cuerpo.gravityScale = 10;
        }
        else {
            cuerpo.gravityScale = 8;
        }
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("piso")) {
            // print("Pisando el piso");
            tocarPiso = true;
            //anim.SetBool("brincar", false);
        }
    }
}
