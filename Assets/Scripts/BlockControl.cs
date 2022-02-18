using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class BlockControl : MonoBehaviour
{
    [SerializeField] int can;
    private static int blockSayisi;
    public static int SahneKontrol = 1;
    [SerializeField] Sprite[] block;
    [SerializeField] GameObject Efekt;
    // Start is called before the first frame update
    void Start()
    {
        blockSayisi++;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // kod içinde ayný c#kullanýp farklý iþlemler yapmak için tagleri kullan tagleri kontrol et
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GetComponent<AudioSource>().Play();
        can--;
        if (can == 0)
        {
            GameObject.Destroy(gameObject);
            blockSayisi--;
            GameObject efektimiz = Instantiate(Efekt.gameObject,gameObject.transform.position,Quaternion.identity);
            efektimiz.GetComponent<ParticleSystem>().startColor = gameObject.GetComponent<SpriteRenderer>().color;
        }

        if (blockSayisi == 0)
        {
            GameObject.Find("SahneKontrol").GetComponent<SahneKonrol>().SonrakiSahne();
            SahneKontrol++;
        }
        switch (can)
        {
            case 1:
                gameObject.GetComponent<SpriteRenderer>().color= new Color32(50, 255, 8, 255);
                gameObject.GetComponent<SpriteRenderer>().sprite = block[0];
                break;
            case 2:
                gameObject.GetComponent<SpriteRenderer>().color = new Color32(255, 6, 193, 255);
                gameObject.GetComponent<SpriteRenderer>().sprite = block[1];
                break;

        }
    }

    public static int Sahne()
    {
        return SahneKontrol;
    }
}
