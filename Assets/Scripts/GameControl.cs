using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    private bool GameStart = false;

    private Vector3 mesafe;
    // Start is called before the first frame update
    void Start()
    {
        mesafe = gameObject.transform.position - GameObject.Find("OyunBarý").gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameStart)
        {
            gameObject.transform.position = GameObject.Find("OyunBarý").gameObject.transform.position + mesafe;
        }

        if (Input.GetMouseButtonDown(0)&&GameStart==false)
        {
            GameStart = true;
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(6f, 18f);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Lose"))
        {
            Destroy(gameObject);
            GameObject.Find("SahneKontrol").GetComponent<SahneKonrol>().KaybetmeSahnesi();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GetComponent<AudioSource>().Play();
        Vector2 Sapma = new Vector2(Random.Range(0f, 0.2f), Random.Range(0f, 0.2f));
        GetComponent<Rigidbody2D>().velocity += Sapma;
    }
}
