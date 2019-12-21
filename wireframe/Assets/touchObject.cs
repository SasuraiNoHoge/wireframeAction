using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchObject : MonoBehaviour
{
    public Material wireframeMaterial;
    public Material originMaterial;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay(Collider other)
    {
        other.gameObject.GetComponent<wireframe>().enabled = true;
        other.gameObject.GetComponent<Renderer>().material = wireframeMaterial;
        other.transform.Find("Capsule").GetComponent<MeshRenderer>().enabled = false;
    }

    void OnTriggerExit(Collider other)
    {
        other.gameObject.GetComponent<Renderer>().material = originMaterial;
        other.gameObject.GetComponent<wireframe>().enabled = false;
        other.transform.Find("Capsule").GetComponent<MeshRenderer>().enabled = true;
    }
}
    
