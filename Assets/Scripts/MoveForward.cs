using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    //snelheid van het blikje
    public float speed = 30f;
    //richting die het object opgaat: 0 voor Vector3.up en 1 voor Vector3.forward
    public float direction = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (direction == 0){
            //beweeg het object met de snelheid speed
            transform.Translate(Vector3.up * Time.deltaTime * speed);
        }
        else if (direction == 1){
            //beweeg het object met de snelheid speed
            transform.Translate(Vector3.forward * Time.deltaTime * speed);

        } 

    }
}
