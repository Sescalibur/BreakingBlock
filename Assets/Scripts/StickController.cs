using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickController : MonoBehaviour
{
    public bool otoController;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if (otoController)
        {
            gameObject.transform.position = new Vector3(GameObject.Find("OyunTopu").gameObject.transform.position.x,gameObject.transform.position.y);
        }
        else
        {
            gameObject.transform.position = new Vector3(Mathf.Clamp(Input.mousePosition.x / Screen.width * 16, 1f, 15f), gameObject.transform.position.y, gameObject.transform.position.z);
        }
        
    }
}
