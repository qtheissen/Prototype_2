using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //OntriggerEnter wordt gecalled als het object in collision komt met een ander object
    private void OnTriggerEnter(Collider other) {
        //het object vernietigt zichzelf
        Destroy(gameObject);
        //het object vernietigt het object waarmee het in collision komt
        Destroy(other.gameObject);
    }
}
