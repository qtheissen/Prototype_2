using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    //hoe ver het object mag gaan voordat het wordt vernietigd
    private float topBound = 30;
    private float lowerBound = -10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //vernietig het object als het te hoog komt
        if(transform.position.z > topBound){
            Destroy(gameObject);
        }
        //vernietig het object als het te laag komt
        else if(transform.position.z < lowerBound){
            Debug.Log("Game Over");
            Destroy(gameObject);
        }
    }
}
