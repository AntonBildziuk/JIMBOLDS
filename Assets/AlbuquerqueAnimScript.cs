﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlbuquerqueAnimScript : MonoBehaviour
{
    public GameObject AAAALBUQUERQUE;
    // Start is called before the first frame update
    void Start()
    {
        AAAALBUQUERQUE.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            AAAALBUQUERQUE.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            AAAALBUQUERQUE.SetActive(false);
        }
    }
}
