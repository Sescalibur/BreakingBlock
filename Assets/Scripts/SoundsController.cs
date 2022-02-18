using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundsController : MonoBehaviour
{
    private static SoundsController SoundsControl = null;
    // Start is called before the first frame update
    private void Awake()
    {

    }
    void Start()
    {
        if (SoundsControl != null)
        {
            GameObject.Destroy(gameObject);
        }
        else
        {
            SoundsControl = this;
        }
        GameObject.DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
