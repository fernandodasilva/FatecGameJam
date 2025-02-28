﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenarioCamera : MonoBehaviour
{
    // Start is called before the first frame update

    Vector3 movement;
    public int cena;
    float Py;

    void Start()
    {
        movement = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {

        Camera cam = Camera.main;
        float height = 2f * cam.orthographicSize;
        float width = height * cam.aspect;

        GetComponent<BoxCollider2D>().size = new Vector2(width, height);

        switch (cena)
        {
            case 1: // halls bala
            Py = 12.90f;
            transform.position = new Vector3(transform.position.x, Py,-10);
            break;
            case 2: // bribrioqueta
            Py = -15.7f;
            transform.position = new Vector3(transform.position.x, Py,-10);
            break;
            case 3: // switch
            Py = 25f;
            transform.position = new Vector3(transform.position.x, Py, -10);
            break;
            case 4: // cozinha
            Py = 62f;
            transform.position = new Vector3(transform.position.x, Py -10);
            break;
            case 5: // sala do RANGO
            Py = 38.5f;
            transform.position = new Vector3(transform.position.x,Py, -10);
            break;
            default: // nada nãp
            break;
        } 
        GetComponent<Rigidbody2D>().AddForce(movement);

    }

    public void GoLeft(){
        movement = new Vector3(-20, 0, 0);
    }

    public void GoRight(){
        movement = new Vector3(20, 0, 0);
    }

    public void StopMove(){
        movement = new Vector3(0, 0, 0);
    }
}
