using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerDialog : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponentInChildren<Canvas>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GetComponentInChildren<Canvas>().enabled = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {

        GetComponentInChildren<Canvas>().enabled = false;
    }
}
