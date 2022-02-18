using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SahneKonrol : MonoBehaviour
{
    
    public void SonrakiSahne()
    {
        int mevcutSahneninIndeksi = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(mevcutSahneninIndeksi + 1);
    }

    public void KaybetmeSahnesi()
    {
        SceneManager.LoadScene("LoseScence");
    }

    public void OyunSahnesineGit()
    {
        //int mevcutSahneninIndeksi = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(BlockControl.Sahne());
    }

    public void Cikis()
    {
        Application.Quit();
    }
}
