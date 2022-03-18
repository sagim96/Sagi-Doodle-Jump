using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerScript : MonoBehaviour
{
    public GameObject lostCanvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlatformScript>())
            Destroy(other.gameObject);
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<PlayerMovement>())
        {
            lostCanvas.SetActive(true);
            int endscore = other.GetComponent<PlayerMovement>().score;
            if(endscore>PlayerPrefs.GetInt("HS"))
            {
                PlayerPrefs.SetInt("HS", endscore);
            }
        }    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
