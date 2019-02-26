﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotBro : MonoBehaviour
{
    public AudioClip prepareUranusPrincess;

    private AudioSource source;
    
    void Awake()
    {
        source = GetComponent<AudioSource>();
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnCollisionEnter2D (Collision2D collision)
    {
        if (collision.gameObject.tag == "ThaFatGuy")
        {
            if (!MarioPuppeteer.muerte)
            {
                Destroy(collision.gameObject);
                collision.gameObject.GetComponent<MarioPuppeteer>().ChaoChaoBambino();
                source.PlayOneShot(prepareUranusPrincess,10.5f);
            }
        }
        
    }

    public void Estrellita()
    {

    }

}
