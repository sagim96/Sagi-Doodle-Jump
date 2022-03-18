using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public GameObject lostCanvas;
    public DestroyerScript destroyerScript;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerMovement>())
        {
            Destroy(other.gameObject);
            FindObjectOfType<DestroyerScript>().lostCanvas.SetActive(true);
        }
    }
}
