using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //public variables
    public float horizontalInput;
    //snelheid van de speler
    public float speed = 10f;
    //hoe ver de speler van het 0 punt mag gaan
    public float xRange = 15;

    public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //krijg horizontale input van speler
        horizontalInput = Input.GetAxisRaw("Horizontal");

        //beweeg de speler gebaseerd op de horizontale input, de snelheid wordt bepaald door variabele speed
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        //stop de beweging van de speler als hij te ver van het speelscherm gaat
        if(transform.position.x < -xRange){
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        else if(transform.position.x > xRange){
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        //spawn een projectiel als je op spatie drukt
        if(Input.GetKeyDown(KeyCode.Space)){
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
